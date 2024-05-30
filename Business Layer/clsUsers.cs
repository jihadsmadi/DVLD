using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsUsers
	{
		private enum _enMode { AddNew = 1, Update = 2 };
		private _enMode Mode;
		public int UserID { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }

		public int PersonID { get; set; }

		public bool IsActive { get; set; }


		public clsUsers(string UserName,string Password,int PersonID,bool IsActive)
		{
			this.Mode = _enMode.AddNew;

			this.UserName = UserName;
			this.Password = Password;
			this.PersonID = PersonID;
			this.IsActive = IsActive;
		}
		private clsUsers(int UserID,string UserName, string Password, int PersonID, bool IsActive)
		{
			this.Mode = _enMode.Update;

			this.UserID = UserID;
			this.UserName = UserName;
			this.Password = Password;
			this.PersonID = PersonID;
			this.IsActive = IsActive;

		}
		private bool _AddNew()
		{
			this.UserID = UsersData.AddUser(this.UserName,this.Password,this.IsActive,this.PersonID);


			return (this.UserID != -1);
		}
		private bool _Update()
		{
			return UsersData.UpdateUser(this.UserID,this.UserName,this.Password,this.IsActive,this.PersonID);
		}
		public bool Save()
		{
			switch (this.Mode)
			{
				case _enMode.AddNew:
					if (this._AddNew())
					{
						this.Mode = _enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case _enMode.Update:
					if (this._Update())
						return true;
					else
						return false;
			}
			return false;
		}

		public static bool IsUserExists(int UserID)
		{
			return UsersData.isUserExists(UserID);
		}

		public static bool IsUserExists(string UserName)
		{
			return UsersData.isUserExists(UserName);
		}

		public static bool IsUserExistsByPersonID(int PersonID)
		{
			return UsersData.isUserExistsByPersonID(PersonID);
		}

		public static bool Delete(int UserID)
		{
			return UsersData.DeleteUser(UserID);
		}

		static public clsUsers Find(int UserID)
		{

			if (!IsUserExists(UserID))
			{
				return null;
			}

			string UserName = "", Password = "";
			bool IsActive = false;
			int PersonID = -1;

			

			if (UsersData.GetUserByID(UserID,ref UserName,ref Password,ref IsActive,ref PersonID) == true)
			{
				return new clsUsers(UserID, UserName, Password, PersonID, IsActive);
			}

			else
			{
				return null;
			}


		}

		static public clsUsers Find(string UserName,string Password)
		{

			if (!IsUserExists(UserName))
			{
				return null;
			}

			int UserID = -1,PersonID = -1;
			bool IsActive = false;
			



			if (UsersData.GetUserByUserNameAndPassword(ref UserID,  UserName,  Password, ref IsActive, ref PersonID) == true)
			{
				return new clsUsers(UserID, UserName, Password, PersonID, IsActive);
			}

			else
			{
				return null;
			}


		}

		static public DataTable UsersList()
		{
			return UsersData.GetUsersList();
		}


	}
}
