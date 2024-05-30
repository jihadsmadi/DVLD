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
	public partial class uctlInternationalLicenseApplicationWithFilter : UserControl
	{
		public uctlInternationalLicenseApplicationWithFilter()
		{
			InitializeComponent();
			
		}

		public delegate void DataBackEventHandler(Object sender, int LicenseID);
		public DataBackEventHandler DataBack;
		public clsLicenses License { get; set; }
		public int DriverID { get { return this.uctlDriverLicenseInfo1.DriverID; } }

		public bool IsDeatin { get { return this.uctlDriverLicenseInfo1.IsDetain; } set { this.uctlDriverLicenseInfo1.IsDetain = true; } }


		private void pbSearchLicense_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(tbLicenseID.Text) || !int.TryParse(tbLicenseID.Text,out _) )
			{
				MessageBox.Show("You Should To Enter A Valid License ID ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			this.License = clsLicenses.Find( Convert.ToInt32(tbLicenseID.Text));

			if(License != null)
			{
				

				if (clsLicenses.IsLicenseExists(License.LicenseID))
				{
					this.uctlDriverLicenseInfo1.FillTheForm(License);
					DataBack?.Invoke(this, this.License.LicenseID);
				}
			}
			

		}

		public void searchByID(int LicenseID)
		{
			tbLicenseID.Text = LicenseID.ToString();

			if (string.IsNullOrEmpty(tbLicenseID.Text) || !int.TryParse(tbLicenseID.Text, out _))
			{
				MessageBox.Show("You Should To Enter A Valid License ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.License = clsLicenses.Find(Convert.ToInt32(tbLicenseID.Text));

			if (License != null)
			{


				if (clsLicenses.IsLicenseExists(License.LicenseID))
				{
					this.uctlDriverLicenseInfo1.FillTheForm(License);
					DataBack?.Invoke(this, this.License.LicenseID);
				}
			}

			gbFilterByLicenseID.Enabled = false;
		}

	}
}
