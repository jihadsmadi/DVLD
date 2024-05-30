using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLI
{
	public partial class frmEditApplicationType : Form
	{
		public frmEditApplicationType(int ApplicationTypeID)
		{
			InitializeComponent();
			appType = clsApplicationTypes.Find(ApplicationTypeID);
			_LoadTheForm();
		}

		clsApplicationTypes appType;
		private bool isClick = false;
		int x, y;

		private void _LoadTheForm()
		{
			tbTitle.Text = appType.ApplicationTypeTitle.ToString();
			tbFees.Text = appType.ApplicationFees.ToString();
			lbApplicationTypeID.Text = appType.ApplicatoinTypeID.ToString();
		}
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!float.TryParse(tbFees.Text, out _))
			{
				MessageBox.Show("Fees Should Be A Number  ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (tbFees.Text.Length == 0 || tbTitle.Text.Length == 0)
			{
				MessageBox.Show("You Should To Fill The Form ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			appType.ApplicationTypeTitle = tbTitle.Text;
			appType.ApplicationFees = Convert.ToSingle(tbFees.Text);

			if(appType.Save())
			{
				MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			}
			else
			{
				MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			
			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	
	}
}
