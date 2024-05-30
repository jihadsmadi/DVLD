using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
	public class clsPeople
	{
		private enum _enMode { AddNew=1,Update=2};
		private _enMode Mode;
		public int PersonID { get; set; }
		public string NationalNo { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string ThirdName { get; set; }
		public string LastName { get; set;}
		public DateTime DateOfBirth { get; set; }
		public byte Gendor { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public int NationalityCountryID { get; set; }
		public string ImagePath { get; set; }


		public clsPeople(string NationalNo,string FirstName,string SecondName,string ThirdName,string LastName,DateTime DateOfBirth,Byte Gendor,
			string Address,string Phone,string Email,int NationalityCountryID,string ImagePath)
		{
			this.PersonID = -1;
			this.NationalNo = NationalNo;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.LastName = LastName;
			this.DateOfBirth = DateOfBirth;
			this.Gendor= Gendor;
			this.Address = Address;
			this.Phone = Phone;
			this.Email = Email;
			this.NationalityCountryID = NationalityCountryID;
			this.ImagePath = ImagePath;

			this.Mode = _enMode.AddNew;


		}

		private clsPeople(int PersonID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, Byte Gendor,
			string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{
			this.PersonID =PersonID;
			this.NationalNo = NationalNo;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.LastName = LastName;
			this.DateOfBirth = DateOfBirth;
			this.Gendor = Gendor;
			this.Address = Address;
			this.Phone = Phone;
			this.Email = Email;
			this.NationalityCountryID = NationalityCountryID;
			this.ImagePath = ImagePath;

			this.Mode = _enMode.Update;
		}

		public string GetFullName() => FirstName+ " " + SecondName + " " + ThirdName + " " + LastName;
		public static bool DeletePerson(int PersonID)
		{
			return PeopleData.DeletePerson(PersonID);
		}
		private bool _AddNew()
		{
			this.PersonID = PeopleData.AddPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
				this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

			return (this.PersonID != -1);
		}
		private bool _Update()
		{
			return PeopleData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
				this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
		}
		public bool Save()
		{
			switch (this.Mode)
			{
				case _enMode.AddNew:
					if(this._AddNew())
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

		public static bool IsPersonExists(int PersonID)
		{
			return PeopleData.isPersonExists(PersonID);
		}

		public static bool IsPersonExists(string NationalNo)
		{
			return PeopleData.isPersonExists(NationalNo);
		}

		static public clsPeople Find(int PersonID)
		{

			if (!IsPersonExists(PersonID))
			{
				return null;
			}

			string FirstName = "",SecondName = "",ThirdName = "", LastName = "",Email="",ImagePath="", NationalNo = "", Address = "",Phone="";

			DateTime DateOfBirth = DateTime.Now;

			byte Gendor=0;
			int NationalityCountryID = -1;


			if (PeopleData.GetPersonByID(PersonID,ref NationalNo, ref FirstName,ref SecondName,ref ThirdName, ref LastName,ref DateOfBirth,
				ref Gendor,ref Address, ref Phone,ref Email,ref NationalityCountryID,ref ImagePath) == true)
			{
				return new clsPeople(PersonID,  NationalNo,  FirstName,  SecondName, ThirdName, LastName, DateOfBirth,
				Gendor, Address, Phone, Email, NationalityCountryID,ImagePath);
			}

			else
			{
				return null;
			}


		}
		static public clsPeople Find(string NationalNo)
		{

			if (!IsPersonExists(NationalNo))
			{
				return null;
			}
			
			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", ImagePath = "", Address = "", Phone = "";

			DateTime DateOfBirth = DateTime.Now;

			byte Gendor = 0;
			int NationalityCountryID = -1,PersonID = -1;


			if (PeopleData.GetPersonByNationalNo(ref PersonID,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
				ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath) == true)
			{
				return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
				Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
			}

			else
			{
				return null;
			}


		}

		static public bool isEmailUsed(string Email) => PeopleData.isEmailUsed(Email);

		static public bool isNationalNoUsed(string NationalNo) => PeopleData.isNationalNoUsed(NationalNo);

		public string CountryName()
		{
			return PeopleData.GetCountryNameByCountryID(this.NationalityCountryID);
		}
		static public DataTable PeopleList()
		{
			return PeopleData.GetPeopleList();
		}

		static public DataTable CountriesList()
		{
			return PeopleData.GetCountriesList();
		}

		
	}
}
