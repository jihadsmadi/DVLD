using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
	public class LicenseClassData
	{
		static public DataTable GetLicenseClassNameList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select ClassName from LicenseClasses ";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbClassName = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbClassName.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbClassName;



		}

		static public string LicenseClassNameByID(int ClassLicenseID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select ClassName from LicenseClasses where LicenseClassID = @LicenseClassID ";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LicenseClassID", ClassLicenseID);

			string Result = null;



			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();

				if(value!= null )
				{
					Result = value.ToString();
				}



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return Result;

		}

		static public int ValidityLengthByClassID(int LicenseClassID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select DefaultValidityLength from LicenseClasses where LicenseClassID = @LicenseClassID ";



			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

			int Result = -1;



			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null && int.TryParse(value.ToString(), out int outValue))
				{
					Result = outValue;
				}



			}
			catch (Exception)
			{
				Result = -1;
			}
			finally
			{ sqlConnection.Close(); }


			return Result;


		}

		static public bool isLicenseClassExists(int LicenseClassID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From LicenseClasses where LicenseClassID = @LicenseClassID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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

		static public bool GetLicenseClassByID(int ClassLicenseID, ref string ClassName, ref string ClassDescription, ref Byte MinimumAllowedAge, ref Byte DefaultValidityLength,ref float ClassFees)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string InfoQuere = "select * from LicenseClasses where LicenseClassID = @LicenseClassID;";


			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);


			Infocmd.Parameters.AddWithValue("@LicenseClassID", ClassLicenseID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();


				if (reader.Read())
				{
					ClassName = (string)reader["ClassName"];
					ClassDescription = (string)reader["ClassDescription"];
					MinimumAllowedAge = (Byte)reader["MinimumAllowedAge"];
					DefaultValidityLength = (Byte)reader["DefaultValidityLength"];
					ClassFees = Convert.ToSingle( reader["ClassFees"]);

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
