using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsLocalDrivingLicenseApplications
	{
		public int LocalDrivingLicenseApplicationID { get; set; }

		public int ApplicationID { get; set; }

		public int LicenseClassID { get; set; }


		public clsLocalDrivingLicenseApplications( int applicationID, int licenseClassID)
		{
			this.LocalDrivingLicenseApplicationID = -1;
			this.ApplicationID = applicationID;
			this.LicenseClassID = licenseClassID;

			Mode = _enMode.AddNew;
		}

		private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int applicationID, int licenseClassID)
		{
			this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
			this.ApplicationID = applicationID;
			this.LicenseClassID = licenseClassID;

			Mode = _enMode.Update;
		}

		enum _enMode { AddNew = 1, Update = 2 };
		private _enMode Mode;

		
		public static bool DeleteLocalDrivingLicense(int LDLicenseID)
		{
			return LocalDrivingLicenseApplicationData.DeleteApplication(LDLicenseID);
		}
		private bool _AddNew()
		{
			this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationData.AddLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

			return (this.LocalDrivingLicenseApplicationID != -1);
		}
		private bool _Update()
		{
			return LocalDrivingLicenseApplicationData.UpdateApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
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
		public static bool IsLocalDrivingLicenseApplicationExists(int LocalDrivingLicenseApplicationID)
		{
			return LocalDrivingLicenseApplicationData.isLocalDrivingLicenseApplicationExists(LocalDrivingLicenseApplicationID);
		}
		static public clsLocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
		{

			if (!IsLocalDrivingLicenseApplicationExists(LocalDrivingLicenseApplicationID))
			{
				return null;
			}

			int ApplicationID = -1, LicenseClassID = -1;

			if (LocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID,ref ApplicationID,ref LicenseClassID) == true)
			{
				return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
			}

			else
			{
				return null;
			}


		}

		static public bool IsPersonHaveCurrentNewLocalLicenseApplication(int PersonID, int ClassLicenseID)
		{
			return ApplicationData.IsPersonHaveCurrentNewLocalLicenseApplication(PersonID, ClassLicenseID);
		}

		static public DataTable LocalDrivingLicenseApplicationsList()
		{
			return LocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationList();
		}

		public string ClassName()
		{
			return clsLicenseClass.LicenseClassNameByID(this.LicenseClassID);
		}

		public sbyte PassedTestCount()
		{
			return clsTests.PassedTestCountByLDLApplicationID(this.LocalDrivingLicenseApplicationID);
		}
	}
}
