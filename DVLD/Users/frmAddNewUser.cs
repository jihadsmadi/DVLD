using Business_Layer;
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

namespace DVLI
{
	public partial class frmAddNewUser : Form
	{
		public frmAddNewUser()
		{
			InitializeComponent();
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
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnPersonalInfo_Click(object sender, EventArgs e)
		{
			plPersonalInf.BringToFront();
			btnPersonalInfo.FillColor = Color.LightSkyBlue;
			btnLoginInfo.FillColor = Color.SlateGray;
			btnNext.Visible = true;
			btnBack.Visible = false;

		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			
			btnLoginInfo.PerformClick();
			
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			btnPersonalInfo.PerformClick();
			
		}
		private void tbUsername_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(((Guna2TextBox)(sender)).Text))
			{
				e.Cancel = true;
				((Guna2TextBox)(sender)).Focus();
				errorProvider1.SetError(((Guna2TextBox)(sender)), $"{((Guna2TextBox)(sender)).Tag.ToString()} Should Have A value");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(((Guna2TextBox)(sender)), "");
			}
		}
		private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(((Guna2TextBox)(sender)).Text))
			{
				e.Cancel = true;
				((Guna2TextBox)(sender)).Focus();
				errorProvider1.SetError(((Guna2TextBox)(sender)), $"{((Guna2TextBox)(sender)).Tag.ToString()} Should Have A value");
			}else if(tbPassword.Text != tbConfirmPassword.Text)
			{
				e.Cancel = true;
				((Guna2TextBox)(sender)).Focus();
				errorProvider1.SetError(((Guna2TextBox)(sender)), "Passwrod Dose Not Matched ...!");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(((Guna2TextBox)(sender)), "");
			}
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if(uctlPersonInfoWithFilter1.PersonID == -1)
			{
				MessageBox.Show("You Should To Select A Person ....!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbConfirmPassword.Text))
			{
				MessageBox.Show("You Should To Fill The Login Form Some Inputs Are Empty ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsUsers user = new clsUsers(tbUsername.Text, tbPassword.Text, uctlPersonInfoWithFilter1.PersonID, cbIsActive.Checked);

			if(user.Save())
			{
				MessageBox.Show("Data Saved Successfully ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lbUserID.Text = user.UserID.ToString();
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
		private void btnLoginInfo_Click(object sender, EventArgs e)
		{
			if (clsUsers.IsUserExistsByPersonID(uctlPersonInfoWithFilter1.PersonID))
			{
				MessageBox.Show($"This Person With [{uctlPersonInfoWithFilter1.PersonID}] ID Is Alredy A User In The System ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			plLoginInfo.BringToFront();
			btnLoginInfo.FillColor = Color.LightSkyBlue;
			btnPersonalInfo.FillColor = Color.SlateGray;
			btnNext.Visible = false;
			btnBack.Visible = true;

		}




	}
}
