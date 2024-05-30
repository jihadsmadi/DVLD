using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data_Access_Layer
{
	public class TestsData
	{

		static public sbyte GetPassedTestCount(int LDLApplicationID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "SELECT COUNT(dbo.TestAppointments.TestTypeID) AS PassedTestCount " +
				"FROM dbo.Tests INNER JOIN dbo.TestAppointments " +
				"ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID" +
				"  WHERE (dbo.TestAppointments.LocalDrivingLicenseApplicationID = @LDLApplicationID) AND (dbo.Tests.TestResult = 1) ";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);
			cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

			sbyte result = 0;


			try
			{
				sqlConnection.Open();

				object value  = cmd.ExecuteScalar();

				if(value != null &&sbyte.TryParse(value.ToString(), out sbyte output))
				{
					result = output;
				}



			}
			catch (Exception)
			{
				result = 0;
			}
			finally
			{ sqlConnection.Close(); }


			return result;



		}
		static public bool IsPassedTest(int LDLID,int TestTypeID)
		{
			
				SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

				string Quere = "select top 1 A = 1 from Tests where Tests.TestAppointmentID  " +
				" in (select TestAppointmentID from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID And TestAppointments.TestTypeID = @TestTypeID) " +
				"And Tests.TestResult = 1";

				SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

				cmd.Parameters.AddWithValue("@LDLAppID", LDLID);
				cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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
		static public bool IsRetakeTest(int LDLID, int TestTypeID)
		{

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select top 1 A = 1 from Tests where Tests.TestAppointmentID  " +
			" in (select TestAppointmentID from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID And TestAppointments.TestTypeID = @TestTypeID) " +
			"And Tests.TestResult = 0";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LDLAppID", LDLID);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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
		static public int AddTest(int TestAppointmentID, bool TestResult, string Notes, int createdByUserID)
		{

			int TestID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Tests values(@TestAppointmentID,@TestResult,@Notes,@createdByUserID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
			cmd.Parameters.AddWithValue("@TestResult", TestResult);
			if(Notes == null || string.IsNullOrEmpty(Notes))
			{
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Notes", Notes);
			}
			
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
			

			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					TestID = InsintionId;

				}

			}
			catch (Exception)
			{
				TestAppointmentID = -1;
			}
			finally { connection.Close(); }


			return TestID;
		}
		static public bool UpdateTest(int TestID,int TestAppointmentID, bool TestResult, string Notes, int createdByUserID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Tests " +
							"SET TestAppointmentID = @TestAppointmentID ," +
							"TestResult = @TestResult  ," +
							"Notes = @Notes  ," +
							"CreatedByUserID = @CreatedByUserID ," +

							"  where TestID = @TestID";

			SqlCommand cmd = new SqlCommand(query, connection);


			cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
			cmd.Parameters.AddWithValue("@TestResult", TestResult);
			if (Notes == null)
			{
				cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Notes", Notes);
			}
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
			cmd.Parameters.AddWithValue("@TestID", TestID);


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
		static public bool isTestExists(int TestID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Tests where TestID = @TestID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@TestID", TestID);


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
		static public bool GetTestByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes ,ref int createdByUserID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Tests where TestID = @TestID ;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@TestID", TestID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					TestAppointmentID = (int)reader["TestAppointmentID"];
					TestResult = (bool)reader["TestResult"];
					if(reader["Notes"] == DBNull.Value)
					{
						Notes = null;
					}
					else
					{
						Notes = (string)reader["Notes"];
					}
					
					createdByUserID = (int)reader["createdByUserID"];
					

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


	}
}
