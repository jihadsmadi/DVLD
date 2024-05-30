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
	public partial class frmNewInternationalLicenseApplication : Form
	{
		public frmNewInternationalLicenseApplication()
		{
			InitializeComponent();
			_FillApplicationInfo();
			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += Form2_DataBack;
		}
		public int LocalLicenesID { get; set; }
		public clsApplications InternaitonLicenseApplciation{ get; set; }
		public clsApplicationTypes InternationalAppType { get; set; }

		public clsInternationalLicense  InternationlLicense { get; set; }


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

		private void _FillApplicationInfo()
		{
			this.InternationalAppType = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.NewInternationalLicense);
			
			lbApplicationDate.Text = DateTime.Now.ToShortDateString();
			lbIssueDate.Text = DateTime.Now.ToShortDateString();
			lbFees.Text = this.InternationalAppType.ApplicationFees.ToString()+"$";
			lbExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
			lbCreatedBy.Text = clsAppSettings.ProgramUser.UserName;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (clsLicenses.Find(this.uctlInternationalLicenseApplicationWithFilter1.License.LicenseID).LicenseClass != 3)
			{
				MessageBox.Show("You Only Can Make International License For Licnes Class 3 - Ordinary driving license  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (clsInternationalLicense.DoseDriverHasInternationLicense(this.uctlInternationalLicenseApplicationWithFilter1.DriverID))
			{
				MessageBox.Show("Driver Has Another Internationl License You Can't Issue Another One ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				this.InternaitonLicenseApplciation = new clsApplications(clsDrivers.Find(this.uctlInternationalLicenseApplicationWithFilter1.DriverID).PersonID, DateTime.Now,
					this.InternationalAppType.ApplicatoinTypeID,(int) clsApplications.enApplicationStatus.New, DateTime.Now, this.InternationalAppType.ApplicationFees, clsAppSettings.ProgramUser.UserID);

				if(this.InternaitonLicenseApplciation.Save())
				{
					 InternationlLicense = new clsInternationalLicense(this.InternaitonLicenseApplciation.ApplicationID, this.uctlInternationalLicenseApplicationWithFilter1.DriverID, this.uctlInternationalLicenseApplicationWithFilter1.License.LicenseID, DateTime.Now, DateTime.Now, true, clsAppSettings.ProgramUser.UserID);
					if(InternationlLicense.Save())
					{
						this.InternaitonLicenseApplciation.ApplicationStatus = (int)clsApplications.enApplicationStatus.Completed;
						if (this.InternaitonLicenseApplciation.Save())
						{
							MessageBox.Show($"Data Saved Succussfully You International Licese ID Is [{InternationlLicense.InternationalLicenseID}] ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
							lbShowLicenseInfo.Enabled = true;
							btnSave.Enabled = false;

							return;
						}
						else
						{
							MessageBox.Show("Data Saved Faild...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
					else
					{
						MessageBox.Show("Data Saved Faild...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					MessageBox.Show("Data Saved Faild...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void lbShowLicenseHistory_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory(this.uctlInternationalLicenseApplicationWithFilter1.DriverID);
			frm.ShowDialog();
		}

		private void lbShowLicenseInfo_Click(object sender, EventArgs e)
		{
			frmInternationalDriverInfo frm = new frmInternationalDriverInfo(this.InternationlLicense.InternationalLicenseID);
			frm.ShowDialog();
		}

		private void Form2_DataBack(object sender, int LicensID)
		{
			this.LocalLicenesID= LicensID;
			lbLocalLicenseID.Text = LicensID.ToString();
			lbShowLicenseHistory.Enabled= true;
		}
	}
}
