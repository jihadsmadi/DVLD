using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;

namespace DVLI
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();

			if (Registry.GetValue(path,"UserName",null) != null)
			{
				FillUserNameAndPassword();
			}					
		}

		string path = @"HKEY_CURRENT_USER\Software\DVLD";
	
		private void FillUserNameAndPassword()
		{
			try
			{
				string UserName = Registry.GetValue(path, "UserName", null) as string;
				string Password = Registry.GetValue(path, "Password", null) as string;

				tbUserName.Text = UserName;
				tbPassword.Text = Password;

				cbRemeberMe.Checked = true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			
						
		}
		private void tbPassword_IconRightClick(object sender, EventArgs e)
		{
			if(tbPassword.IconRight == Properties.Resources.icons8_eye)
			{
				tbPassword.PasswordChar = '\0';
				tbPassword.IconRight = Properties.Resources.icons8_blind;
			}
			else
			{
				tbPassword.PasswordChar = '*';
				tbPassword.IconRight = Properties.Resources.icons8_eye;
			}
			
		}
		private void tbUserName_Validating(object sender, CancelEventArgs e)
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
		private bool SaveUserNameAndPasswordOnRegistry()
		{
			try
			{
				Registry.SetValue(path, "UserName", tbUserName.Text);
				Registry.SetValue(path, "Password", tbPassword.Text);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
	
		}
		private bool ClearRegistry()
		{
			try
			{
			
				Registry.CurrentUser.DeleteValue("UserName");
				Registry.CurrentUser.DeleteValue("Password");
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			clsUsers User = clsUsers.Find(tbUserName.Text,tbPassword.Text);
			
			if(User == null )
			{
				MessageBox.Show("UserName / Password In Correct ...! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!User.IsActive)
			{
				MessageBox.Show("User Is Not Active ...! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				
				if(cbRemeberMe.Checked)				
					SaveUserNameAndPasswordOnRegistry();
				/*else if (Registry.GetValue(path, "UserName", null) != null)
					ClearRegistry();*/
				
				

				clsAppSettings.ProgramUser = User;
				Form1 frm = new Form1();
				this.Hide();
				frm.ShowDialog();
			}

			
		}	
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
