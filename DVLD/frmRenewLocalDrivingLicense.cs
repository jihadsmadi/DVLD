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
	public partial class frmRenewLocalDrivingLicense : Form
	{
		public frmRenewLocalDrivingLicense()
		{
			InitializeComponent();

			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += Form2_Databack;

		}
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
		private clsApplications Application { get; set; }
		private clsLicenses OldLicense { get; set; }
		private clsLicenses NewLicenses { get; set; }





		private void _FillApplicationNewLicenseInfo()
		{
			lbShowLicenseHistory.Enabled = true;
			lbApplicationDate.Text = DateTime.Now.ToShortDateString();
			lbIssueDate.Text = DateTime.Now.ToShortDateString();
			lbApplicationFees.Text = clsApplicationTypes.Find( (int)clsApplicationTypes.enApplicationTypes.RenewDrivingLicenseService).ApplicationFees.ToString();
			lbLicenseFees.Text = clsLicenseClass.Find(this.OldLicense.LicenseClass).ClassFees.ToString();
			lbOldLicenseID.Text = this.OldLicense.LicenseID.ToString();
			lbExpirationDate.Text = DateTime.Today.AddYears(10).ToString();
			lbCreatedBy.Text = clsAppSettings.ProgramUser.UserName;
			lbTotalFees.Text = (Convert.ToInt16(lbApplicationFees.Text) + Convert.ToInt16(lbLicenseFees.Text)).ToString();

		}
		void Form2_Databack(object sender, int LicensID)
		{
			this.OldLicense = clsLicenses.Find(LicensID);

			if (this.OldLicense.ExpirationDate > DateTime.Today)
			{
				MessageBox.Show($"Selected License is not yer expiared, it will expire on {this.OldLicense.ExpirationDate.ToShortDateString()}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnRenew.Enabled = false;
				return;
			}

			btnRenew.Enabled = true;
			_FillApplicationNewLicenseInfo();

		}

		private void btnRenew_Click(object sender, EventArgs e)
		{
			this.OldLicense.IsActive = false;

			if(this.OldLicense.Save())
			{
				this.Application = new clsApplications(clsDrivers.PersonIDByDriverID(this.OldLicense.DriverID),DateTime.Now,
					(int)clsApplicationTypes.enApplicationTypes.RenewDrivingLicenseService,(int)clsApplications.enApplicationStatus.New,
					DateTime.Now,Convert.ToInt32(lbApplicationFees.Text),clsAppSettings.ProgramUser.UserID);


				if(this.Application.Save())
				{
					lbRLApplicationID.Text = this.Application.ApplicationID.ToString();
					string notes = string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text;
					this.NewLicenses = new clsLicenses(this.Application.ApplicationID, this.OldLicense.DriverID, this.OldLicense.LicenseClass, DateTime.Now, DateTime.Today.AddYears(10), notes, Convert.ToInt32(lbLicenseFees.Text), true, (int)clsLicenses.enIssueReason.Renew, clsAppSettings.ProgramUser.UserID);
					if(this.NewLicenses.Save())
					{ 
						lbRenewedLicenseID.Text = this.NewLicenses.LicenseID.ToString();
						this.Application.ApplicationStatus = (int)clsApplications.enApplicationStatus.Completed;
						if(this.Application.Save())
						{
							lbShowLicenseInfo.Enabled = true;
							MessageBox.Show($"Renew license done successfully New License Id is [{this.NewLicenses.LicenseID}] ..", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
					}
				}

				MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
		}

		private void lbShowLicenseHistory_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory(this.OldLicense.DriverID);
			frm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
