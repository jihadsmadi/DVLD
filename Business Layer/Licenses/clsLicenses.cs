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
	public class clsLicenses
	{
		public int LicenseID { get; set; }

		public int ApplicationID { get; set; }

		public int DriverID { get; set; }

		public int LicenseClass { get; set; }

		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }

		public string Notes { get; set; }

		public float PaidFees { get; set; }

		public bool IsActive { get; set; }

		public byte IssueReason { get; set; }

		public int CreatedByUserID { get; set; }

		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }

		public enum enIssueReason { FirstTime =1,Renew = 2,ReplacmentForDamaged = 3,ReplacmentForLost=4 };

		public clsLicenses(int ApplicationID,int DriverID,int LicenseClass,DateTime IssueDate,DateTime ExpirationDate,string Notes,float PaidFees,bool IsActive ,byte IssueReason,int createdByUserID)
		{
			this.LicenseID = -1;
			this.ApplicationID= ApplicationID;
			this.DriverID= DriverID;
			this.LicenseClass= LicenseClass;
			this.IssueDate= IssueDate;
			this.ExpirationDate= ExpirationDate;
			this.Notes = Notes;
			this.PaidFees= PaidFees;
			this.IsActive= IsActive;
			this.IssueReason= IssueReason;
			this.CreatedByUserID= createdByUserID;


			_Mode = enMode.AddNew;
		}

		private clsLicenses(int LicenseID,int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, byte IssueReason, int createdByUserID)
		{
			this.LicenseID = LicenseID;
			this.ApplicationID = ApplicationID;
			this.DriverID = DriverID;
			this.LicenseClass = LicenseClass;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.Notes = Notes;
			this.PaidFees = PaidFees;
			this.IsActive = IsActive;
			this.IssueReason = IssueReason;
			this.CreatedByUserID = createdByUserID;

			_Mode = enMode.Update;
		}


		private bool _AddNew()
		{
			this.LicenseID = LicenseData.AddLicense(this.ApplicationID,this.DriverID,this.LicenseClass,this.IssueDate,this.ExpirationDate
				,this.Notes,this.PaidFees,this.IsActive,this.IssueReason,this.CreatedByUserID);

			return (this.LicenseID != -1);
		}
		private bool _Update()
		{
			return LicenseData.UpdateLicense(this.LicenseID,this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
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

		public static bool IsLicenseExists(int LicenseID)
		{
			return LicenseData.isLicenseExists(LicenseID);
		}
		static public clsLicenses Find(int LicenseID)
		{

			if (!IsLicenseExists(LicenseID))
			{
				return null;
			}
			
			int ApplicationID = -1, DriverID = -1, LicenseClass = -1, createdByUserID = -1;
			DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
			string Notes = "";
			float PaidFees = 0;
			bool IsActive = false;
			byte IssueReason = 0;

			if (LicenseData.GetLicenseByID(LicenseID,ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
				ref IsActive, ref IssueReason, ref createdByUserID) == true)
			{
				return new clsLicenses(LicenseID,ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,createdByUserID);
			}

			else
			{
				return null;
			}


		}

		static public int GetLicenseIDByApplicationID(int ApplicationID)
		{
			return LicenseData.GetLicenseIDByApplicationID(ApplicationID);
		}

		static public DataTable GetLocalLicenseListByDriverID(int DriverID) {
			return LicenseData.GetLocalLicenseListByDriverID(DriverID);
		}

		public string IssueReasonName()
		{
			switch ((enIssueReason)this.IssueReason)
			{
				case (enIssueReason.FirstTime):
					return "First Time";
				case (enIssueReason.Renew):
					return "Renew";
				case (enIssueReason.ReplacmentForDamaged):
					return "Replacement For Damaged";
				case (enIssueReason.ReplacmentForLost):
					return "Replacement For Lost";
				default: break;
			}
			return null;
		}

	}
}
