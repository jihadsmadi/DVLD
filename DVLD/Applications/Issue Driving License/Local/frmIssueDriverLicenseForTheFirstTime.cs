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
	public partial class frmIssueDriverLicenseForTheFirstTime : Form
	{
		public frmIssueDriverLicenseForTheFirstTime(int LocalDrivingLicenseClassID)
		{
			InitializeComponent();
			uctlDLDApplicationCompleteInformation1.FillTheForm(LocalDrivingLicenseClassID);
			this.LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseClassID);
			this.LicenseClass = clsLicenseClass.Find(LocalDrivingLicenseApplication.LicenseClassID);
			
		}
		public clsLocalDrivingLicenseApplications LocalDrivingLicenseApplication{ get; set; }
		public clsLicenseClass LicenseClass { get; set; }

		public clsApplications Application { get; set; }

		public delegate void DataBackEventHandler(Object sender, int PersonID);
		public DataBackEventHandler DataBack;
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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void tbNotes_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Application = clsApplications.Find(this.LocalDrivingLicenseApplication.ApplicationID);
			int DriverID = -1;
			if (!clsDrivers.IsDriverExistsByPersonID(this.Application.ApplicationPersonID))
			{
				clsDrivers driver = new clsDrivers(clsApplications.Find(this.LocalDrivingLicenseApplication.ApplicationID).ApplicationPersonID, DateTime.Now, clsAppSettings.ProgramUser.UserID);
				if (!driver.Save())
				{
					MessageBox.Show("Some Thing Wrong At Adding Driver ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
				}
				else
				{
					DriverID = driver.DriverID;

				}
			}
			else
			{
				DriverID = clsDrivers.GetDriverIDByPersonID(this.Application.ApplicationPersonID);
			}


			DateTime ExpritionDate = DateTime.Now.AddYears(clsLicenseClass.ValidityLengthByClassID(this.LocalDrivingLicenseApplication.LicenseClassID));

			clsLicenses License = new clsLicenses(this.LocalDrivingLicenseApplication.ApplicationID, DriverID, this.LocalDrivingLicenseApplication.LicenseClassID, DateTime.Now, ExpritionDate,
						tbNotes.Text, this.LicenseClass.ClassFees, true,(int)clsLicenses.enIssueReason.FirstTime, clsAppSettings.ProgramUser.UserID);

			if (License.Save())
			{
				
				this.Application.ApplicationStatus = (int)clsApplications.enApplicationStatus.Completed;

				if (this.Application.Save())
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

			btnSave.Enabled = false;

		}
	}
}
