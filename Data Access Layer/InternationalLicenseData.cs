using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class InternationalLicenseData
	{
		static public int AddInternationLicense(int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,DateTime IssueDate,DateTime ExpirationData,bool IsActive,int CreatedByUserID)
		{

			int InternationalLicenseID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into InternationalLicenses values(@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationData,@IsActive,@CreatedByUserID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", DriverID);
			cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
			cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationData", ExpirationData);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					InternationalLicenseID = InsintionId;

				}

			}
			catch (Exception)
			{
				InternationalLicenseID= -1;
			}
			finally { connection.Close(); }


			return InternationalLicenseID;
		}

		static public bool UpdateInternationLicense(int InternationalLicenseID,int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, 
			DateTime IssueDate, DateTime ExpirationData, bool IsActive, int CreatedByUserID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE InternationalLicenses " +
							"SET ApplicationID = @ApplicationID ," +
							"DriverID = @DriverID  " +
							"IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID  " +
							"IssueDate = @IssueDate  " +
							"ExpirationDate = @ExpirationData  " +
							"IsActive = @IsActive  " +
							"CreatedByUserID = @CreatedByUserID  " +
							"  where InternationalLicenseID = @InternationalLicenseID";

			SqlCommand cmd = new SqlCommand(query, connection);


			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", DriverID);
			cmd.Parameters.AddWithValue("@IssueUsingLocalLicenseID", IssuedUsingLocalLicenseID);
			cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationData);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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

		static public bool DeleteInternationalLicense(int InternationalLicenseID)
		{


			if (InternationalLicenseID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from InternationalLicenses where" +
						" InternationalLicenseID = @InternationalLicenseID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

		static public bool isInternaitonLicenseExists(int InternationalLicenseID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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

		static public DataTable GetInternationLicenseList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select InternationalLicenseID as Int_License_ID,ApplicationID,DriverID," +
				"IssuedUsingLocalLicenseID as L_LicenseID,IssueDate,ExpirationDate,IsActive From InternationalLicenses ; ";
			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable db = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					db.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return db;



		}

		static public bool GetLicenseByID(int InternationalLicenseID,ref int ApplicationID, ref int DriverID, ref int IssueUsingLocalLicenseID,
			ref DateTime IssueDate, ref DateTime ExpirationData, ref bool IsActive, ref int CreatedByUserID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					InternationalLicenseID = (int)reader["InternationalLicenseID"];
					ApplicationID = (int)reader["ApplicationID"];
					DriverID = (int)reader["DriverID"];
					IssueUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
					CreatedByUserID = (int)reader["CreatedByUserID"];
					IssueDate = (DateTime)reader["IssueDate"];
					ExpirationData = (DateTime)reader["ExpirationDate"];
					IsActive = (bool)reader["IsActive"];

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

		static public bool DoseDriverHasInternationLicense(int DriverID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From InternationalLicenses where DriverID = @DriverID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@DriverID", DriverID);


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

		static public DataTable GetInternationalLicenseListByDriverID(int DriverID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select InternationalLicenseID,ApplicationID,IssuedUsingLocalLicenseID as LocalLicenseID,IssueDate,ExpirationDate,IsActive" +
				" from InternationalLicenses where DriverID = @DriverID ;";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@DriverID", DriverID);

			DataTable db = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					db.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return db;



		}



	}

}

