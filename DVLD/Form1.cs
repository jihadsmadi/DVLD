using Business_Layer;
using DVLI.Applications;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lbTodayDate.Text = DateTime.Now.ToShortDateString();
		}

		//Filter Data Grid View None

		private enum enPeopleFilter { Address = 1, CountryName = 2, Email = 3, Gendor = 4, Name = 5, NationalNo = 6, PersonID = 7, Phone = 8 };
		private enum enUsersFilter { None = 0, UserID = 1, PersonID = 2, UserName = 3, FullName = 4, IsActive = 5 };
		private enum enLDLicenseFilter { LDLicenseID = 0, ClassName = 1, NationalNo = 2, FullName = 3, ApplicationDate = 4, PassedTestCount = 5, Status = 6 };
		private enum enDetainedLicenseFilter { None = 0 ,DetainID = 1, IsReleased=2, NationalNo= 3, FullName = 4, ReleaseApplicationID = 5};
		private enum enIsActiveFilter { All = 1, Yes = 2, No = 3 };
		private enum enStatusFilter { New = 1, Cancelled = 2, Completed = 3 };

		//Application Side Bar Collapse 
		bool ApplicationsCollapse = false;

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
			Application.Exit();
		}

		// side bar buttons
		private void _MinumizeApplicationSideBar()
		{
			ApplicationsCollapse = true;
			ApplicationsSideBarTimer.Start();
		}
		private void _ReturnButtonsStyle()
		{
			btnDashboard.ForeColor = Color.FromArgb(49, 54, 63);
			btnDashboard.FillColor = Color.FromArgb(238, 238, 238);
			btnDashboard.Image = Properties.Resources.icons8_dashboard_layout_1;

			btnApplications.ForeColor = Color.FromArgb(49, 54, 63);
			btnApplications.FillColor = Color.FromArgb(238, 238, 238);
			btnApplications.Image = Properties.Resources.icons8_tasks_1;

			btnPeople.ForeColor = Color.FromArgb(49, 54, 63);
			btnPeople.FillColor = Color.FromArgb(238, 238, 238);
			btnPeople.Image = Properties.Resources.icons8_account_1;

			btnUsers.ForeColor = Color.FromArgb(49, 54, 63);
			btnUsers.FillColor = Color.FromArgb(238, 238, 238);
			btnUsers.Image = Properties.Resources.icons8_Users_Settings_1;

			btnUserSettings.ForeColor = Color.FromArgb(49, 54, 63);
			btnUserSettings.FillColor = Color.FromArgb(238, 238, 238);
			btnUserSettings.Image = Properties.Resources.icons8_Settings;

			btnDrivers.ForeColor = Color.FromArgb(49, 54, 63);
			btnDrivers.FillColor = Color.FromArgb(238, 238, 238);
			btnDrivers.Image = Properties.Resources.icons8_taxi_1;

			_ReturnApplicationButtonsStyle();
		}
		private void _ReturnApplicationButtonsStyle()
		{
			btnDrivingLicesesServices.ForeColor = Color.FromArgb(238, 238, 238);
			btnDrivingLicesesServices.FillColor = Color.FromArgb(49, 54, 63);
			btnDrivingLicesesServices.Image = Properties.Resources.icons8_Travel_Insurance;

			btnManageApplications.ForeColor = Color.FromArgb(238, 238, 238);
			btnManageApplications.FillColor = Color.FromArgb(49, 54, 63);
			btnManageApplications.Image = DVLI.Properties.Resources.icons8_tasks1;

			btnDetainLicenses.ForeColor = Color.FromArgb(238, 238, 238);
			btnDetainLicenses.FillColor = Color.FromArgb(49, 54, 63);
			btnDetainLicenses.Image = DVLI.Properties.Resources.icons8_manual_1;

			btnManageApplicationTypes.ForeColor = Color.FromArgb(238, 238, 238);
			btnManageApplicationTypes.FillColor = Color.FromArgb(49, 54, 63);
			btnManageApplicationTypes.Image = DVLI.Properties.Resources.icons8_form;

			btnManageTestsTypes.ForeColor = Color.FromArgb(238, 238, 238);
			btnManageTestsTypes.FillColor = Color.FromArgb(49, 54, 63);
			btnManageTestsTypes.Image = DVLI.Properties.Resources.icons8_list_of_thumbnails_1;

			plDrivingLicenseServicesRightBar.Visible = false;
			plManageApplicationsBar.Visible = false;
			plDetainLicenseBar.Visible = false;

		}
		private void _ChangeButtonStyleOnClick(Guna2Button btn)
		{
			_ReturnButtonsStyle();

			btn.ForeColor = Color.FromArgb(238, 238, 238);
			btn.FillColor = Color.FromArgb(49, 54, 63);
			btn.Image = btn.HoverState.Image;

		}
		private void _ChangeApplicationsButtonStyleOnClick(Guna2Button btn)
		{
			_ReturnApplicationButtonsStyle();

			btn.ForeColor = Color.FromArgb(49, 54, 63);
			btn.FillColor = Color.FromArgb(238, 238, 238);
			btn.Image = btn.HoverState.Image;

		}
		private void _FillLicenseClassComboBoxForFilterInLDL()
		{
			DataTable dt = new DataTable();
			dt = clsLicenseClass.LicenseClassNameList();

			cbClassNameFilterByInLDLicese.Items.Clear();
			foreach (DataRow dr in dt.Rows)
			{
				cbClassNameFilterByInLDLicese.Items.Add(dr[0].ToString());
			}
		}
		private void btnDashboard_Click(object sender, EventArgs e)
		{
			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plDashboard.BringToFront();
			lbWelcomUsersDashbard.Text = "Welcome Back " + clsAppSettings.ProgramUser.UserName;
			_MinumizeApplicationSideBar();


		}

		private void btnApplications_Click(object sender, EventArgs e)
		{

			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plApplications.BringToFront();
			ApplicationsSideBarTimer.Start();
		}

		private void btnPeople_Click(object sender, EventArgs e)
		{
			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plPeople.BringToFront();
			gvPeople.DataSource = clsPeople.PeopleList();
			lbPeopleRecordsCount.Text = $"# Records: {gvPeople.Rows.Count}";
			pbTopOfSideBar.Image = Properties.Resources.people_management_concept_icon_black_sign_vector_35247888;
			_MinumizeApplicationSideBar();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plUsers.BringToFront();
			gvUsers.DataSource = clsUsers.UsersList();
			lbUsersRecordCount.Text = $"# Records: {gvUsers.Rows.Count}";
			pbTopOfSideBar.Image = Properties.Resources.pngtree_user_management;
			_MinumizeApplicationSideBar();
		}

		private void btnUserSettings_Click(object sender, EventArgs e)
		{
			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plUserSettings.BringToFront();
			_MinumizeApplicationSideBar();
		}

		private void btnAddNewPerson_Click(object sender, EventArgs e)
		{
			frmAddnewOrUpdatePerson frm = new frmAddnewOrUpdatePerson();
			frm.ShowDialog();
			gvPeople.DataSource = clsPeople.PeopleList();
		}

		private void tsmUpdateInPeople_Click(object sender, EventArgs e)
		{
			if (gvPeople.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A Person Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}

			frmAddnewOrUpdatePerson frm = new frmAddnewOrUpdatePerson(Convert.ToInt32(gvPeople.SelectedRows[0].Cells[0].Value));
			frm.ShowDialog();
			gvPeople.DataSource = clsPeople.PeopleList();
		}

		private void tsmDeleteInPeople_Click(object sender, EventArgs e)
		{
			if (gvPeople.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A Person Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

			}

			int personID = Convert.ToInt32(gvPeople.SelectedRows[0].Cells[0].Value);
			if (MessageBox.Show($"Do You Sure You Want To Delete The Person With ID[{personID}] ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (clsPeople.DeletePerson(personID))
				{
					MessageBox.Show("Person Deleted Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvPeople.DataSource = clsPeople.PeopleList();
					return;
				}
				else
				{
					MessageBox.Show("Person Deleted Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
				}
			}
		}

		private void cbFilterByInPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbFilterBy.Clear();
		}

		private void tbFilterBy_TextChanged(object sender, EventArgs e)
		{
			DataTable db = clsPeople.PeopleList();
			if (string.IsNullOrEmpty(tbFilterBy.Text))
			{
				gvPeople.DataSource = db;
				return;
			}


			enPeopleFilter enSelectedFilter = ((enPeopleFilter)cbFilterByInPeople.SelectedIndex + 1);
			DataView dv = db.DefaultView;

			string FilterBy = tbFilterBy.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvPeople.DataSource = dv;
		}

		private void btnAddNewUser_Click(object sender, EventArgs e)
		{
			frmAddNewUser frm = new frmAddNewUser();
			frm.ShowDialog();
			gvUsers.DataSource = clsUsers.UsersList();
			lbUsersRecordCount.Text = $"# Records: {gvUsers.Rows.Count}";
		}

		private void cbFilterByInUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbFilterByInUsers.Clear();

			if ((enUsersFilter)cbFilterByInUsers.SelectedIndex == enUsersFilter.IsActive)
			{
				plFilterByComboboxInUsers.BringToFront();
			}
			else
			{
				plFilterByTextBoxInUsers.BringToFront();
			}
		}

		private void tbFilterByInUsers_TextChanged(object sender, EventArgs e)
		{
			DataTable db = clsUsers.UsersList();
			enUsersFilter enSelectedFilter = ((enUsersFilter)cbFilterByInUsers.SelectedIndex);

			if (string.IsNullOrEmpty(tbFilterByInUsers.Text) || enSelectedFilter == enUsersFilter.None)
			{
				gvUsers.DataSource = db;
				return;
			}


			DataView dv = db.DefaultView;
			string FilterBy = tbFilterByInUsers.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvUsers.DataSource = dv;
		}

		private void cbFilterByIsActiveInUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable db = clsUsers.UsersList();

			enUsersFilter enSelectedFilter = ((enUsersFilter)cbFilterByInUsers.SelectedIndex);
			DataView dv = db.DefaultView;

			enIsActiveFilter isActive = (enIsActiveFilter)cbFilterByIsActiveInUsers.SelectedIndex + 1;

			int FilterBy = 0;
			switch (isActive)
			{
				case enIsActiveFilter.All:
					gvUsers.DataSource = dv;
					return;

				case enIsActiveFilter.Yes:
					FilterBy = 1;
					break;
				case enIsActiveFilter.No:
					FilterBy = 0;
					break;
			}

			dv.RowFilter = enSelectedFilter + "  = " + FilterBy + "";
			gvUsers.DataSource = dv;
		}

		private void tsmDeleteUser_Click(object sender, EventArgs e)
		{
			if (gvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A User Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

			}

			int UserID = Convert.ToInt32(gvUsers.SelectedRows[0].Cells[0].Value);
			if (MessageBox.Show($"Do You Sure You Want To Delete The Person With ID[{UserID}] ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (clsUsers.Delete(UserID))
				{
					MessageBox.Show("User Deleted Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvUsers.DataSource = clsUsers.UsersList();
					return;
				}
				else
				{
					MessageBox.Show($"User Deleted Faild, User With [{UserID}] Is Linked With Other Data ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
				}
			}
		}

		private void tsmViewUserInfo_Click(object sender, EventArgs e)
		{
			if (gvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A User Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int UserID = Convert.ToInt32(gvUsers.SelectedRows[0].Cells[0].Value);
			frmUserInfo frm = new frmUserInfo(UserID);
			frm.ShowDialog();

		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			frmLogin frm = new frmLogin();
			frm.Show();
			this.Hide();
			this.Close();
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			frmChangePassword frm = new frmChangePassword(clsAppSettings.ProgramUser.UserID);
			frm.ShowDialog();
		}

		private void btnViewInformation_Click(object sender, EventArgs e)
		{
			frmUserInfo frm = new frmUserInfo(clsAppSettings.ProgramUser.UserID);
			frm.ShowDialog();
		}

		private void tsmUpdateUser_Click(object sender, EventArgs e)
		{
			if (gvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A User Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int UserID = Convert.ToInt32(gvUsers.SelectedRows[0].Cells[0].Value);
			frmUpdateUser frm = new frmUpdateUser(UserID);
			frm.ShowDialog();
			gvUsers.DataSource = clsUsers.UsersList();
		}

		private void btnManageApplicationTypes_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);
			frmManageApplicationTypes frm = new frmManageApplicationTypes();
			frm.ShowDialog();
		}

		private void btnManageTestsTypes_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);
			frmManageTestTypes frm = new frmManageTestTypes();
			frm.Show();
		}

		private void btnNewLocalLicenseApplication_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);
			frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication();
			frm.ShowDialog();
		}

		private void btnDrivingLicesesServices_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);

			if (plDrivingLicenseServicesRightBar.Visible)
				plDrivingLicenseServicesRightBar.Visible = false;
			else
			{
				plDrivingLicenseServicesRightBar.BringToFront();
				plDrivingLicenseServicesRightBar.Visible = true;
				plDrivingLicenseServicesRightBar.Location = new Point(2, 541);

			}
				
		}

		private void btnManageApplications_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);

			if (plManageApplicationsBar.Visible)
				plManageApplicationsBar.Visible = false;
			else
			{
				plManageApplicationsBar.BringToFront();
				plManageApplicationsBar.Visible = true;
				plManageApplicationsBar.Location = new Point(2, 328);
			}
		}

		private void btnDetainLicenses_Click(object sender, EventArgs e)
		{
			_ChangeApplicationsButtonStyleOnClick((Guna2Button)sender);

			if (plDetainLicenseBar.Visible)
				plDetainLicenseBar.Visible = false;
			else
			{
				plDetainLicenseBar.BringToFront();
				plDetainLicenseBar.Visible = true;
				plDetainLicenseBar.Location = new Point(1, 436);
			}
		}

		private void ApplicationsSideBarTimer_Tick(object sender, EventArgs e)
		{

			if (ApplicationsCollapse)
			{
				plApplicationSideBar.Height -= 10;
				if (plApplicationSideBar.Size.Height == plApplicationSideBar.MinimumSize.Height)
				{
					ApplicationsCollapse = false;
					ApplicationsSideBarTimer.Stop();
				}
			}
			else
			{
				plApplicationSideBar.Height += 10;
				if (plApplicationSideBar.Size.Height == plApplicationSideBar.MaximumSize.Height)
				{
					ApplicationsCollapse = true;
					ApplicationsSideBarTimer.Stop();
				}
			}

		}

		private void btnLocalDrivingLicenseManagement_Click(object sender, EventArgs e)
		{
			plLocalDrivingLicenseAppManagement.BringToFront();
			gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
			lbLDLicenseRecordCount.Text = "# Record: " + gvLDLicense.Rows.Count.ToString();
		}

		private void cbFilterByInLDLicense_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((enLDLicenseFilter)cbFilterByInLDLicense.SelectedIndex == enLDLicenseFilter.Status)
			{
				plLDLStatusCb.BringToFront();
			}
			else if ((enLDLicenseFilter)cbFilterByInLDLicense.SelectedIndex == enLDLicenseFilter.ClassName)
			{
				_FillLicenseClassComboBoxForFilterInLDL();
				plLDLClassNameCB.BringToFront();
			}
			else
			{
				plLDLtb.BringToFront();
			}
		}

		private void cbClassNameFilterByInLDLicese_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable db = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();

			enLDLicenseFilter enSelectedFilter = ((enLDLicenseFilter)cbFilterByInLDLicense.SelectedIndex);
			DataView dv = db.DefaultView;

			string FilterBy = cbClassNameFilterByInLDLicese.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvLDLicense.DataSource = dv;
		}

		private void tbFilterByINLDL_TextChanged(object sender, EventArgs e)
		{

			DataTable db = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
			enLDLicenseFilter enSelectedFilter = ((enLDLicenseFilter)cbFilterByInLDLicense.SelectedIndex);

			if (string.IsNullOrEmpty(tbFilterByINLDL.Text))
			{
				gvLDLicense.DataSource = db;
				return;
			}


			DataView dv = db.DefaultView;
			string FilterBy = tbFilterByINLDL.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvLDLicense.DataSource = dv;
		}

		private void cbStatusFilterByInLDLicense_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable db = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();

			enLDLicenseFilter enSelectedFilter = ((enLDLicenseFilter)cbFilterByInLDLicense.SelectedIndex);
			DataView dv = db.DefaultView;

			string FilterBy = cbStatusFilterByInLDLicense.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvLDLicense.DataSource = dv;
		}
		private void _DisabeledScheduleTestMune(int PassedTest)
		{

			if (PassedTest == 0)
			{
				eyeTestToolStripMenuItem.Enabled = true;
				writingTestToolStripMenuItem.Enabled = false;
				streetTestToolStripMenuItem.Enabled = false;
			}
			else if (PassedTest == 1)
			{
				eyeTestToolStripMenuItem.Enabled = false;
				writingTestToolStripMenuItem.Enabled = true;
				streetTestToolStripMenuItem.Enabled = false;
			}
			else if (PassedTest == 2)
			{
				eyeTestToolStripMenuItem.Enabled = false;
				writingTestToolStripMenuItem.Enabled = false;
				streetTestToolStripMenuItem.Enabled = true;
			}
			else
			{
				eyeTestToolStripMenuItem.Enabled = false;
				writingTestToolStripMenuItem.Enabled = false;
				streetTestToolStripMenuItem.Enabled = false;
			}
		}
		private void cmsLDLicenseApplications_Opening(object sender, CancelEventArgs e)
		{
			if (gvLDLicense.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A Local Driving License Application Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			EnabledLocalDrivingContestMinuStrip();

		}
		private void EnabledLocalDrivingContestMinuStrip()
		{
			int PassedTest = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[5].Value);
			_DisabeledScheduleTestMune(PassedTest);
			string nationalNo = gvLDLicense.SelectedRows[0].Cells[2].Value.ToString();
			string status = gvLDLicense.SelectedRows[0].Cells[6].Value.ToString();
			if (clsDrivers.IsDriverExistsByPersonID(clsPeople.Find(nationalNo).PersonID))
			{
				tsmShowPersonLicenseHistory.Enabled = true;
			}
			else
			{
				tsmShowPersonLicenseHistory.Enabled = false;
			}

			if (status == "Completed")
			{
				tsmShowLicense.Enabled = true;
				tsmIssueDrivingLicenseFirstTime.Enabled = false;
				tsmEditApplication.Enabled = false;
				tsmCancelApplication.Enabled = false;
				/*tsmDeleteApplication.Enabled = false;*/
			}
			else
			{
				tsmShowLicense.Enabled = false;
				tsmEditApplication.Enabled = true;
				tsmCancelApplication.Enabled = true;
				/*tsmDeleteApplication.Enabled = true;*/
				tsmIssueDrivingLicenseFirstTime.Enabled = true;
			}

			if (PassedTest == 3 && status != "Completed")
			{
				tsmIssueDrivingLicenseFirstTime.Enabled = true;
			}
			else
			{
				tsmIssueDrivingLicenseFirstTime.Enabled = false;
			}

		}
		private void eyeTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTestAppointments frm = new frmTestAppointments(Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value), (int)clsTestTypes.enTestTypes.VisionTest);
			frm.ShowDialog();
			gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
		}

		private void writingTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTestAppointments frm = new frmTestAppointments(Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value), (int)clsTestTypes.enTestTypes.WrittenTest);
			frm.ShowDialog();
			gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
		}

		private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LocalDrivinLicenseID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			frmTestAppointments frm = new frmTestAppointments(LocalDrivinLicenseID, (int)clsTestTypes.enTestTypes.PracticalStreetTest);
			frm.ShowDialog();
			gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();



		}

		private void tsmIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
		{
			int LocalDrivinLicenseID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			if (Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[5].Value) == 3 && gvLDLicense.SelectedRows[0].Cells[6].Value.ToString() == "New")
			{
				frmIssueDriverLicenseForTheFirstTime frm = new frmIssueDriverLicenseForTheFirstTime(LocalDrivinLicenseID);
				frm.ShowDialog();
				gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
			}
		}

		private void tsmShowLicense_Click(object sender, EventArgs e)
		{
			int LocalDrivinLicenseID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			int ApplicationID = clsLocalDrivingLicenseApplications.Find(LocalDrivinLicenseID).ApplicationID;

			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(clsLicenses.GetLicenseIDByApplicationID(ApplicationID));
			frm.ShowDialog();
		}

		private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
		{
			int LocalDrivingApplicationID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			int DriverID = clsDrivers.GetDriverIDByPersonID(clsApplications.Find(clsLocalDrivingLicenseApplications.Find(LocalDrivingApplicationID).ApplicationID).ApplicationPersonID);

			frmLicenseHistory frm = new frmLicenseHistory(DriverID);
			frm.ShowDialog();
		}

		private void btnDrivers_Click(object sender, EventArgs e)
		{

			_ChangeButtonStyleOnClick((Guna2Button)(sender));
			plDrivers.BringToFront();
			gvDrivers.DataSource = clsDrivers.DriversList();
			lbDriversCount.Text = $"# Records: {gvDrivers.Rows.Count}";
			_MinumizeApplicationSideBar();
		}

		private void btnDrivingLicesesServices_MouseHover(object sender, EventArgs e)
		{
				plDrivingLicenseServicesRightBar.BringToFront();
				plDrivingLicenseServicesRightBar.Visible = true;
		}

		private void btnInternationalLicense_Click(object sender, EventArgs e)
		{
			frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
			frm.ShowDialog();
		}

		private void plApplications_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnManageApplications_MouseHover(object sender, EventArgs e)
		{ 
			plManageApplicationsBar.BringToFront();
			plManageApplicationsBar.Visible = true;
		}

		private void btnInternationalLicenseApplcations_Click(object sender, EventArgs e)
		{
			plInternationalLicenseApplications.BringToFront();
			gvInternationalLicensesApplications.DataSource = clsInternationalLicense.InternationlLicense();
			lbInternationalLicenseRecordCount.Text = "# Record: " + gvInternationalLicensesApplications.Rows.Count.ToString();
		}

		private void tsmShowPersonInof_Click(object sender, EventArgs e)
		{
			int DriverId = Convert.ToInt32(gvInternationalLicensesApplications.SelectedRows[0].Cells[2].Value);
			frmPersonDetails frm = new frmPersonDetails(clsDrivers.Find(DriverId).PersonID);
			frm.ShowDialog();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int InternationlLicenseID = Convert.ToInt32(gvInternationalLicensesApplications.SelectedRows[0].Cells[0].Value);
			frmInternationalDriverInfo frm = new frmInternationalDriverInfo(InternationlLicenseID);
			frm.ShowDialog();
		}

		private void tsmShowPersonHistoryInInternational_Click(object sender, EventArgs e)
		{
			int DriverId = Convert.ToInt32(gvInternationalLicensesApplications.SelectedRows[0].Cells[2].Value);
			frmLicenseHistory frm = new frmLicenseHistory(DriverId);
			frm.ShowDialog();
		}

		private void tsmCancelApplication_Click(object sender, EventArgs e)
		{
			string status = gvLDLicense.SelectedRows[0].Cells[6].Value.ToString();
			if (status == "Completed" || status == "Cancelled")
			{
				MessageBox.Show("You can't Cancel This Applciation ...!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int LocalLiceseApplicationID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			clsApplications app = clsApplications.Find(clsLocalDrivingLicenseApplications.Find(LocalLiceseApplicationID).ApplicationID);

			app.ApplicationStatus = (int)clsApplications.enApplicationStatus.Cancelled;

			if(MessageBox.Show($"Are You Sure You Want To Cancelled Local Application With Id [{LocalLiceseApplicationID}]  ...?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(app.Save())
				{
					MessageBox.Show("Data Saved Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList(); 
					return;
				}
				else
				{
					MessageBox.Show("Data Saved Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; 
				}
				
			}
			
			
		}

		private void tsmEditApplication_Click(object sender, EventArgs e)
		{
			int LocalLiceseApplicationID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);
			frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(LocalLiceseApplicationID);
			frm.ShowDialog();
			gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
		}

		private void tsmShowApplicationDetails_Click(object sender, EventArgs e)
		{
			frmShowLocalDrivingApplicationInfo frm = new frmShowLocalDrivingApplicationInfo(Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value));
			frm.ShowDialog();
		}

		private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
		{
			frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
			frm.ShowDialog();

		}

		private void btnReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
		{
			frmReplacementLicnese frm = new frmReplacementLicnese();
			frm.ShowDialog();
		}

		private void btnDetainLicenses_MouseHover(object sender, EventArgs e)
		{

			plDetainLicenseBar.BringToFront();
			plDetainLicenseBar.Visible = true;
		}

		private void btnDetainLicense_Click(object sender, EventArgs e)
		{
			frmDetainLicense frm = new frmDetainLicense();
			frm.ShowDialog();
		}

		private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
		{
			frmReleaseDetainLicense frm = new frmReleaseDetainLicense();
			frm.ShowDialog();
		}

		private void btnManageDetainLicenses_Click(object sender, EventArgs e)
		{
			plDetainedLicensesManagement.BringToFront();
			gvDetainedLicenses.DataSource = clsDetainedLicenses.DeatinedLicenseList();
			lbDetainedLicenseRecordCount.Text = "# Record: " + gvDetainedLicenses.Rows.Count.ToString();
		}

		private void tsmShowPersonInfoInDetainedLicenses_Click(object sender, EventArgs e)
		{
			int DriverID = clsLicenses.Find(Convert.ToInt32(gvDetainedLicenses.SelectedRows[0].Cells[1].Value)).DriverID;
			int PersonID = clsDrivers.PersonIDByDriverID(DriverID);

			frmPersonDetails frm = new frmPersonDetails(PersonID);
			frm.ShowDialog();
		}

		private void tsmShowLicenseDetailsInDetainedLicense_Click(object sender, EventArgs e)
		{
			int LicenseID = Convert.ToInt32(gvDetainedLicenses.SelectedRows[0].Cells[1].Value);
			frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseID);
			frm.ShowDialog();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			int DriverID = clsLicenses.Find( Convert.ToInt32(gvDetainedLicenses.SelectedRows[0].Cells[1].Value)).DriverID ;
			frmLicenseHistory frm = new frmLicenseHistory(DriverID);
			frm.ShowDialog();
		}

		private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
		{
			int LicenseID = Convert.ToInt32(gvDetainedLicenses.SelectedRows[0].Cells[1].Value);
			bool isReleased = !clsDetainedLicenses.isLicenesDetained(LicenseID);

			if(isReleased)
			{
				tsmReleaseDetainedLicense.Enabled = false;
			}
			else
			{
				tsmReleaseDetainedLicense.Enabled = true;
			}
		}

		private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
		{
			int LicenseID = Convert.ToInt32(gvDetainedLicenses.SelectedRows[0].Cells[1].Value);
			frmReleaseDetainLicense frm = new frmReleaseDetainLicense(LicenseID);
			frm.ShowDialog();
		}

		private void btnRelease_Click(object sender, EventArgs e)
		{
			frmReleaseDetainLicense frm = new frmReleaseDetainLicense();
			frm.ShowDialog();

		}

		private void btnDetain_Click(object sender, EventArgs e)
		{
			frmDetainLicense frm = new frmDetainLicense();
			frm.ShowDialog();
		}

		private void cbFilterByInDetainedLicensesManagement_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbFilterByInDetainedLicenses.Clear();

			if ((enDetainedLicenseFilter)cbFilterByInDetainedLicensesManagement.SelectedIndex == enDetainedLicenseFilter.IsReleased)
			{
				plIsReleasedFilterINDetained.BringToFront();
			}
			else
			{
				plTextBoxFilterInDetained.BringToFront();
			}
		}

		private void tbFilterByInDetainedLicenses_TextChanged(object sender, EventArgs e)
		{
			DataTable db =clsDetainedLicenses.DeatinedLicenseList();
			enDetainedLicenseFilter enSelectedFilter = ((enDetainedLicenseFilter)cbFilterByInDetainedLicensesManagement.SelectedIndex);

			if (string.IsNullOrEmpty(tbFilterByInDetainedLicenses.Text)  || char.IsPunctuation(tbFilterByInDetainedLicenses.Text[tbFilterByInDetainedLicenses.Text.Length-1]))
			{
				gvDetainedLicenses.DataSource = db;
				return;
			}


			DataView dv = db.DefaultView;
			string FilterBy = tbFilterByInDetainedLicenses.Text;

			dv.RowFilter = enSelectedFilter + "  = '" + FilterBy + "'";
			gvDetainedLicenses.DataSource = dv;
		}

		private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable db = clsDetainedLicenses.DeatinedLicenseList();

			enDetainedLicenseFilter enSelectedFilter = ((enDetainedLicenseFilter)cbFilterByInDetainedLicensesManagement.SelectedIndex);
			DataView dv = db.DefaultView;

			enIsActiveFilter isActive = (enIsActiveFilter)cbFilterIsReleasedInDetained.SelectedIndex + 1;

			int FilterBy = 0;
			switch (isActive)
			{
				case enIsActiveFilter.All:
					gvDetainedLicenses.DataSource = dv;
					return;

				case enIsActiveFilter.Yes:
					FilterBy = 1;
					break;
				case enIsActiveFilter.No:
					FilterBy = 0;
					break;
			}

			dv.RowFilter = enSelectedFilter + "  = " + FilterBy + "";
			gvDetainedLicenses.DataSource = dv;
		}

		/*private void tsmDeleteApplication_Click(object sender, EventArgs e)
		{
			int LocalLiceseApplicationID = Convert.ToInt32(gvLDLicense.SelectedRows[0].Cells[0].Value);

			clsApplications app = clsApplications.Find(clsLocalDrivingLicenseApplications.Find(LocalLiceseApplicationID).ApplicationID);
			

			

			if (MessageBox.Show($"Are You Sure You Want To Delete Local Application With Id [{LocalLiceseApplicationID}]  ...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicense(LocalLiceseApplicationID))
				{
					if(clsApplications.DeleteApplication(app.ApplicationID))
					{
						MessageBox.Show("Application Deletaed Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
						gvLDLicense.DataSource = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationsList();
						return;
					}
					else
					{
						MessageBox.Show("Deleted Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
					}

				}
				else
				{
					MessageBox.Show("Deleted Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
				}

			}
		}*/

		private void tsmViewPersonInfoInPeople_Click(object sender, EventArgs e)
		{
			if (gvPeople.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A Person Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

			}

			int personID = Convert.ToInt32(gvPeople.SelectedRows[0].Cells[0].Value);
			frmPersonDetails frm = new frmPersonDetails(personID);
			frm.ShowDialog();
			gvPeople.DataSource = clsPeople.PeopleList();
		}



	}
}
