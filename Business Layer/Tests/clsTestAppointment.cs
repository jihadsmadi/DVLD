using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsTestAppointment
	{
		
		public int TestAppointmentID { get; set; }
		public int TestTypeID { get; set; }
		public int LocalDrivingLicenseApplicationID { get; set; }
		public DateTime AppointmentDate { get; set; }
		public float PaidFees { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsLocked { get; set; }
		enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode { get; set; }


		public clsTestAppointment( int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, float paidFees, int createdByUserID, bool isLocked)
		{
			TestAppointmentID = -1;
			TestTypeID = testTypeID;
			LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
			AppointmentDate = appointmentDate;
			PaidFees = paidFees;
			CreatedByUserID = createdByUserID;
			IsLocked = isLocked;

			_Mode = enMode.AddNew;
		}

		private clsTestAppointment(int TestAppointmentID,int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, float paidFees, int createdByUserID, bool isLocked)
		{
			this.TestAppointmentID = TestAppointmentID;
			TestTypeID = testTypeID;
			LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
			AppointmentDate = appointmentDate;
			PaidFees = paidFees;
			CreatedByUserID = createdByUserID;
			IsLocked = isLocked;

			_Mode = enMode.Update;
		}

		private bool _AddNew()
		{
			this.TestAppointmentID = TestAppointmentsData.AddTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked);

			return (this.TestAppointmentID != -1);
		}
		private bool _Update()
		{
			return TestAppointmentsData.UpdateApplication(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
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
		static public DataTable GetTestAppointmentList(int LDLID,int TestTypeID)
		{
			return TestAppointmentsData.GetTestAppointmentByTestTypeAndLDLID(LDLID,TestTypeID);
		}
		static public bool IsHasActiveAppointment(int LDLID,int TestTypeID)
		{
			return TestAppointmentsData.IsHasActiveTestAppointment(LDLID,TestTypeID);
		}
		public static bool IsTestAppointmentExists(int TestAppointmentID)
		{
			return TestAppointmentsData.isTestAppointmentExists(TestAppointmentID);
		}
		static public clsTestAppointment Find(int TestAppointmentID)
		{

			if (!IsTestAppointmentExists(TestAppointmentID))
			{
				return null;
			}

			int TestTypeID = -1, CreatedByUserID = -1,LocalDrivinLicenseAppID=-1;
			DateTime AppointmentDate = DateTime.Now;
			float PaidFees = 0;
			bool isLocked = false;

			if (TestAppointmentsData.GetTestAppointmentByID(TestAppointmentID,ref TestTypeID, ref LocalDrivinLicenseAppID, ref AppointmentDate, ref PaidFees, ref  CreatedByUserID, ref isLocked) == true)
			{
				return new clsTestAppointment(TestAppointmentID,TestTypeID,LocalDrivinLicenseAppID,AppointmentDate ,PaidFees, CreatedByUserID,isLocked);
			}

			else
			{
				return null;
			}


		}
		static public byte TrailCount(int LDLID, int TestTypeID)
		{
			return TestAppointmentsData.GetTestTrairCount(LDLID, TestTypeID);
		}
	}
}
