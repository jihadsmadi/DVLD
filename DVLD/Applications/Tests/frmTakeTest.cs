using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLI
{
	public partial class frmTakeTest : Form
	{

		public frmTakeTest(int TestAppointmentID,bool DoseRetake,int PersonID)
		{
			InitializeComponent();
			TestAppointment = clsTestAppointment.Find(TestAppointmentID);
			LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.Find(TestAppointment.LocalDrivingLicenseApplicationID);

			if(DoseRetake)
			{
				this.Mode = frmScheduleTest._Mode.RetakeTest;
				this.PersonID = PersonID; 
			}else
			{
				this.Mode = frmScheduleTest._Mode.TakeAppointment;
			}

			_FillTheForm();
		}
		public clsTestAppointment TestAppointment { get; set; }
		public frmScheduleTest._Mode Mode { get; set; }
		public clsLocalDrivingLicenseApplications LocalDrivingLicenseApplications { get; set; }

		private int PersonID = -1;
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
		private void _FillThePictureAndTheLabel()
		{
			if (TestAppointment.TestTypeID == (int)clsTestTypes.enTestTypes.VisionTest)
			{
				gbTestDetails.Text = "Vision Test";
				pbTestPicture.Image = Properties.Resources.hand_drawn_eye_vector_1024x771;
			}
			else if (TestAppointment.TestTypeID == (int)clsTestTypes.enTestTypes.WrittenTest)
			{
				gbTestDetails.Text = "Witten Test";
				pbTestPicture.Image = Properties.Resources.download_writing_free_transparent_image_hq_hq_png_image;
			}
			else if (TestAppointment.TestTypeID == (int)clsTestTypes.enTestTypes.PracticalStreetTest)
			{
				gbTestDetails.Text = "Street Test";
				pbTestPicture.Image = Properties.Resources.red_car_vehicle_at_street_design_free_vector;
			}
		}
		private void _FillTheForm()
		{
			lbDLAppID.Text = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
			lbDClass.Text = LocalDrivingLicenseApplications.ClassName();
			lbApplicant.Text = clsPeople.Find(clsApplications.Find(LocalDrivingLicenseApplications.ApplicationID).ApplicationPersonID).GetFullName();
			lbTrail.Text = clsTestAppointment.TrailCount(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, TestAppointment.TestTypeID).ToString();
			lbFees.Text =clsTestTypes.Find(TestAppointment.TestTypeID).TestTypeFees.ToString();
			lbDate.Text = TestAppointment.AppointmentDate.ToString(); 

			_FillThePictureAndTheLabel();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if(rbPass.Checked == false && rbFail.Checked == false)
			{
				MessageBox.Show("You Should Check The Result ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsTests test = new clsTests(TestAppointment.TestAppointmentID,(rbPass.Checked ? true : false),tbNotes.Text,clsAppSettings.ProgramUser.UserID);

			if(test.Save())
			{
				
				if(this.Mode == frmScheduleTest._Mode.RetakeTest)
				{
					clsApplications app = clsApplications.Find( clsApplications.GetRetakeApplicationID(this.PersonID));
					app.ApplicationStatus =  (int)clsApplications.enApplicationStatus.Completed;
					if(!app.Save())
					{
						MessageBox.Show("Retake Applicaiton Status Dose Not Changed\nData Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}

				TestAppointment.IsLocked = true;
				if(TestAppointment.Save())
				{
					lbTestID.Text = test.TestID.ToString();
					MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					TestAppointment.IsLocked = false;
					MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				
			}
			else
			{
				MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			btnSave.Enabled = false;

		}
	}
}
