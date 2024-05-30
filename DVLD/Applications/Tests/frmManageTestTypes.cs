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

namespace DVLI.Applications
{
	public partial class frmManageTestTypes : Form
	{
		public frmManageTestTypes()
		{
			InitializeComponent();
			_LoadDataView();
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
		private void _LoadDataView()
		{
			gvTestTypes.DataSource = clsTestTypes.TestTypesList();
			lbTestTypesRecordCont.Text = "# Record: " + gvTestTypes.Rows.Count.ToString();
		}
		private void tsmEditTestType_Click(object sender, EventArgs e)
		{
			if (gvTestTypes.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A TakeAppointment Type Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int TestTypeID = Convert.ToInt32(gvTestTypes.SelectedRows[0].Cells[0].Value);
			frmEditTestType frm = new frmEditTestType(TestTypeID);
			frm.ShowDialog();
			gvTestTypes.DataSource = clsTestTypes.TestTypesList();
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
