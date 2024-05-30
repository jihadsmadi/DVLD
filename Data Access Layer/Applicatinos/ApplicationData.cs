using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
	public class ApplicationData
	{
		
		static public int AddApplication(int ApplicationPersonID, DateTime ApplicationDate,
			int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
		{

			int ApplicationID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Applications values(@ApplicationPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
			cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
			cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);			
			cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
			cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
			cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
		

			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					ApplicationID = InsintionId;

				}

			}
			catch (Exception)
			{
				ApplicationID = -1;
			}
			finally { connection.Close(); }


			return ApplicationID;
		}
		static public int GetRetakeApplicationID(int ApplicationPersonID)
		{

			int ApplicationID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "select ApplicationID from Applications where Applications.ApplicationTypeID = 8 And Applications.ApplicationStatus = 1 And Applications.ApplicantPersonID = @ApplicationPersonID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					ApplicationID = InsintionId;

				}

			}
			catch (Exception)
			{
				ApplicationID = -1;
			}
			finally { connection.Close(); }


			return ApplicationID;
		}
		static public bool UpdateApplication(int ApplicationID,int ApplicationPersonID, DateTime ApplicationDate,
			int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Applications " +
							"SET ApplicantPersonID = @ApplicantPersonID ," +
							"ApplicationDate = @ApplicationDate  ," +
							"ApplicationTypeID = @ApplicationTypeID  ," +
							"ApplicationStatus = @ApplicationStatus ," +
							"LastStatusDate = @LastStatusDate , " +
							"PaidFees = @PaidFees ," +
							"CreatedByUserID = @CreatedByUserID " +
							"  where ApplicationID = @ApplicationID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
			cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
			cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
			cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
			cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
			cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

		static public bool DeleteApplication(int ApplicationID)
		{


			if (ApplicationID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from Applications where" +
						" ApplicationID = @ApplicationID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

		static public bool isApplicationExists(int ApplicationID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Applications where ApplicationID = @ApplicationID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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
		

		static public bool GetApplicationByID(int ApplicationID,ref int ApplicationPersonID, ref DateTime ApplicationDate,
			ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Applications where ApplicationID = @ApplicationID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					ApplicationPersonID = (int)reader["ApplicantPersonID"];
					ApplicationDate = (DateTime)reader["ApplicationDate"];
					ApplicationTypeID = (int)reader["ApplicationTypeID"];
					ApplicationStatus = (byte)reader["ApplicationStatus"];
					LastStatusDate = (DateTime)reader["LastStatusDate"];
					PaidFees = Convert.ToSingle(reader["PaidFees"]);
					CreatedByUserID = (int)reader["CreatedByUserID"];
					
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


		static public DataTable GetApplicationList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from LocalDrivingLicenseApplications_View ";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbApplications = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbApplications.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbApplications;



		}

		static public bool IsPersonHaveCurrentNewLocalLicenseApplication(int ApplicationPersonID,int LicenseClassID)
		{
			

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "select A = 1 from Applications inner join LocalDrivingLicenseApplications " +
				"on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID " +
				"where ApplicantPersonID = @ApplicationPersonID And LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID " +
				"And ( ApplicationStatus = 1 Or ApplicationStatus = 3) ;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
			cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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





	}
}
