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
	public partial class frmLicenseHistory : Form
	{
		public frmLicenseHistory(int DriverID)
		{
			InitializeComponent();

			_FillTheForm(DriverID);

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

		private void _FillTheForm(int DriverID)
		{
			clsDrivers driver = clsDrivers.Find(DriverID);
			uctlPersonInfo1.LoadPersonInfo(driver.PersonID);

			gvLocalLicense.DataSource = clsLicenses.GetLocalLicenseListByDriverID(DriverID);
			lbLocalRecordCount.Text = "# Records: " + gvLocalLicense.Rows.Count.ToString();

			gvInternationallicenses.DataSource = clsInternationalLicense.GetInternationalLicenseListByDriverID(DriverID);
			lbInternationRecordCount.Text = "# Records: " + gvInternationallicenses.Rows.Count.ToString();
		}

		private void tsmShowPersonInfoInDetainedLicenses_Click(object sender, EventArgs e)
		{

			int ApplicationID = Convert.ToInt32(gvLocalLicense.SelectedRows[0].Cells[1].Value);
			int PersonID = clsApplications.Find(ApplicationID).ApplicationPersonID;

			frmPersonDetails frm = new frmPersonDetails(PersonID);
			frm.ShowDialog();
		}

		private void tsmShowLicenseDetailsInDetainedLicense_Click(object sender, EventArgs e)
		{
			int LicenseID = Convert.ToInt32(gvLocalLicense.SelectedRows[0].Cells[0].Value);

			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseID);
			frm.ShowDialog();
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
