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
	public class clsTests
	{
		public int TestID { get; set; }
		public int TestAppointmentID { get; set; }
		public bool TestResult { get; set; }
		public string Notes { get; set; }
		public int CreatedByUserID { get; set; }

		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }


		public clsTests(int TestAppointmentID, bool TestResult, string Notes, int createdByUserID)
		{
			TestID = -1;
			this.TestAppointmentID = TestAppointmentID;
			this.TestResult = TestResult;
			this.Notes = Notes;	
			this.CreatedByUserID = createdByUserID;
			

			_Mode = enMode.AddNew;
		}

		private clsTests(int TestID,int TestAppointmentID, bool TestResult, string Notes, int createdByUserID)
		{
			this.TestID = TestID;
			this.TestAppointmentID = TestAppointmentID;
			this.TestResult = TestResult;
			this.Notes = Notes;
			this.CreatedByUserID = createdByUserID;

			_Mode = enMode.Update;
		}

		private bool _AddNew()
		{
			this.TestID = TestsData.AddTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

			return (this.TestID != -1);
		}
		private bool _Update()
		{
			return TestsData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
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
	
		public static bool IsTestExists(int TestID)
		{
			return TestsData.isTestExists(TestID);
		}
		static public clsTests Find(int TestID)
		{

			if (!IsTestExists(TestID))
			{
				return null;
			}

			int TestAppointmen = -1, CreatedByUserID = -1;
			bool Result = false;
			string notes = "";

			if (TestsData.GetTestByID(TestID,ref TestAppointmen, ref Result, ref notes, ref CreatedByUserID) == true)
			{
				return new clsTests(TestID, TestAppointmen,Result,notes,CreatedByUserID);
			}

			else
			{
				return null;
			}


		}
		static public sbyte PassedTestCountByLDLApplicationID(int LDLApplicationID)
		{
			return TestsData.GetPassedTestCount(LDLApplicationID);
		}
		static public bool IsPassedTest(int LDLID,int TestTypeID)
		{
			return TestsData.IsPassedTest(LDLID, TestTypeID);
		}
		static public bool IsRetakeTest(int LDLID, int TestTypeID)
		{
			return TestsData.IsRetakeTest(LDLID, TestTypeID);
		}

	}
}
