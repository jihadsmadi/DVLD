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
	public partial class frmDetainLicense : Form
	{
		public frmDetainLicense()
		{
			InitializeComponent();

			this.uctlInternationalLicenseApplicationWithFilter1.DataBack += ReturnLicenseID;
		}

		public clsLicenses Licens{ get; set; }
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
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{

			if (isClick)
			{


				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}


		}


		private void ReturnLicenseID(object sender,int LicenseID)
		{
			this.Licens = clsLicenses.Find(LicenseID);
			lbLicenseID.Text = this.Licens.LicenseID.ToString();

			if(this.Licens != null)
			{
				if (this.Licens.IsActive == false)
				{
					MessageBox.Show("Your License Is Not Active You Can't Move On ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					btnDetain.Enabled = false;
					return;
				}

				FillDetainInfo();
				if (this.uctlInternationalLicenseApplicationWithFilter1.IsDeatin)
				{
					MessageBox.Show("License Is Alrady Detained ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					btnDetain.Enabled = false;
					return;
				}
				else
				{
					btnDetain.Enabled = true;
				}

				
			}




		}

		private void lbShowLicenseHistory_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory(this.Licens.DriverID);
			frm.ShowDialog();
		}

		private void btnDetain_Click(object sender, EventArgs e)
		{
			if(tbFineFees.Value < 0)
			{
				MessageBox.Show("You Should To Set Fine  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			if(this.Licens != null)
			{
				if(MessageBox.Show($"Are You Sure You Want To Detain License With [{this.Licens.LicenseID}] ...?",
					"Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				{
					clsDetainedLicenses detain = new clsDetainedLicenses(this.Licens.LicenseID, DateTime.Now, Convert.ToSingle(tbFineFees.Value)
						, clsAppSettings.ProgramUser.UserID, false, null, null, null);

					if(detain.Save())
					{
						this.Licens.IsActive = false;
						if(this.Licens.Save())
						{
							MessageBox.Show("License Detained Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
							lbRLApplicationID.Text = detain.DetainID.ToString();
							btnDetain.Enabled = false;
							
							return;
						}
					}

					MessageBox.Show("Data Saved Failed  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			

				}
			}
		}

		private void lbShowLicenseInfo_Click(object sender, EventArgs e)
		{
			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(this.Licens.LicenseID);
			frm.ShowDialog();
			
		}

		private void FillDetainInfo()
		{
			lbApplicationDate.Text = DateTime.Now.ToShortDateString();
			lbCreatedBy.Text = clsAppSettings.ProgramUser.UserName;
			btnDetain.Enabled = true;
			lbShowLicenseHistory.Enabled = true;
			lbShowLicenseInfo.Enabled = true;
		}




	}
}
