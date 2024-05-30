using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsDrivers
	{
		public int DriverID { get; set; }

		public int PersonID { get; set; }

		public int CreatedByUserID { get;}

		public DateTime CreatedDate { get; set; }

		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }


		public clsDrivers(int PersonID,DateTime CreatedDate, int createdByUserID)
		{
			DriverID = -1;
			this.PersonID = PersonID;
			this.CreatedDate = CreatedDate;
			this.CreatedByUserID = createdByUserID;
	


			_Mode = enMode.AddNew;
		}

		private clsDrivers(int DriverID,int PersonID, DateTime CreatedDate, int createdByUserID)
		{
			this.DriverID = DriverID;
			this.PersonID = PersonID;
			this.CreatedDate = CreatedDate;
			this.CreatedByUserID = createdByUserID;



			_Mode = enMode.Update;
		}


		private bool _AddNew()
		{
			this.DriverID = DriversData.AddDriver(this.PersonID,this.CreatedDate,this.CreatedByUserID);

			return (this.DriverID != -1);
		}
		private bool _Update()
		{
			return DriversData.UpdateDriver(this.DriverID,this.PersonID, this.CreatedDate, this.CreatedByUserID); 
		}
		public bool Save()
		{
			switch (this._Mode)
			{
				case enMode.AddNew:
					if (this._AddNew())
					{
						this._Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:
					if (this._Update())
						return true;
					else
						return false;
			}
			return false;
		}

		public static bool IsDriverExists(int DriverID)
		{
			return DriversData.isDriverExists(DriverID);
		}
		public static bool IsDriverExistsByPersonID(int PersonID)
		{
			return DriversData.isDriverExistsByPersonID(PersonID);
		}
		static public clsDrivers Find(int DriverID)
		{

			if (!IsDriverExists(DriverID))
			{
				return null;
			}

			int PersonID = -1, CreatedByUserID = -1;
			DateTime CreatedDate= DateTime.MinValue;

			if (DriversData.GetDriverByID(DriverID,ref PersonID, ref CreatedDate, ref CreatedByUserID) == true)
			{
				return new clsDrivers(DriverID,PersonID, CreatedDate, CreatedByUserID);
			}

			else
			{
				return null;
			}


		}

		static public int GetDriverIDByPersonID(int personID)
		{
			return DriversData.GetDriverIDByPersonID(personID);
		}

		static public DataTable DriversList()
		{
			return DriversData.GetDriversList();
		}

		static public int PersonIDByDriverID(int DriverID)
		{
			return DriversData.GetPersonIDByDriverID(DriverID);
		}
	}
}
