using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;

namespace DVLI
{
	public partial class frmNewLocalDrivingLicenseApplication : Form
	{
		public frmNewLocalDrivingLicenseApplication(int LocalDrivingLicensID)
		{
			InitializeComponent();

			this.LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicensID);
			_enMode = enMode.Update;
			lbHeader.Text = "Update Local Driving License Application";

			_LoadApplicationForm();
		}
		public frmNewLocalDrivingLicenseApplication()
		{
			InitializeComponent();

			_enMode = enMode.AddNew;

			_LoadApplicationForm();
		}
		public clsLocalDrivingLicenseApplications LocalDrivingLicense { get; set; }
		private enum enMode { AddNew=1,Update = 2};
		private enMode _enMode;
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


		int ApplicationPersonID,ClassLicenseID;
		float PaidFees;

		private void btnApplicationInfo_Click(object sender, EventArgs e)
		{
			if (uctlPersonInfoWithFilter1.PersonID == -1)
			{
				MessageBox.Show("Enter A Valid Person ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ApplicationPersonID = uctlPersonInfoWithFilter1.PersonID;

			plLoginInfo.BringToFront();
			btnApplicationInfo.FillColor = Color.FromArgb(43, 56, 63);
			btnPersonalInfo.FillColor = Color.SlateGray;
			btnNext.Visible = false;
			btnBack.Visible = true;
		}
		private void _LoadApplicationForm()
		{
			_FillLicenseClassComboBox();
			if (this._enMode == enMode.Update)
			{
				clsApplications app = clsApplications.Find(this.LocalDrivingLicense.ApplicationID);
				if (app != null)
				{
					this.uctlPersonInfoWithFilter1.FillTheForm(app.ApplicationPersonID);
					this.uctlPersonInfoWithFilter1.PersonID = app.ApplicationPersonID;
					this.uctlPersonInfoWithFilter1.Enabled = false;
					lbApplicationDate.Text = app.ApplicationDate.ToShortDateString();
					lbCreatedByUser.Text= app.CreatedByUserID.ToString();
					lbApplicationFees.Text = app.PaidFees.ToString();
					lbDLApplicationID.Text = this.LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
					cbLicenseClass.SelectedIndex = this.LocalDrivingLicense.LicenseClassID-1 ;
				}
			}
			else
			{

				lbApplicationDate.Text = DateTime.Now.ToString();
				lbCreatedByUser.Text = clsAppSettings.ProgramUser.UserName;
				PaidFees = clsApplicationTypes.Find((int)clsApplicationTypes.enApplicationTypes.NewLocalDrivingLicenseService).ApplicationFees;
				lbApplicationFees.Text = PaidFees.ToString() + "$";

			}

			
		}
		private void _FillLicenseClassComboBox()
		{
			DataTable dt = new DataTable();
			dt = clsLicenseClass.LicenseClassNameList();

			cbLicenseClass.Items.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				cbLicenseClass.Items.Add(dr[0].ToString());
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(cbLicenseClass.SelectedIndex == -1)
			{
				MessageBox.Show("You Should To Select A Class License ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return; 
			}

			if(clsApplications.IsPersonHaveCurrentNewLocalLicenseApplication(ApplicationPersonID,ClassLicenseID))
			{
				MessageBox.Show($"Person With ID[{ApplicationPersonID}] Have Another  Application ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(this._enMode == enMode.Update)
			{
				clsApplications application = clsApplications.Find(this.LocalDrivingLicense.ApplicationID);
				if(application.Save())
				{
					this.LocalDrivingLicense.LicenseClassID = cbLicenseClass.SelectedIndex + 1;
					if(this.LocalDrivingLicense.Save())
					{
						MessageBox.Show("Data Saved Successfully ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

						lbDLApplicationID.Text = this.LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
						btnSave.Enabled = false;
						btnClose.Visible = true;
						btnBack.Visible = false;

						return;
					}
					else
					{
						MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{

				clsApplications application = new clsApplications(ApplicationPersonID, DateTime.Now,
					(int)clsApplicationTypes.enApplicationTypes.NewLocalDrivingLicenseService, (int)clsApplications.enApplicationStatus.New, DateTime.Now, PaidFees, clsAppSettings.ProgramUser.UserID);

				if (application.Save())
				{
					clsLocalDrivingLicenseApplications LDLicenseApplciation = new clsLocalDrivingLicenseApplications(application.ApplicationID, ClassLicenseID);
					if (LDLicenseApplciation.Save())
					{
						MessageBox.Show("Data Saved Successfully ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

						lbDLApplicationID.Text = LDLicenseApplciation.LocalDrivingLicenseApplicationID.ToString(); ;
						btnSave.Enabled = false;
						btnClose.Visible = true;
						btnBack.Visible = false;

						return;
					}
					else
					{
						MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					MessageBox.Show("Data Saved Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

		}

		private void btnPersonalInfo_Click(object sender, EventArgs e)
		{
			plPersonalInf.BringToFront();
			btnPersonalInfo.FillColor = Color.FromArgb(43, 56, 63);
			btnApplicationInfo.FillColor = Color.SlateGray;
			btnNext.Visible = true;
			btnBack.Visible = false;
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClassLicenseID = cbLicenseClass.SelectedIndex + 1;
			
		}
	}
}
