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
	public partial class frmManageApplicationTypes : Form
	{
		public frmManageApplicationTypes()
		{
			InitializeComponent();
			LoadDataView();
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

		private void LoadDataView()
		{
			gvApplicationTypes.DataSource = clsApplicationTypes.ApplicationTypesList();
			lbApplicationTypesRecordCont.Text = "# Record: " + gvApplicationTypes.Rows.Count.ToString();
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsmEditApplicationType_Click(object sender, EventArgs e)
		{
			if (gvApplicationTypes.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Should To Select A Application Type Record ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int ApplicationTypeID = Convert.ToInt32(gvApplicationTypes.SelectedRows[0].Cells[0].Value);
			frmEditApplicationType frm = new frmEditApplicationType(ApplicationTypeID);
			frm.ShowDialog();
			gvApplicationTypes.DataSource = clsApplicationTypes.ApplicationTypesList();
		}
	}
}
