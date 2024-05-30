using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLI
{
	public partial class frmAddnewOrUpdatePerson : Form
	{

		private enum Mode {  AddNew = 1,Update = 2 };
		private Mode _mode;

		private clsPeople person;
		public frmAddnewOrUpdatePerson(int personID)
		{
			if (personID == -1) { this.Close(); }
			InitializeComponent();

			_mode = Mode.Update;
			this.person = clsPeople.Find(personID);
			
			_LoadTheForm();
		}
		public frmAddnewOrUpdatePerson()
		{
			InitializeComponent();
			_mode = Mode.AddNew;
			_LoadTheForm();
		}


		public delegate void DataBackEventHandler(Object sender, int PersonID);
		public DataBackEventHandler DataBack;

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
		private void _LoadTheForm()
		{
			
			FillCountriesCombobox();
			dtpDateOfBirth.MinDate = DateTime.Now - new TimeSpan(365 * 100, 0, 0, 0);
			dtpDateOfBirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0);

			if (this._mode == Mode.Update)
			{
				_FillTheFormInfo();
				lbPersonID.Text = this.person.PersonID.ToString();
				lbAddNewOrUpdate.Text = "Update Person";
			}
		}
		private void FillCountriesCombobox()
		{
			cbCountries.Items.Clear();
			DataTable dt = clsPeople.CountriesList();

			foreach (DataRow dr in dt.Rows)
			{
				cbCountries.Items.Add(dr[1].ToString());
			}

		}
		public void  _FillTheFormInfo()
		{
			

			tbFirstName.Text = this.person.FirstName;
			tbSecondName.Text = this.person.SecondName;
			tbThirdName.Text = this.person.ThirdName;
			tbLastName.Text = this.person.LastName;
			tbNationalNo.Text = this.person.NationalNo;
			tbEmail.Text = this.person.Email;
			tbAddress.Text = this.person.Address;
			tbPhone.Text = this.person.Phone;
			cbCountries.SelectedIndex = this.person.NationalityCountryID - 1;
			dtpDateOfBirth.Value = this.person.DateOfBirth;

			// set gendor and personal image
			if (this.person.Gendor == 0)
			{
				rbMale.Checked = true;
				rbFemale.Checked = false;

				if (this.person.ImagePath == null || string.IsNullOrEmpty(this.person.ImagePath))
				{
					pbImage.Image = Properties.Resources.male1;
				}
				else
				{
					pbImage.ImageLocation = this.person.ImagePath;
				}
			}
			else
			{
				rbMale.Checked = false;
				rbFemale.Checked = true;

				if (this.person.ImagePath == null || string.IsNullOrEmpty(this.person.ImagePath))
				{
					pbImage.Image = Properties.Resources.Female;
				}
				else
				{
					pbImage.ImageLocation = this.person.ImagePath;
				}
			}


		}
		private void _ChangesOnSelectedImage(string filePath)
		{
			string destinationDirectory = @"C:\Users\USER\Images\";
			string newFileName = Guid.NewGuid().ToString();
			File.Move(filePath, destinationDirectory + newFileName + ".jpg");
			pbImage.ImageLocation = destinationDirectory + newFileName + ".jpg";
		}
		private void lbSetImage_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.InitialDirectory = @"C:\Users\USER\Pictures";
			openFileDialog1.Title = "Pick a Picture";
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*;"; ;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_ChangesOnSelectedImage(openFileDialog1.FileName);
				lbRemoveImage.Visible = true;
			}
			else
			{
				return;
			}
		}
		private void lbRemoveImage_Click(object sender, System.EventArgs e)
		{
			lbRemoveImage.Visible = false;

			if (rbMale.Checked)
			{
				pbImage.Image = Properties.Resources.male1;
			}
			else
			{
				pbImage.Image = Properties.Resources.Female;
			}
		}
		private void tbFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
		private void rbMale_CheckedChanged(object sender, EventArgs e)
		{
			if (rbMale.Checked)
			{
				pbImage.Image = Properties.Resources.male1;
			}
			else
			{
				pbImage.Image = Properties.Resources.Female;
			}
		}
		private void tbEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (tbEmail.Text.Length == 0) return;

			string email = tbEmail.Text;

			System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex
				(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

			if (expr.IsMatch(email))
			{
				e.Cancel = false;
				errorProvider1.SetError(((Guna2TextBox)(sender)), "");
			}
			else
			{
				e.Cancel = true;
				((Guna2TextBox)(sender)).Focus();
				errorProvider1.SetError(((Guna2TextBox)(sender)), "Email Should Be In Right Expressions Like \"test@gmail.com\" ");
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			if(this.person != null)
			{
				DataBack?.Invoke(this, this.person.PersonID);
			}
			
			this.Close();
			
		}
		private void _FillPersonObjectForUpdate()
		{
			person.FirstName = tbFirstName.Text;
			person.SecondName = tbSecondName.Text;
			person.ThirdName = tbThirdName.Text;
			person.LastName = tbLastName.Text;
			person.Email = tbEmail.Text;
			person.Phone = tbPhone.Text;
			person.ImagePath = pbImage.ImageLocation;
			person.Address = tbAddress.Text;
			person.NationalNo = tbNationalNo.Text;
			person.DateOfBirth = dtpDateOfBirth.Value;
			person.NationalityCountryID = cbCountries.SelectedIndex +1;
			
			if(rbMale.Checked == true)
			{
				person.Gendor = 0;
			}
			else
			{
				person.Gendor = 1;
			}

		}

		

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbFirstName.Text.Length == 0 || tbSecondName.Text.Length == 0 || tbLastName.Text.Length == 0 || tbNationalNo.Text.Length == 0 ||
				tbPhone.Text.Length == 0 || tbAddress.Text.Length == 0 )
			{
				MessageBox.Show("You Should To Fill The Form ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				if(this._mode == Mode.Update)
				{
					_FillPersonObjectForUpdate();
					if(this.person.Save())
					{
						MessageBox.Show("Data Saved Successfully ...!","Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
				}
				else
				{
					this.person = new clsPeople(tbNationalNo.Text, tbFirstName.Text, tbSecondName.Text, tbThirdName.Text,tbLastName.Text, dtpDateOfBirth.Value
						,Convert.ToByte(rbMale.Checked ? 0 : 1),tbAddress.Text,tbPhone.Text,tbEmail.Text,cbCountries.SelectedIndex+1,pbImage.ImageLocation);

					if (this.person.Save())
					{
						MessageBox.Show("Data Saved Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
						lbPersonID.Text = this.person.PersonID.ToString(); 
						return;
					}

				}
			}
		}

		


	}
}
