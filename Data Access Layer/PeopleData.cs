using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class PeopleData
	{

		static public int AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, Byte Gendor,
			string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{

			int PersonID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into People values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
			cmd.Parameters.AddWithValue("@FirstName", FirstName);
			cmd.Parameters.AddWithValue("@SecondName", SecondName);
			if(ThirdName != null)
			{
				cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
			}
			
			cmd.Parameters.AddWithValue("@LastName", LastName);
			cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			cmd.Parameters.AddWithValue("@Gendor", Gendor);			
			cmd.Parameters.AddWithValue("@Address", Address);
			cmd.Parameters.AddWithValue("@Phone",Phone);
			if (Email != null)
			{
				cmd.Parameters.AddWithValue("@Email", Email);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Email", DBNull.Value);
			}
			
			cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
			if (ImagePath != null)
			{
				cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
			}
			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					PersonID = InsintionId;

				}

			}
			catch (Exception)
			{
				PersonID = -1;
			}
			finally { connection.Close(); }


			return PersonID;
		}

		static public bool UpdatePerson(int PersonID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, Byte Gendor,
			string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE People " +
							"SET NationalNo = @NationalNo ," +
							"FirstName = @FirstName  ," +
							"SecondName = @SecondName  ," +
							"ThirdName = @ThirdName ," +
							"LastName = @LastName , " +
							"DateOfBirth = @DateOfBirth ," +
							"Gendor = @Gendor ," +
							"Address = @Address ," +
							"Phone = @Phone ," +
							"Email = @Email ," +
							"NationalityCountryID = @NationalityCountryID ," +
							"ImagePath = @ImagePath " +
							"  where PersonID = @personID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
			cmd.Parameters.AddWithValue("@FirstName", FirstName);
			cmd.Parameters.AddWithValue("@SecondName", SecondName);
			if (ThirdName != null)
			{
				cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
			}

			cmd.Parameters.AddWithValue("@LastName", LastName);
			cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			cmd.Parameters.AddWithValue("@Gendor", Gendor);
			cmd.Parameters.AddWithValue("@Address", Address);
			cmd.Parameters.AddWithValue("@Phone", Phone);
			if (Email != null)
			{
				cmd.Parameters.AddWithValue("@Email", Email);
			}
			else
			{
				cmd.Parameters.AddWithValue("@Email", DBNull.Value);
			}

			cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
			if (ImagePath != null)
			{
				cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
			}




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

		static public bool DeletePerson(int PersonID)
		{


			if (PersonID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from People where" +
						" PersonID = @PersonID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);

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

		static public bool isPersonExists(int PersonID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From People where PersonID = @PersonID";

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
		static public bool isPersonExists(string NationalNo)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From People where NationalNo = @NationalNo";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


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

		static public bool isEmailUsed(string Email)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From People where Email = @Email";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@Email", Email);


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

		static public bool isNationalNoUsed(string NationalNo)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From People where NationalNo = @NationalNo";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


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

		static public string GetCountryNameByCountryID(int countryID)
		{
			
			string result = null;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select CountryName from Countries where CountryID = @CountryID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@CountryID", countryID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					result = Convert.ToString(reader["CountryName"]);

					reader.Close();



				}
				else
				{
					result = null;
				}


			}
			catch (Exception)
			{
				result = null;

			}
			finally { sqlConnection.Close(); }



			return result;

		}

		static public bool GetPersonByID(int PersonID,ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
			ref Byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from People where PersonID = @PersonId;";

			
			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);
			

			Infocmd.Parameters.AddWithValue("@PersonId", PersonID);
			

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					FirstName = (string)reader["FirstName"];
					SecondName = (string)reader["SecondName"];
					if(reader["ThirdName"] != DBNull.Value)
					{
						ThirdName = (string)reader["ThirdName"];
					}
					else
					{
						ThirdName= null;
					}
					
					LastName = (string)reader["LastName"];
					NationalNo = (string)reader["NationalNo"];
					DateOfBirth = (DateTime)reader["DateOfBirth"];
					Gendor = (byte)reader["Gendor"];
					Address = (string)reader["Address"];
					Phone = (string)reader["Phone"];
					if (reader["Email"] != DBNull.Value)
					{
						Email = (string)reader["Email"];
					}
					else
					{
						Email = null;
					}
					
					NationalityCountryID = (int)reader["NationalityCountryID"];
					if (reader["ImagePath"] != DBNull.Value)
					{
						ImagePath = (string)reader["ImagePath"];
					}
					else
					{
						ImagePath = null;
					}
					


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

		static public bool GetPersonByNationalNo(ref int PersonID,  string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
			ref Byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from People where NationalNo = @NationalNo;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@NationalNo", NationalNo);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					PersonID = (int)reader["PersonID"];
					FirstName = (string)reader["FirstName"];
					SecondName = (string)reader["SecondName"];
					if (reader["ThirdName"] != DBNull.Value)
					{
						ThirdName = (string)reader["ThirdName"];
					}
					else
					{
						ThirdName = null;
					}

					LastName = (string)reader["LastName"];
					DateOfBirth = (DateTime)reader["DateOfBirth"];
					Gendor = (byte)reader["Gendor"];
					Address = (string)reader["Address"];
					Phone = (string)reader["Phone"];
					if (reader["Email"] != DBNull.Value)
					{
						Email = (string)reader["Email"];
					}
					else
					{
						Email = null;
					}

					NationalityCountryID = (int)reader["NationalityCountryID"];
					if (reader["ImagePath"] != DBNull.Value)
					{
						ImagePath = (string)reader["ImagePath"];
					}
					else
					{
						ImagePath = null;
					}



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

		static public DataTable GetPeopleList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select  PersonID,NationalNo, FirstName + ' ' +People.SecondName+ ' '+ThirdName+' '+LastName As Name," +
				"Gendor = CASE WHEN Gendor= 0 THEN 'Male' WHEN Gendor= 1 THEN'Female' ELSE 'Unknown' END " +
				",Countries.CountryName,Email,Address,Phone,ImagePath from People inner join Countries on People.NationalityCountryID = Countries.CountryID ";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbPeople = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbPeople.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbPeople;



		}

		static public DataTable GetCountriesList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from Countries";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbCountries = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbCountries.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbCountries;



		}
	}
}
