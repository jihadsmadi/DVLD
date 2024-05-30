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
	public partial class uctlPersonInfo : UserControl
	{
		public uctlPersonInfo()
		{
			InitializeComponent();
		}

		private clsPeople person;
		public void LoadPersonInfo(int PersonID)
		{
			if (PersonID == -1)
				return;

			person = clsPeople.Find(PersonID);

			if (person == null) return;

			lbPersonID.Text = person.PersonID.ToString();
			lbName.Text = person.GetFullName();
			lbEmail.Text = person.Email;
			lbNationalNo.Text = person.NationalNo;
			lbAddress.Text = person.Address;
			lbPhone.Text = person.Phone;
			lbDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
			lbCountry.Text = person.CountryName();
			if(person.ImagePath == null)
			{
				if (person.Gendor == 0)
				{
					pbImage.Image = Properties.Resources.male1;
				}
				else
				{
					pbImage.Image = Properties.Resources.Female;
				}
			}
			else
			{
				pbImage.ImageLocation = person.ImagePath;
			}

			if(person.Gendor ==0)
			{
				lbGendor.Text = "Male";
			}
			else
			{
				lbGendor.Text = "Female";
			}


		}

		private void lbEditPerson_Click(object sender, EventArgs e)
		{
			frmAddnewOrUpdatePerson frm = new frmAddnewOrUpdatePerson(person.PersonID);
			frm.ShowDialog();
			LoadPersonInfo(person.PersonID);

		}
	}
}
