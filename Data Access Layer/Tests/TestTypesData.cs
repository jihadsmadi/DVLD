using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class TestTypesData
	{
		static public DataTable GetTestTypesList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from TestTypes ";
			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbTestTypes = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbTestTypes.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbTestTypes;



		}

		static public bool UpdateTestType(int TestTypeID, string TestTypeTitle,string TestTypeDescription, float TestTypeFees)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE TestTypes " +
							"SET TestTypeTitle = @TestTypeTitle ," +
							"TestTypeDescription = @TestTypeDescription , " +
							" TestTypeFees = @TestTypeFees " +
							"  where TestTypeID = @TestTypeID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
			cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
			cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
			cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);



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

		static public bool GetTestTypeByID(int TestTypeID,ref string TestTypeTitle,ref string TestTypeDescription,ref float TestTypeFees)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from TestTypes where TestTypeID = @TestTypeID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					TestTypeTitle = (string)reader["TestTypeTitle"];
					TestTypeDescription = (string)reader["TestTypeDescription"];
					TestTypeFees = Convert.ToSingle(reader["TestTypeFees"]);




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

		static public bool isTestTypeExists(int TestTypeID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From TestTypes where TestTypeID = @TestTypeID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

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


	}
}
