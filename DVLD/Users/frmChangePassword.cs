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
	public partial class frmChangePassword : Form
	{
		public frmChangePassword(int UserID)
		{
			InitializeComponent();
			this.User= clsUsers.Find(UserID);
			this.uctlLoginInfo1.FillLoginInfo(UserID);
		}
		public clsUsers User { get; set; }


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
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(tbCurrentPassword.Text) || string.IsNullOrEmpty(tbNewPassword.Text) || string.IsNullOrEmpty(tbConfirmPassword.Text))
			{
				MessageBox.Show("You Should To Fill The Form ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			
			if(this.User.Password != tbCurrentPassword.Text)
			{
				MessageBox.Show("Current Password Is Incorrect Please Try Again ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (tbNewPassword.Text != tbConfirmPassword.Text)
			{
				MessageBox.Show("You Should To Enter Tha Same Password At Confirm Password ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			this.User.Password = tbNewPassword.Text;

			if(User.Save())
			{
				MessageBox.Show("Password Updated Successfully  ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbConfirmPassword.Clear();
				tbCurrentPassword.Clear();
				tbNewPassword.Clear();
				return;
			}
			else
			{
				MessageBox.Show("Password Updated Faild  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


		}
	}
}
