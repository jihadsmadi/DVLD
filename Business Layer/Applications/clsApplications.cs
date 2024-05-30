using Data_Access_Layer;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
	public class clsApplications
	{
		public int ApplicationID { get; set; }
		public int ApplicationPersonID { get; set; }
		public DateTime ApplicationDate { get; set; }
		public int ApplicationTypeID { get; set; }
		public byte ApplicationStatus { get; set; }
		public DateTime LastStatusDate { get; set; }
		public float PaidFees { get; set; }
		public int CreatedByUserID { get; set; }

		public enum enApplicationStatus
		{
			New = 1, Cancelled = 2, Completed= 3
		}
		enum _enMode { AddNew = 1,Update =2};
		private _enMode Mode;

		public clsApplications(int ApplicationPersonID,DateTime ApplicationDate,
			int ApplicationTypeID,byte ApplicationStatus,DateTime LastStatusDate,float PaidFees,int CreatedByUserID)
		{
			this.ApplicationPersonID = ApplicationPersonID;
			this.ApplicationDate = ApplicationDate;
			this.ApplicationTypeID = ApplicationTypeID;
			this.ApplicationStatus = ApplicationStatus;
			this.LastStatusDate = LastStatusDate;
			this.PaidFees= PaidFees;
			this.CreatedByUserID= CreatedByUserID;

			this.Mode = _enMode.AddNew;
		}

		private clsApplications(int ApplicationID,int ApplicationPersonID, DateTime ApplicationDate,
			int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
		{
			this.ApplicationID = ApplicationID;
			this.ApplicationPersonID = ApplicationPersonID;
			this.ApplicationDate = ApplicationDate;
			this.ApplicationTypeID = ApplicationTypeID;
			this.ApplicationStatus = ApplicationStatus;
			this.LastStatusDate = LastStatusDate;
			this.PaidFees = PaidFees;
			this.CreatedByUserID = CreatedByUserID;

			this.Mode = _enMode.Update;
		}


		public static bool DeleteApplication(int ApplicationID)
		{
			return ApplicationData.DeleteApplication(ApplicationID);
		}
		private bool _AddNew()
		{
			this.ApplicationID = ApplicationData.AddApplication(this.ApplicationPersonID, this.ApplicationDate,this.ApplicationTypeID,
				this.ApplicationStatus, LastStatusDate,this.PaidFees,this.CreatedByUserID);

			return (this.ApplicationID != -1);
		}
		private bool _Update()
		{
			return ApplicationData.UpdateApplication(this.ApplicationID,this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
				this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
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
		public static bool IsApplicationExists(int ApplicationID)
		{
			return ApplicationData.isApplicationExists(ApplicationID);
		}
		static public clsApplications Find(int ApplicationID)
		{

			if (!IsApplicationExists(ApplicationID))
			{
				return null;
			}

			int ApplicationPersonID=-1, ApplicationTypeID=-1, CreatedByUserID = -1;
			DateTime applicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
			float PaidFees =0;
			byte ApplicationStatus=1;

			if (ApplicationData.GetApplicationByID(ApplicationID,ref ApplicationPersonID,ref applicationDate,ref ApplicationTypeID,
				ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID) == true)
			{
				return new clsApplications(ApplicationID,ApplicationPersonID, applicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
			}
			else
			{
				return null;
			}


		}
		
		static public int GetRetakeApplicationID(int ApplicationPersonID)
		{
			return ApplicationData.GetRetakeApplicationID(ApplicationPersonID);
		}

		static public bool IsPersonHaveCurrentNewLocalLicenseApplication(int PersonID,int ClassLicenseID)
		{
			return ApplicationData.IsPersonHaveCurrentNewLocalLicenseApplication(PersonID, ClassLicenseID);
		}




	}
}
