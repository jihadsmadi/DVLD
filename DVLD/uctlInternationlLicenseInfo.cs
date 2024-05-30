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
	public partial class uctlInternationlLicenseInfo : UserControl
	{
		public uctlInternationlLicenseInfo()
		{
			InitializeComponent();
		}
		public void FillTheForm(int InternationalLicenseID)
		{
			clsInternationalLicense internationalLicense = clsInternationalLicense.Find(InternationalLicenseID);
			clsApplications app = clsApplications.Find(internationalLicense.ApplicationID);
			clsPeople Person = clsPeople.Find(app.ApplicationPersonID);

			if (internationalLicense != null)
			{
				lbApplicantName.Text = Person.GetFullName();
				lbInternationalLicenseID.Text = InternationalLicenseID.ToString();
				lbLicenseID.Text = internationalLicense.IssueUsingLocalLicenseID.ToString();
				lbNationalNo.Text = Person.NationalNo;
				lbGendor.Text = (Person.Gendor == 0 ? "Male" : "Female");
				lbIssueDate.Text = internationalLicense.IssueDate.ToShortDateString();
				lbApplicationID.Text = app.ApplicationID.ToString() ;
				lbIsActive.Text = (internationalLicense.IsActive == true) ? "Yes" : "False";
				lbDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
				lbDriverID.Text = internationalLicense.DriverID.ToString();
				lbExpirationDate.Text = internationalLicense.ExpirationDate.ToShortDateString();

			}
		}

	
	}
}
