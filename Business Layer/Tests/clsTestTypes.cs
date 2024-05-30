using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsTestTypes
	{
		public int TestTypeID { get; set; }
		public string TestTypeTitle { get; set; }
		public string TestTypeDescription { get; set;}
		public float TestTypeFees { get; set; }

		public enum enTestTypes { VisionTest = 1,WrittenTest = 2,PracticalStreetTest = 3};
		private clsTestTypes(int TestTypeID,string TestTypeTitle,string TestTypeDescription,float TestTypeFees)
		{
			this.TestTypeID = TestTypeID;
			this.TestTypeTitle = TestTypeTitle;
			this.TestTypeDescription = TestTypeDescription;
			this.TestTypeFees = TestTypeFees;
		}

		public bool Save()
		{
			return TestTypesData.UpdateTestType(this.TestTypeID, this.TestTypeTitle,this.TestTypeDescription, this.TestTypeFees);
		}
		public static DataTable TestTypesList()
		{
			return TestTypesData.GetTestTypesList();
		}

		public static bool IsTestTypeExists(int TestTypeID)
		{
			return TestTypesData.isTestTypeExists(TestTypeID);
		}
		static public clsTestTypes Find(int TestTypeID)
		{

			if (!IsTestTypeExists(TestTypeID))
			{
				return null;
			}

			string TestTypeTitle = "",TestTypeDescription ="";
			float TestTypeFees = 0;




			if (TestTypesData.GetTestTypeByID(TestTypeID,ref TestTypeTitle,ref TestTypeDescription,ref TestTypeFees) == true)
			{
				return new clsTestTypes(TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees);
			}

			else
			{
				return null;
			}


		}



	}
}
