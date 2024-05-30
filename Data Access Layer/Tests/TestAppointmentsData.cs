using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class TestAppointmentsData
	{

		static public int AddTestAppointment(int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate,
			float paidFees, int createdByUserID, bool isLocked)
		{

			int TestAppointmentID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into TestAppointments values(@testTypeID,@localDrivingLicenseApplicationID,@AppointmentDate,@paidFees,@CreatedByUserID,@isLocked);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
			cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
			cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
			cmd.Parameters.AddWithValue("@paidFees", paidFees);
			cmd.Parameters.AddWithValue("@isLocked", isLocked);
			cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					TestAppointmentID = InsintionId;

				}

			}
			catch (Exception)
			{
				TestAppointmentID = -1;
			}
			finally { connection.Close(); }


			return TestAppointmentID;
		}

		static public bool UpdateApplication(int TestAppointmentID,int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate,
			float paidFees, int createdByUserID, bool isLocked)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE TestAppointments " +
							"SET TestTypeID = @testTypeID ," +
							"LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID  ," +
							"AppointmentDate = @appointmentDate  ," +
							"PaidFees = @PaidFees ," +
							"CreatedByUserID = @CreatedByUserID ," +
							"IsLocked = @isLocked " +
							"  where TestAppointmentID = @TestAppointmentID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
			cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
			cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
			cmd.Parameters.AddWithValue("@paidFees", paidFees);
			cmd.Parameters.AddWithValue("@isLocked", isLocked);
			cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
			cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

		static public DataTable GetTestAppointmentByTestTypeAndLDLID(int LDLID,int TestTypeID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select TestAppointments.TestAppointmentID,TestAppointments.AppointmentDate,TestAppointments.PaidFees,TestAppointments.IsLocked from TestAppointments" +
				" where TestAppointments.LocalDrivingLicenseApplicationID = @LDLID AND TestTypeID = @TestTypeID";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LDLID", LDLID);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

			DataTable dbTestAppointments = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbTestAppointments.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbTestAppointments;



		}

		static public byte GetTestTrairCount(int LDLID, int TestTypeID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select count(TestAppointments.TestAppointmentID) from TestAppointments " +
							"where TestAppointments.LocalDrivingLicenseApplicationID = @LDLID and TestAppointments.TestTypeID = @TestTypeID ";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LDLID", LDLID);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

			byte TrailCount = 0;



			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null && byte.TryParse(value.ToString(), out byte InsintionId))
				{
					TrailCount = InsintionId;

				}



			}
			catch (Exception)
			{
				TrailCount = 0;
			}
			finally
			{ sqlConnection.Close(); }


			return TrailCount;



		}

		static public bool IsHasActiveTestAppointment(int LDLID, int TestTypeID)
		{

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 from TestAppointments where LocalDrivingLicenseApplicationID = @LDLID And IsLocked = 0 and TestTypeID = @TestTypeID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LDLID", LDLID);
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

		static public bool isTestAppointmentExists(int TestAppointmentID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From TestAppointments where TestAppointmentID = @TestAppointmentID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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


		static public bool GetTestAppointmentByID(int TestAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID, ref DateTime appointmentDate,
			ref float paidFees, ref int createdByUserID, ref bool isLocked)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from TestAppointments where TestAppointmentID = @TestAppointmentID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					testTypeID = (int)reader["testTypeID"];
					localDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
					appointmentDate = (DateTime)reader["appointmentDate"];
					isLocked = (bool)reader["isLocked"];
					paidFees = Convert.ToSingle(reader["PaidFees"]);
					createdByUserID = (int)reader["CreatedByUserID"];

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

		//
	}
}
