using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLI
{
	public partial class frmScheduleTest : Form
	{
		public enum _Mode { TakeAppointment = 1,RetakeTest = 2,Update =3};
		public _Mode enMode { get; set; }
		 
		public frmScheduleTest(int DLAID,int TestTypeID)
		{
			InitializeComponent();

			_FillFormObjects(DLAID, TestTypeID);
			_FillTheForm();

			if (clsTests.IsRetakeTest(DLAID, TestTypeID))
			{
				enMode = _Mode.RetakeTest;
				lbHeader.Text = "Retake Test Appointment ";
				gbRetakeTest.Visible = true;
				lbRAppFees.Text = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.RetakeTest).ApplicationFees.ToString();
				lbTotalFees.Text = (Convert.ToInt32(lbFees.Text) + Convert.ToInt32(lbRAppFees.Text)).ToString();
			}
			else
			{
				enMode = _Mode.TakeAppointment;
				lbHeader.Text = "Schedule Test Appointment ";
			}
			

			
			
			
		}
		public frmScheduleTest(int TestAppointmentID)
		{
			InitializeComponent();
			enMode = _Mode.Update;

		
			lbHeader.Text = "Update Test Appointment ";
			_FillFormObjects(TestAppointmentID);
			_FillTheForm();
			dtDateOfTest.MinDate = this.TestAppointment.AppointmentDate;
			dtDateOfTest.Value = this.TestAppointment.AppointmentDate;
			if(this.TestAppointment.IsLocked)
			{
				lbAlreadyHaveATestMessage.Visible = true;
				btnSave.Enabled = false;
				dtDateOfTest.Enabled = false;
			}
		}		
		public clsLocalDrivingLicenseApplications LocalDrivingLicenseApplication { get; set; }
		public clsPeople Person { get; set; }
		public clsTestTypes TestType { get; set; }
		public clsTestAppointment TestAppointment { get; set; }

		//Making The Form Move
		private bool isClick = false;
		int x, y;

		private void plTopBar_MouseDown(object sender, MouseEventArgs e)
		{
			isClick = true;
			x = e.X;
			y = e.Y;
		}
		private void plTopBar_MouseUp(object sender, MouseEventArgs e)
		{
			isClick = false;
		}
		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{

			if (isClick)
			{


				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}


		}
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}
		private void _FillFormObjects(int LDLID,int TestTypeID)
		{
			LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LDLID);
			Person = clsPeople.Find(clsApplications.Find(LocalDrivingLicenseApplication.ApplicationID).ApplicationPersonID);
			TestType = clsTestTypes.Find(TestTypeID);
		}
		private void _FillFormObjects(int TestAppointmentID)
		{
			this.TestAppointment = clsTestAppointment.Find(TestAppointmentID);
			LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(TestAppointment.LocalDrivingLicenseApplicationID);
			Person = clsPeople.Find(clsApplications.Find(LocalDrivingLicenseApplication.ApplicationID).ApplicationPersonID);
			TestType = clsTestTypes.Find(TestAppointment.TestTypeID);
		}
		private void _FillTheForm()
		{
			lbDLAppID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
			lbDClass.Text = LocalDrivingLicenseApplication.ClassName();
			lbApplicant.Text = Person.GetFullName();
			lbTrail.Text = clsTestAppointment.TrailCount(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType.TestTypeID).ToString();
			lbFees.Text = TestType.TestTypeFees.ToString();
			dtDateOfTest.MinDate = DateTime.Now;
			_FillThePictureAndTheLabel();
		}
		private void _FillThePictureAndTheLabel()
		{
			if (TestType.TestTypeID == (int)clsTestTypes.enTestTypes.VisionTest)
			{
				gbTestDetails.Text = "Vision TakeAppointment";
				pbTestPicture.Image = Properties.Resources.hand_drawn_eye_vector_1024x771;
			}
			else if (TestType.TestTypeID == (int)clsTestTypes.enTestTypes.WrittenTest)
			{
				gbTestDetails.Text = "Witten TakeAppointment";
				pbTestPicture.Image = Properties.Resources.download_writing_free_transparent_image_hq_hq_png_image;
			}
			else if (TestType.TestTypeID == (int)clsTestTypes.enTestTypes.PracticalStreetTest)
			{
				gbTestDetails.Text = "Street TakeAppointment";
				pbTestPicture.Image = Properties.Resources.red_car_vehicle_at_street_design_free_vector;
			}
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			switch (this.enMode)
			{
				case _Mode.TakeAppointment:
					 this.TestAppointment = new clsTestAppointment(TestType.TestTypeID, LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID,
						dtDateOfTest.Value, TestType.TestTypeFees, clsAppSettings.ProgramUser.UserID, false);

					if (this.TestAppointment.Save())
					{
						MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


					break;
				case _Mode.RetakeTest:
					clsApplications App = new clsApplications(this.Person.PersonID, DateTime.Now, (int)clsApplicationTypes.enApplicationTypes.RetakeTest, (int)clsApplications.enApplicationStatus.New,
						DateTime.Now, Convert.ToInt32(lbTotalFees.Text), clsAppSettings.ProgramUser.UserID);

					clsTestAppointment testAppointment = new  clsTestAppointment(TestType.TestTypeID, LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID,
						dtDateOfTest.Value, TestType.TestTypeFees, clsAppSettings.ProgramUser.UserID, false);

					if(App.Save())
					{
						if (testAppointment.Save())
						{
							MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


					break;

				case _Mode.Update:

					TestAppointment.AppointmentDate = dtDateOfTest.Value;
					if (this.TestAppointment.Save())
					{
						MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			this.Close();
		}

	
	}
}
