using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsInternationalLicense
	{
		public int InternationalLicenseID { get; set; }
		public int ApplicationID { get; set; }
		public int DriverID { get; set; }
		public int IssueUsingLocalLicenseID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public bool IsActive { get; set; }
		public int CreatedByUserID { get; set; }

		enum _enMode { AddNew = 1, Update = 2 };
		private _enMode Mode;


		public clsInternationalLicense(int applicationID,int DriverID,int IssuerUsingLocalLicenseID,
			DateTime IssueDate,DateTime ExpirationDate,bool IsActive, int CreatedByUserID)
		{
			this.InternationalLicenseID = -1;
			this.ApplicationID = applicationID;
			this.DriverID = DriverID;
			this.IssueUsingLocalLicenseID = IssuerUsingLocalLicenseID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.IsActive = IsActive;
			this.CreatedByUserID= CreatedByUserID;

			Mode = _enMode.AddNew;
		}

		private clsInternationalLicense(int InternationLicenseID,int applicationID, int DriverID, int IssuerUsingLocalLicenseID,
			DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
		{
			this.InternationalLicenseID = InternationLicenseID;
			this.ApplicationID = applicationID;
			this.DriverID = DriverID;
			this.IssueUsingLocalLicenseID = IssuerUsingLocalLicenseID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.IsActive = IsActive;
			this.CreatedByUserID = CreatedByUserID;

			Mode = _enMode.Update;
		}


		public static bool DeleteInternationalDrivingLicense(int InternationalLicenseID)
		{
			return InternationalLicenseData.DeleteInternationalLicense(InternationalLicenseID);
		}
		private bool _AddNew()
		{
			this.InternationalLicenseID = InternationalLicenseData.AddInternationLicense(this.ApplicationID, this.DriverID, this.IssueUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

			return (this.InternationalLicenseID != -1);
		}
		private bool _Update()
		{
			return InternationalLicenseData.UpdateInternationLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssueUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
		}
		public bool Save()
		{
			switch (this.Mode)
			{
				case _enMode.AddNew:
					if (this._AddNew())
					{
						this.Mode = _enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case _enMode.Update:
					if (this._Update())
						return true;
					else
						return false;
			}
			return false;
		}
		public static bool DoseDriverHasInternationLicense(int DriverID)
		{
			return InternationalLicenseData.DoseDriverHasInternationLicense(DriverID);
		}
		public static bool IsInternationLicenseExists(int InternationalLicenseID)
		{
			return InternationalLicenseData.isInternaitonLicenseExists(InternationalLicenseID);
		}
		static public clsInternationalLicense Find(int InternationalLicenseID)
		{

			if (!IsInternationLicenseExists(InternationalLicenseID))
			{
				return null;
			}

			
			int ApplicationID        =-1;
			int DriverID             =-1;
			int IssueUsingLocalLicensID=-1;
			DateTime IssueDate			 =DateTime.Now;
			DateTime ExpirationDate = DateTime.Now;
			bool IsActive			 =false;
			int CreatedByUserID = -1;
			



			if (InternationalLicenseData.GetLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssueUsingLocalLicensID, ref IssueDate, ref ExpirationDate, ref IsActive,ref CreatedByUserID) == true)
			{
				return new clsInternationalLicense(ApplicationID,DriverID,IssueUsingLocalLicensID,IssueDate,ExpirationDate,IsActive,CreatedByUserID);
			}

			else
			{
				return null;
			}


		}
		static public DataTable InternationlLicense()
		{
			return InternationalLicenseData.GetInternationLicenseList();
		}
		static public DataTable GetInternationalLicenseListByDriverID(int DriverID)
		{
			return InternationalLicenseData.GetInternationalLicenseListByDriverID(DriverID);
		}




	}
}
