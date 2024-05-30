using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class DriversData
	{
		static public int AddDriver(int PersonID, DateTime CreatedDate, int createdByUserID)
		{

			int UserID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Drivers values(@PersonID,@createdByUserID,@CreatedDate);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
			cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
		


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					UserID = InsintionId;

				}

			}
			catch (Exception)
			{
				UserID = -1;
			}
			finally { connection.Close(); }


			return UserID;
		}

		static public bool UpdateDriver(int DriverID, int PersonID, DateTime CreatedDate, int createdByUserID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Drivers " +
							"SET PersonID = @PersonID ," +
							"createdByUserID = @createdByUserID  ," +
							"CreatedDate = @CreatedDate  ," +
							"  where DriverID = @DriverID";

			SqlCommand cmd = new SqlCommand(query, connection);


			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
			cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
			cmd.Parameters.AddWithValue("@DriverID", DriverID);


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

		static public bool DeleteDriver(int DriverID)
		{


			if (DriverID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from Drivers where" +
						" DriverID = @DriverID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@DriverID", DriverID);

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

		static public bool isDriverExists(int DriverID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Drivers where DriverID = @DriverID";

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

		static public bool isDriverExistsByPersonID(int PersonID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Drivers where PersonID = @PersonID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);


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

	

		static public bool GetDriverByID(int DriverID, ref int PersonID, ref DateTime CreatedDate, ref int createdByUserID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Drivers where DriverID = @DriverID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@DriverID", DriverID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					PersonID = (int)reader["PersonID"];
					createdByUserID = (int)reader["createdByUserID"];
					CreatedDate = (DateTime)reader["CreatedDate"];
					

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

		static public int GetDriverIDByPersonID(int PersonID)
		{
			if (PersonID < 0) 
				return -1;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select DriverID from Drivers where PersonID = @PersonID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@PersonID", PersonID);

			int DriverID = -1;

			try
			{
				sqlConnection.Open();

				object value = Infocmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(),out int DriverIDOut))
				{
					DriverID = DriverIDOut;
					
				}
				else
				{
					DriverID = -1;
				}


			}
			catch (Exception)
			{
				DriverID = -1;

			}
			finally { sqlConnection.Close(); }



			return DriverID ;


		}

		static public int GetPersonIDByDriverID(int DriverID)
		{
			if (DriverID < 0)
				return -1;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select PersonID from Drivers where DriverID = @DriverID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@DriverID", DriverID);

			int PersonID = -1;

			try
			{
				sqlConnection.Open();

				object value = Infocmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int DriverIDOut))
				{
					PersonID = DriverIDOut;

				}
				else
				{
					PersonID = -1;
				}


			}
			catch (Exception)
			{
				PersonID = -1;

			}
			finally { sqlConnection.Close(); }



			return PersonID;


		}

		static public DataTable GetDriversList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from Drivers_View ";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbDrivers = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbDrivers.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbDrivers;



		}

	}
}
