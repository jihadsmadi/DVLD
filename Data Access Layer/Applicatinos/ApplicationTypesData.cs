using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class ApplicationTypesData
	{

		static public DataTable GetApplicationTypesList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from ApplicationTypes ";
			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbApplicationTypes = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbApplicationTypes.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbApplicationTypes;



		}

		static public bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE ApplicationTypes " +
							"SET ApplicationTypeTitle = @ApplicationTypeTitle ," +
							"ApplicationFees = @ApplicationFees  " +

							"  where ApplicationTypeID = @ApplicationTypeID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
			cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
			cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
			


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

		static public bool GetApplicationTypeByID(int ApplicationTypeID,ref string ApplicationTypeTitle,ref float ApplicationFees)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
					ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);
				



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

		static public bool isApplicationTypeExists(int ApplicationTypeID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


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
