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
	public partial class frmReplacementLicnese : Form
	{
		public frmReplacementLicnese()
		{
			InitializeComponent();
			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += Form2_Databack;
			this.ReplacementForDamaged = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.ReplacementForADamagedDrivingLicense);
			this.ReplacementForLost = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.ReplacementForALostDrivingLicense);

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
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private clsApplications Application { get; set; }
		private clsLicenses OldLicense { get; set; }
		private clsLicenses NewLicenses { get; set; }

		private clsApplicationTypes ReplacementForDamaged;
		private clsApplicationTypes ReplacementForLost;




		private void _FillApplicationNewLicenseInfo()
		{
			lbShowLicenseHistory.Enabled = true;
			lbApplicationDate.Text = DateTime.Now.ToShortDateString();
			lbApplicationFees.Text = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.RenewDrivingLicenseService).ApplicationFees.ToString();
			lbOldLicenseID.Text = this.OldLicense.LicenseID.ToString();
			lbCreatedBy.Text = clsAppSettings.ProgramUser.UserName;
			lbApplicationFees.Text = this.ReplacementForDamaged.ApplicationFees.ToString();
		}

		private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
		{
			if(rbDamagedLicense.Checked)
			{
				lbHeader.Text = "Replacement for Damaged Licnese";
				lbApplicationFees.Text = this.ReplacementForDamaged.ApplicationFees.ToString();
			}
			else
			{
				lbHeader.Text = "Replacement for Lost Licnese";
				lbApplicationFees.Text = this.ReplacementForLost.ApplicationFees.ToString();

			}
		}

		private void btnIssueReplacemetn_Click(object sender, EventArgs e)
		{
			this.Application = new clsApplications(clsDrivers.PersonIDByDriverID(this.OldLicense.DriverID), DateTime.Now,
				(rbDamagedLicense.Checked) ? (int)clsApplicationTypes.enApplicationTypes.ReplacementForADamagedDrivingLicense : (int)clsApplicationTypes.enApplicationTypes.ReplacementForALostDrivingLicense,
				(int)clsApplications.enApplicationStatus.New, DateTime.Now, Convert.ToInt32(lbApplicationFees.Text), clsAppSettings.ProgramUser.UserID);

			if(this.Application.Save())
			{
				this.NewLicenses = new clsLicenses(this.OldLicense.ApplicationID, this.OldLicense.DriverID, this.OldLicense.LicenseClass, DateTime.Now,
					DateTime.Today.AddYears(clsLicenseClass.ValidityLengthByClassID(this.OldLicense.LicenseClass)), this.OldLicense.Notes, this.OldLicense.PaidFees, true,
					(this.Application.ApplicationTypeID == (int)clsApplicationTypes.enApplicationTypes.ReplacementForADamagedDrivingLicense) ? (byte)clsLicenses.enIssueReason.ReplacmentForDamaged : (byte)clsLicenses.enIssueReason.ReplacmentForLost, clsAppSettings.ProgramUser.UserID);
					
				if(this.NewLicenses.Save())
				{
					this.OldLicense.IsActive = false;

					if(this.OldLicense.Save())
					{
						this.Application.ApplicationStatus = (int)clsApplications.enApplicationStatus.Completed;
						if(this.Application.Save())
						{
							lbShowLicenseInfo.Enabled = true;
							MessageBox.Show($"New License Replacemetn Successfully\n New License With ID [{this.NewLicenses.LicenseID}]  ..", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
							
							return;
						}
					}
				}


			}

			MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;


		}

		private void lbShowLicenseHistory_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory(this.OldLicense.DriverID);
			frm.ShowDialog();
		}

		private void lbShowLicenseInfo_Click(object sender, EventArgs e)
		{
			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(this.NewLicenses.LicenseID);
			frm.ShowDialog();
		}

		void Form2_Databack(object sender, int LicensID)
		{
			this.OldLicense = clsLicenses.Find(LicensID);

			if (this.OldLicense.IsActive== false)
			{ 
				btnIssueReplacemetn.Enabled = false;
				return;
			}

			btnIssueReplacemetn.Enabled = true;
			lbShowLicenseHistory.Enabled = true;
			_FillApplicationNewLicenseInfo();

		}





	}
}
