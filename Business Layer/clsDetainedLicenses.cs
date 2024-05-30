using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsDetainedLicenses
	{
		public int DetainID { get; set; }
		public int LicensesID { get; set; }
		public DateTime DetainDate { get; set; }
		public float FineFees { get; set; }
		public int CreatedByUserID { get; set; }

		public bool IsReleased { get; set; }
		public DateTime? ReleaseDate { get; set; }
		public int? ReleasedByUserID { get; set; }
		public int? ReleaseApplicationID { get; set; }

		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }


		public clsDetainedLicenses(int LicenseID,DateTime DetainDate,float FineFees,int CreatedByUserID,bool IsReleased,DateTime? ReleaseDate,int  ?ReleasedByUserID,int? ReleaseApplicationID)
		{
			this.DetainID = -1;
			this.LicensesID = LicenseID;
			this.DetainDate= DetainDate;
			this.FineFees= FineFees;
			this.CreatedByUserID= CreatedByUserID;
			this.IsReleased= IsReleased;
			this.ReleaseDate= ReleaseDate;
			this.ReleasedByUserID = ReleasedByUserID;
			this.ReleaseApplicationID = ReleaseApplicationID;


			_Mode = enMode.AddNew;
		}

		private clsDetainedLicenses(int DetainID,int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ?ReleaseDate, int? ReleasedByUserID, int ? ReleaseApplicationID)
		{
			this.DetainID = DetainID;
			this.LicensesID = LicenseID;
			this.DetainDate = DetainDate;
			this.FineFees = FineFees;
			this.CreatedByUserID = CreatedByUserID;
			this.IsReleased = IsReleased;
			this.ReleaseDate = ReleaseDate;
			this.ReleasedByUserID = ReleasedByUserID;
			this.ReleaseApplicationID = ReleaseApplicationID;


			_Mode = enMode.Update;
		}


		private bool _AddNew()
		{
			this.DetainID = DetainLicensesData.AddDetain(this.LicensesID,this.DetainDate,this.FineFees,this.CreatedByUserID,this.IsReleased,this.ReleaseDate,this.ReleasedByUserID,this.ReleaseApplicationID);

			return (this.DetainID != -1);
		}
		private bool _Update()
		{
			return DetainLicensesData.UpdateDetain(this.DetainID, this.LicensesID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
		
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
		public static bool IsDetainLicenseExists(int DetainID)
		{
			return DetainLicensesData.isDetainLicenseExists(DetainID);
		}
		static public clsDetainedLicenses Find(int DetainID)
		{

			if (!IsDetainLicenseExists(DetainID))
			{
				return null;
			}
			int LicenseID = -1, createdByUserID = -1;
			int? ReleaseByUserID = -1, ReleaseApplicationID = -1;
			DateTime? ReleaseDate=DateTime.MinValue;
			DateTime DetainDate = DateTime.MinValue;
			float FineFees=-1;
			bool isReleased = false;
			

			if (DetainLicensesData.GetDetainByID(DetainID,ref LicenseID, ref DetainDate, ref FineFees, ref createdByUserID, ref isReleased, ref ReleaseDate,
				ref ReleaseByUserID, ref ReleaseApplicationID) == true)
			{
				return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, createdByUserID, isReleased, ReleaseDate, ReleaseByUserID, ReleaseApplicationID);
			}

			else
			{
				return null;
			}


		}
		static public clsDetainedLicenses FindByLicenseID(int LicenseID)
		{

			/*if (!IsDetainLicenseExists(DetainID))
			{
				return null;
			}*/

			int DetainID = -1, createdByUserID = -1;
			int? ReleaseByUserID = -1, ReleaseApplicationID = -1;
			DateTime? ReleaseDate = DateTime.MinValue;
			DateTime DetainDate = DateTime.MinValue;
			float FineFees = -1;
			bool isReleased = false;


			if (DetainLicensesData.GetDetainByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref createdByUserID, ref isReleased, ref ReleaseDate,
				ref ReleaseByUserID, ref ReleaseApplicationID) == true)
			{
				return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, createdByUserID, isReleased, ReleaseDate, ReleaseByUserID, ReleaseApplicationID);
			}

			else
			{
				return null;
			}


		}
		static public bool isLicenesDetained(int LicenseID)
		{
			return DetainLicensesData.isLicenesDetained(LicenseID);
		}

		static public DataTable DeatinedLicenseList()
		{
			return DetainLicensesData.GetDetainedLicensesList();
		}



	}
}
