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
	public partial class uctlPersonInfoWithFilter : UserControl
	{
		public uctlPersonInfoWithFilter()
		{
			InitializeComponent();
			this.PersonID = -1;
		}

		public int PersonID { get; set; }
		private enum enFilterBy {   NationalNo = 0,PersonID = 1};
		private enFilterBy en;
		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			en = (enFilterBy)cbFilterBy.SelectedIndex;
		}
		private void tbFilterBy_TextChanged(object sender, EventArgs e)
		{

		}

		public void FillTheForm(int PersonID)
		{
			tbFilterBy.Text = PersonID.ToString();
			this.uctlPersonInfo1.LoadPersonInfo(PersonID);
		}
		
		private void Form2_DataBack(object sender, int PersonID)
		{
			this.PersonID= PersonID;
			cbFilterBy.SelectedIndex = 1;
			tbFilterBy.Text = PersonID.ToString();
			uctlPersonInfo1.LoadPersonInfo(PersonID);
		}
		private void pbAddNewPerson_Click(object sender, EventArgs e)
		{
			frmAddnewOrUpdatePerson frm = new frmAddnewOrUpdatePerson();
			frm.DataBack += Form2_DataBack;
			frm.ShowDialog();
		}

		private void btnSearchPerson_Click(object sender, EventArgs e)
		{
			clsPeople person;
			if (en == enFilterBy.NationalNo)
			{
				person = clsPeople.Find(tbFilterBy.Text);
			}
			else
			{
				person = clsPeople.Find(Convert.ToInt32(tbFilterBy.Text));
			}

			if (person != null)
			{
				PersonID = person.PersonID;
				uctlPersonInfo1.LoadPersonInfo(PersonID);
			}
			else
			{
				MessageBox.Show("There is No Person With [" + tbFilterBy.Text + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
