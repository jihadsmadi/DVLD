using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
	public class LicenseData
	{
		static public int AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
			string Notes, float PaidFees, bool IsActive, byte IssueReason, int createdByUserID)
		{

			int LicenseID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Licenses values(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@createdByUserID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", DriverID);
			cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
			cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
			if (Notes == null || string.IsNullOrEmpty(Notes))
			{
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Notes", Notes);
			}
		
			cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);
			cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);




			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					LicenseID = InsintionId;

				}

			}
			catch (Exception)
			{
				LicenseID = -1;
			}
			finally { connection.Close(); }


			return LicenseID;
		}

		static public bool UpdateLicense(int LicenseID,int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
			string Notes, float PaidFees, bool IsActive, byte IssueReason, int createdByUserID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Licenses " +
							"SET ApplicationID = @ApplicationID ," +
							"DriverID = @DriverID  ," +
							"LicenseClass = @LicenseClass  ," +
							"IssueDate = @IssueDate  ," +
							"ExpirationDate = @ExpirationDate  ," +
							"Notes = @Notes  ," +
							"PaidFees = @PaidFees  ," +
							"IsActive = @IsActive  ," +
							"IssueReason = @IssueReason  ," +
							"createdByUserID = @createdByUserID  " +
							"  where LicenseID = @LicenseID";

			SqlCommand cmd = new SqlCommand(query, connection);


			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			cmd.Parameters.AddWithValue("@DriverID", DriverID);
			cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
			cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
			cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
			if (Notes == null || string.IsNullOrEmpty(Notes))
			{
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Notes", Notes);
			}
			cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);
			cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
			cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

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

		static public bool DeleteLicense(int LicenseID)
		{


			if (LicenseID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from Licenses where" +
						" LicenseID = @LicenseID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

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

		static public bool isLicenseExists(int LicenseID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Licenses where LicenseID = @LicenseID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LicenseID", LicenseID);


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

		static public bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int  DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref float PaidFees,
				ref bool IsActive, ref byte IssueReason, ref int createdByUserID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Licenses where LicenseID = @LicenseID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@LicenseID", LicenseID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					ApplicationID = (int)reader["ApplicationID"];
					DriverID = (int)reader["DriverID"];
					LicenseClass = (int)reader["LicenseClass"];
					createdByUserID = (int)reader["createdByUserID"];
					IssueDate = (DateTime)reader["IssueDate"];
					ExpirationDate = (DateTime)reader["ExpirationDate"];
					
					if(reader["Notes"] == DBNull.Value)
					{
						Notes = null;
					}
					else
					{
						Notes = (string)reader["Notes"];
					}
					
					PaidFees = Convert.ToSingle( reader["PaidFees"]);
					IsActive = (bool)reader["IsActive"];
					IssueReason = (byte)reader["IssueReason"];

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

		static public int GetLicenseIDByApplicationID(int ApplicationID)
		{

			int LicenseID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "select LicenseID from Licenses where Licenses.ApplicationID = @ApplicationID " ;

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);




			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					LicenseID = InsintionId;

				}

			}
			catch (Exception)
			{
				LicenseID = -1;
			}
			finally { connection.Close(); }


			return LicenseID;
		}

		
		static public DataTable GetLocalLicenseListByDriverID(int DriverID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select LicenseID,ApplicationID,LicenseClasses.ClassName,IssueDate,ExpirationDate,IsActive " +
				"from Licenses inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID " +
				"where Licenses.DriverID = @DriverID ";
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
