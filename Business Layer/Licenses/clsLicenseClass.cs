using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Layer
{
	public class clsLicenseClass
	{
		public int LicenseClassID { get; set; }
		public string ClassName { get; set; }
		public string ClassDescription { get; set; }
		public Byte MinimumAllowedAge { get; set; }
		public	Byte DefaultValidityLength { get; set; }
		public float ClassFees { get; set; }

		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }


		private clsLicenseClass(int ClassLicenseID,string ClassName,string ClassDescription,Byte MinimumAllowedAge,Byte DefaultValidityLength,float ClassFees)
		{
			this.LicenseClassID = ClassLicenseID;
			this.ClassName = ClassName;
			this.ClassDescription = ClassDescription;
			this.MinimumAllowedAge = MinimumAllowedAge;
			this.DefaultValidityLength = DefaultValidityLength;
			this.ClassFees = ClassFees;
	

			_Mode = enMode.Update;
		}

		public static bool IsLicenseClassExists(int LicenseClassID)
		{
			return LicenseClassData.isLicenseClassExists(LicenseClassID);
		}
		static public clsLicenseClass Find(int LicenseClassID)
		{

			if (!IsLicenseClassExists(LicenseClassID))
			{
				return null;
			}

			string ClassName = "", ClassDescription = "";
			Byte MinimumAllowedAge = 0,DefaultValidityLength = 0;
			float classFees = 0;

			if (LicenseClassData.GetLicenseClassByID(LicenseClassID,ref ClassName,ref ClassDescription, ref MinimumAllowedAge,ref DefaultValidityLength,ref classFees) == true)
			{
				return new clsLicenseClass(LicenseClassID,ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,classFees);
			}

			else
			{
				return null;
			}


		}

		static public int ValidityLengthByClassID(int LicenseClassID)
		{
			return LicenseClassData.ValidityLengthByClassID(LicenseClassID);
		}
		static public string LicenseClassNameByID(int ClassLicenseID)
		{
			return LicenseClassData.LicenseClassNameByID(ClassLicenseID);
		}
		static public DataTable LicenseClassNameList()
		{
			return LicenseClassData.GetLicenseClassNameList();
		}
	}
}
