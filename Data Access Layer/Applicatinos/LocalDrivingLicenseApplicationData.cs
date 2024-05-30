using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class LocalDrivingLicenseApplicationData
	{

		static public int AddLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
		{

			int LocalDrivingLicenseApplicationID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into LocalDrivingLicenseApplications values(@ApplicationID,@LicenseClassID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					LocalDrivingLicenseApplicationID = InsintionId;

				}

			}
			catch (Exception)
			{
				ApplicationID = -1;
			}
			finally { connection.Close(); }


			return LocalDrivingLicenseApplicationID;
		}

		static public bool UpdateApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE LocalDrivingLicenseApplications " +
							"SET ApplicationID = @ApplicationID ," +
							"LicenseClassID = @LicenseClassID  " +
							"  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
			cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			

			try
			{
				connection.Open();

				int EffectedRows = cmd.ExecuteNonQuery();


				if (EffectedRows > 0)
				{
					isUpdate = true;

				}
				else
				{
					isUpdate = false;
				}


			}
			catch (Exception)
			{
				isUpdate = false;

			}
			finally { connection.Close(); }


			return isUpdate;
		}

		static public bool DeleteApplication(int LocalDrivingLicenseApplicationID)
		{


			if (LocalDrivingLicenseApplicationID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from LocalDrivingLicenseApplications where" +
						" LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

			int RowsEfficted = -1;




			try
			{
				sqlConnection.Open();

				RowsEfficted = cmd.ExecuteNonQuery();

			}
			catch (Exception)
			{
				return false;
			}
			finally { sqlConnection.Close(); }


			return RowsEfficted > 0;
		}

		static public bool isLocalDrivingLicenseApplicationExists(int LocalDrivingLicenseApplicationID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null)
				{
					return true;
				}
				else return false;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{ sqlConnection.Close(); }







		}

		static public bool GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					ApplicationID = (int)reader["ApplicationID"];
					LicenseClassID = (int)reader["LicenseClassID"];
					
					isFind = true;

					reader.Close();



				}
				else
				{
					isFind = false;
				}


			}
			catch (Exception)
			{
				isFind = false;

			}
			finally { sqlConnection.Close(); }



			return isFind;


		}

		static public DataTable GetLocalDrivingLicenseApplicationList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from LocalDrivingLicenseApplications_View ";
			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbLocalDrivingLicenseApplications = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbLocalDrivingLicenseApplications.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbLocalDrivingLicenseApplications;



		}

	}
}
