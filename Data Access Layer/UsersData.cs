using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class UsersData
	{
		static public int AddUser(string UserName,string Password,bool IsActive,int PersonID)
		{

			int UserID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Users values(@PersonID,@UserName,@Password,@IsActive);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@UserName", UserName);
			cmd.Parameters.AddWithValue("@Password", Password);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);


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

		static public bool UpdateUser(int UserID, string UserName, string Password, bool IsActive, int PersonID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Users " +
							"SET UserName = @UserName ," +
							"Password = @Password  ," +
							"IsActive = @IsActive  ," +
							"PersonID = @PersonID " +							
							"  where UserID = @UserID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@UserID", UserID);
			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@UserName", UserName);
			cmd.Parameters.AddWithValue("@Password", Password);
			cmd.Parameters.AddWithValue("@IsActive", IsActive);


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

		static public bool DeleteUser(int UserID)
		{


			if (UserID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from Users where" +
						" UserID = @UserID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@UserID", UserID);

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

		static public bool isUserExists(int UserID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Users where UserID = @UserID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@UserID", UserID);


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

		static public bool isUserExists(string UserName)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Users where UserName = @UserName";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@UserName", UserName);
			


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

		static public bool isUserExistsByPersonID(int PersonID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Users where PersonID = @PersonID";

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

		static public bool GetUserByID(int UserID, ref string UserName,ref string Password,ref bool IsActive,ref int PersonID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Users where UserID = @UserId;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@UserId", UserID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					UserName = (string)reader["UserName"];
					Password = (string)reader["Password"];					
					IsActive = (bool)reader["IsActive"];
					PersonID = (int)reader["PersonID"];
					

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

		static public bool GetUserByUserNameAndPassword(ref int UserID,  string UserName,  string Password, ref bool IsActive, ref int PersonID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from Users where UserName = @UserName And Password = @Password ;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@UserName", UserName);
			Infocmd.Parameters.AddWithValue("@Password", Password);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					
					IsActive = (bool)reader["IsActive"];
					PersonID = (int)reader["PersonID"];
					UserID = (int)reader["UserID"];


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

		static public DataTable GetUsersList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select Users.UserID, Users.PersonID ," +
				"FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName As FullName, UserName ,IsActive " +
				"from Users inner join People on Users.PersonID = People.PersonID ";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbUsers = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbUsers.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbUsers;



		}




	}
}
