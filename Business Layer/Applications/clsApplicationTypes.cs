using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsApplicationTypes
	{
		public int ApplicatoinTypeID { get; set; }

		public string ApplicationTypeTitle { get; set; }

		public float ApplicationFees { get; set; }

		public enum enApplicationTypes { NewLocalDrivingLicenseService =1,RenewDrivingLicenseService = 2,ReplacementForALostDrivingLicense = 3,
			ReplacementForADamagedDrivingLicense=4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6,RetakeTest = 7}

		private clsApplicationTypes(int applicatoinTypeID, string applicationTypeTitle, float applicationFees)
		{
			ApplicatoinTypeID = applicatoinTypeID;
			ApplicationTypeTitle = applicationTypeTitle;
			ApplicationFees = applicationFees;
		}

		public bool Save()
		{
			return ApplicationTypesData.UpdateApplicationType(this.ApplicatoinTypeID,this.ApplicationTypeTitle,this.ApplicationFees);
		}
		public static DataTable ApplicationTypesList()
		{
			return ApplicationTypesData.GetApplicationTypesList();
		}
		public static bool IsAppliactionTypeExists(int ApplicationTypeID)
		{
			return ApplicationTypesData.isApplicationTypeExists(ApplicationTypeID);
		}
		static public clsApplicationTypes Find(int ApplicationTypeID)
		{

			if (!IsAppliactionTypeExists(ApplicationTypeID))
			{
				return null;
			}

			string ApplicationTypeTitle = "";
			float ApplicationTypeFees = 0;

		


			if (ApplicationTypesData.GetApplicationTypeByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationTypeFees) == true)
			{
				return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
			}

			else
			{
				return null;
			}


		}

	}
}
