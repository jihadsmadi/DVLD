using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static Business_Layer.clsApplicationTypes;

namespace DVLI
{
	public partial class frmTestAppointments : Form
	{
		
		public frmTestAppointments(int LDLApplicationID,int TestTypeID)
		{
			InitializeComponent();
			this.TestTypeID = TestTypeID; 
			this.LDLApplicationID= LDLApplicationID;

			_FillTheForm();


		}
		int LDLApplicationID;
		public int TestTypeID { get; set; }
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
		private void btnReserveAppointment_MouseHover(object sender, EventArgs e)
		{
			btnReserveAppointment.BorderThickness = 2;
		}
		private void _ChangeTheHeader()
		{
			if ((int)clsTestTypes.enTestTypes.VisionTest == this.TestTypeID)
			{
				lbHeadar.Text = "Vision Test Appointment";
			}
			else if ((int)clsTestTypes.enTestTypes.WrittenTest == this.TestTypeID)
			{
				lbHeadar.Text = "Writing Test Appointment";
			}
			else if ((int)clsTestTypes.enTestTypes.PracticalStreetTest == this.TestTypeID)
			{
				lbHeadar.Text = "Street Test Appointment";
			}
		}
		private void _FillTestAppointmentsDataGridView()
		{
			gvAppointments.DataSource = clsTestAppointment.GetTestAppointmentList(this.LDLApplicationID, this.TestTypeID);
			lbAppointmentRecordCount.Text = "#Record:" + gvAppointments.Rows.Count.ToString();
		}
		private void _FillTheForm()
		{
			uctlDLDApplicationCompleteInformation1.FillTheForm(this.LDLApplicationID);
			_FillTestAppointmentsDataGridView();


			_ChangeTheHeader();
		}
		private void btnReserveAppointment_Click(object sender, EventArgs e)
		{
			if(clsTests.IsPassedTest(this.LDLApplicationID, this.TestTypeID))
			{
				MessageBox.Show("This Peson Already Passed This Appointment Before,You Can Only Retake The Faild Tests ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			if(clsTestAppointment.IsHasActiveAppointment(this.LDLApplicationID,this.TestTypeID))
			{
				MessageBox.Show("This Peson Already Has An Active Appointment You Can't Add New Appointmen ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			frmScheduleTest frm = new frmScheduleTest(this.LDLApplicationID, this.TestTypeID);
			frm.ShowDialog();
			_FillTestAppointmentsDataGridView();
		}
		private void tsmEdit_Click(object sender, EventArgs e)
		{
			frmScheduleTest frm = new frmScheduleTest(Convert.ToInt32(gvAppointments.SelectedRows[0].Cells[0].Value));
			frm.ShowDialog();
			_FillTestAppointmentsDataGridView();
		}
		private void tsmTakeTest_Click(object sender, EventArgs e)
		{
			if (clsTestAppointment.Find(Convert.ToInt32(gvAppointments.SelectedRows[0].Cells[0].Value)).IsLocked == true)
			{
				MessageBox.Show("Appointment Locked You Can't Edit It ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			int TestAppointmenID = Convert.ToInt32(gvAppointments.SelectedRows[0].Cells[0].Value);

			frmTakeTest frm;
			if (clsTests.IsRetakeTest(this.LDLApplicationID, this.TestTypeID))
			{
				frm = new frmTakeTest(TestAppointmenID,true,clsApplications.Find( clsLocalDrivingLicenseApplications.Find(this.LDLApplicationID).ApplicationID).ApplicationPersonID );
			}
			else
			{
				frm = new frmTakeTest(TestAppointmenID,false,-1);
			}
			
			frm.ShowDialog();
			_FillTestAppointmentsDataGridView();
		}
		

		
	}
}
