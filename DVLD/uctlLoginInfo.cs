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
	public partial class uctlLoginInfo : UserControl
	{
		public uctlLoginInfo()
		{
			InitializeComponent();
		}

		public void FillLoginInfo(int UserID)
		{
			if (UserID == -1)
				return;

			clsUsers u = clsUsers.Find(UserID);

			if(u != null) 
			{
				uctlPersonInfo1.LoadPersonInfo(u.PersonID);
				lbUserID.Text = u.UserID.ToString();
				lbUserName.Text = u.UserName.ToString();

				if(u.IsActive)
				{
					lbIsActive.Text = "Yes";
				}
				else
				{
					lbIsActive.Text = "No";
				}
			}
			
		}
	}
}
