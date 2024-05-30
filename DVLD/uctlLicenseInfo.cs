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
	public partial class uctlDriverLicenseInfo : UserControl
	{
		public uctlDriverLicenseInfo()
		{
			InitializeComponent();

		}

		public int LicenseID { get { return Convert.ToInt32(lbLicenseID.Text.Trim()); } }
		public int DriverID { get { return Convert.ToInt32(lbDriverID.Text.Trim()); } }

		public bool IsDetain { get { return lbIsDetained.Text == "Yes" ? true : false; } set
			{
				if (value == true)
				{
					lbIsDetained.Text = "Yes";
				}
				else
				{
					lbIsDetained.Text = "No";
				}
			}	}
			 

		public clsLicenses License { get; set; }
		public clsPeople Person { get; set; }

		public void FillTheForm(clsLicenses License)
		{
			this.License = License;
			this.Person = clsPeople.Find(clsDrivers.Find(this.License.DriverID).PersonID);

			lbClass.Text = clsLicenseClass.LicenseClassNameByID(this.License.LicenseClass);
			lbApplicantName.Text = this.Person.GetFullName();
			lbLicenseID.Text = this.License.LicenseID.ToString();
			lbNationalNo.Text = this.Person.NationalNo.ToString();
			lbGendor.Text = (this.Person.Gendor == 0) ? "Male" : "Female";
			lbIssueDate.Text = this.License.IssueDate.ToShortDateString();
			lbIssueReason.Text = this.License.IssueReasonName();
			lbNotes.Text = (this.License.Notes == null) ? "No Notes" : this.License.Notes.ToString();
			lbIsActive.Text = (this.License.IsActive == true) ? "Yes" : "No";
			lbDateOfBirth.Text = this.Person.DateOfBirth.ToShortDateString();
			lbDriverID.Text = this.License.DriverID.ToString();
			lbExpirationDate.Text = this.License.ExpirationDate.ToShortDateString();
			if (clsDetainedLicenses.isLicenesDetained(this.License.LicenseID) == true)
			{
				lbIsDetained.Text = "Yes";
				IsDetain = true;
			}
			else
			{
				lbIsDetained.Text = "No";
				IsDetain = false;
			}
			if (this.Person.ImagePath == null)
			{
				if (this.Person.Gendor == 0)
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
				pbImage.ImageLocation = this.Person.ImagePath;
			}
		}


	}
}
