using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
	public class DetainLicensesData
	{
		static public int AddDetain (int LicenseID,DateTime DetainDate,float FineFees,int CreatedByUserID,bool IsReleased, DateTime? ReleaseDate,
			int? ReleasedByUserID,int? ReleaseApplicationID)
		{

			int DetainID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into DetainedLicenses values(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID );" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
			cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
			cmd.Parameters.AddWithValue("@FineFees", FineFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

			if (ReleaseDate == null || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
			}

			if (ReleasedByUserID == -1 || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
			}

			if (ReleaseApplicationID == -1 || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
			}
			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					DetainID = InsintionId;

				}

			}
			catch (Exception)
			{
				DetainID = -1;
			}
			finally { connection.Close(); }


			return DetainID;
		}

		static public bool UpdateDetain (int DetainID,int LicenseID,DateTime DetainDate,float FineFees,int CreatedByUserID,bool IsReleased, DateTime? ReleaseDate,
			int? ReleasedByUserID,int? ReleaseApplicationID)
		{



			bool isUpdate = false;


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE DetainedLicenses " +
							"SET LicenseID = @LicenseID ," +
							"DetainDate = @DetainDate  ," +
							"FineFees = @FineFees  ," +
							"CreatedByUserID = @CreatedByUserID  ," +
							"IsReleased = @IsReleased  ," +
							"ReleaseDate = @ReleaseDate  ," +
							"ReleasedByUserID = @ReleasedByUserID  ," +
							"ReleaseApplicationID = @ReleaseApplicationID  " +
							"  where DetainID = @DetainID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@DetainID", DetainID);
			cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
			cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
			cmd.Parameters.AddWithValue("@FineFees", FineFees);
			cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
			cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

			if (ReleaseDate == null || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
			}

			if (ReleasedByUserID == -1 || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
			}

			if (ReleaseApplicationID == -1 || IsReleased == false)
			{
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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

		static public bool DeleteDetain(int DetainID)
		{


			if (DetainID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from DetainedLicenses where" +
						" DetainID = @DetainID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@DetainID", DetainID);

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

		static public bool isDetainLicenseExists(int DetainID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From DetainedLicenses where DetainID = @DetainID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@DetainID", DetainID);


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

		static public bool isLicenesDetained(int LicenseID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";

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

		static public bool GetDetainByID (int DetainID,ref int LicenseID, ref DateTime DetainDate, ref float FineFees,ref int CreatedByUserID,ref bool IsReleased, ref DateTime? ReleaseDate,
			ref int? ReleasedByUserID,ref int? ReleaseApplicationID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from DetainedLicenses where DetainID = @DetainID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@DetainID", DetainID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					LicenseID = (int)reader["LicenseID"];
					DetainDate = (DateTime)reader["DetainDate"];
					FineFees = Convert.ToSingle( reader["FineFees"]);
					CreatedByUserID = (int)reader["CreatedByUserID"];
					IsReleased = (bool)reader["IsReleased"];
					

					if (reader["ReleaseDate"] == DBNull.Value)
					{
						ReleaseDate = null;
					}
					else
					{
						ReleaseDate = (DateTime)reader["ReleaseDate"];
					}

					if (reader["ReleasedByUserID"] == DBNull.Value)
					{
						ReleasedByUserID = null;
					}
					else
					{
						ReleasedByUserID = (int)reader["ReleasedByUserID"];
					}

					if (reader["ReleaseApplicationID"] == DBNull.Value)
					{
						ReleaseApplicationID = null;
					}
					else
					{
						ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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

		static public bool GetDetainByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
			ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@LicenseID", LicenseID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					DetainID = (int)reader["DetainID"];
					DetainDate = (DateTime)reader["DetainDate"];
					FineFees = Convert.ToSingle(reader["FineFees"]);
					CreatedByUserID = (int)reader["CreatedByUserID"];
					IsReleased = (bool)reader["IsReleased"];


					if (reader["ReleaseDate"] == DBNull.Value)
					{
						ReleaseDate = null;
					}
					else
					{
						ReleaseDate = (DateTime)reader["ReleaseDate"];
					}

					if (reader["ReleasedByUserID"] == DBNull.Value)
					{
						ReleasedByUserID = null;
					}
					else
					{
						ReleasedByUserID = (int)reader["ReleasedByUserID"];
					}

					if (reader["ReleaseApplicationID"] == DBNull.Value)
					{
						ReleaseApplicationID = null;
					}
					else
					{
						ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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


		static public DataTable GetDetainedLicensesList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from DetainedLicenses_View ";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbDetainedLicenses = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbDetainedLicenses.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbDetainedLicenses;



		}



	}
}
