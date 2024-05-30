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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLI
{
	public partial class frmReleaseDetainLicense : Form
	{
		public frmReleaseDetainLicense()
		{
			InitializeComponent();
			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += ReturnLicenseID;
			this.ReleaseAppType = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.ReleaseDetainedDrivingLicsense);
		}

		public frmReleaseDetainLicense(int LicenseID)
		{
			InitializeComponent();
			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += ReturnLicenseID;
			this.ReleaseAppType = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.ReleaseDetainedDrivingLicsense);
			this.uctlInternationalLicenseApplicationWithFilter1.searchByID(LicenseID);
		}

		public clsLicenses License { get; set; }
		public clsApplications Application { get; set; }

		public clsApplicationTypes ReleaseAppType { get; set; }
		public clsDetainedLicenses Detain { get; set; }
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


		private void ReturnLicenseID(object sender, int LicenseID)
		{
			this.License = clsLicenses.Find(LicenseID);
			lbLicenseID.Text = this.License.LicenseID.ToString();

			if (this.License != null)
			{
				lbShowLicenseInfo.Enabled = true;
				lbShowLicenseHistory.Enabled = true;
				if (!clsDetainedLicenses.isLicenesDetained(this.License.LicenseID))
				{
					MessageBox.Show("Selected License is not detained, choose another one ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					btnRelease.Enabled = false;
					return;
				}
				else
				{
					btnRelease.Enabled = true;
					this.Detain = clsDetainedLicenses.FindByLicenseID(this.License.LicenseID);
					FillDetainInfo();
				}


			}




		}

		private void lbShowLicenseHistory_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory(this.License.DriverID);
			frm.ShowDialog();
		}
		private void lbShowLicenseInfo_Click(object sender, EventArgs e)
		{
			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(this.License.LicenseID);
			frm.ShowDialog();

		}

		private void btnRelease_Click(object sender, EventArgs e)
		{ 

			if (this.License != null)
			{
				if (MessageBox.Show($"Are You Sure You Want To release this detained License With [{this.License.LicenseID}] ...?",
					"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Application = new clsApplications(clsDrivers.PersonIDByDriverID(this.License.DriverID), DateTime.Now, this.ReleaseAppType.ApplicatoinTypeID, (int)clsApplications.enApplicationStatus.New, DateTime.Now, this.ReleaseAppType.ApplicationFees, clsAppSettings.ProgramUser.UserID);

					if(this.Application.Save())
					{
						lbApplicationID.Text = this.Application.ApplicationID.ToString();
						this.Detain.IsReleased = true;
						this.Detain.ReleaseDate = DateTime.Now;
						this.Detain.ReleaseApplicationID = this.Application.ApplicationID;
						this.Detain.ReleasedByUserID = clsAppSettings.ProgramUser.UserID;


						if (this.Detain.Save())
						{
							this.License.IsActive = true;
							if (this.License.Save())
							{
								this.Application.ApplicationStatus = (int)clsApplications.enApplicationStatus.Completed;
								if(this.Application.Save())
								{
									MessageBox.Show("Detained License Released Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
									btnRelease.Enabled = false;
									return;
								}
								
							}
						}

						MessageBox.Show("Data Saved Failed  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

					}



				}
			}
		}

		

		private void FillDetainInfo()
		{
			lbDetainID.Text = this.Detain.DetainID.ToString() ;
			lbApplicationFees.Text =this.ReleaseAppType.ApplicationFees.ToString();
			lbDetainDate.Text = this.Detain.DetainDate.ToShortDateString();
			lbCreatedBy.Text = clsAppSettings.ProgramUser.UserName;
			btnRelease.Enabled = true;
			lbShowLicenseHistory.Enabled = true;
			lbShowLicenseInfo.Enabled = true;
			lbFineFees.Text = this.Detain.FineFees.ToString();
			lbTotalFees.Text = (this.ReleaseAppType.ApplicationFees + this.Detain.FineFees).ToString() ;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
