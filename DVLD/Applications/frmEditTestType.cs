using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLI.Applications
{
	public partial class frmEditTestType : Form
	{
		public frmEditTestType(int TestTypeID)
		{
			InitializeComponent();
			testType = clsTestTypes.Find(TestTypeID);
			_LoadTheForm();
		}
		clsTestTypes testType;
		private bool isClick = false;
		int x, y;

		private void _LoadTheForm()
		{
			tbTitle.Text = testType.TestTypeTitle.ToString();
			tbDescription.Text = testType.TestTypeDescription.ToString();
			tbFees.Text = testType.TestTypeFees.ToString();
			lbTestTypeID.Text = testType.TestTypeID.ToString();
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!float.TryParse(tbFees.Text, out _))
			{
				MessageBox.Show("Fees Should Be A Number  ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (tbFees.Text.Length == 0 || tbTitle.Text.Length == 0 || tbDescription.Text.Length == 0)
			{
				MessageBox.Show("You Should To Fill The Form ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			testType.TestTypeTitle = tbTitle.Text;
			testType.TestTypeDescription = tbDescription.Text;
			testType.TestTypeFees = Convert.ToSingle(tbFees.Text);

			if (testType.Save())
			{
				MessageBox.Show("Data Saved Successfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("Data Saved Faild ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

	}
}
