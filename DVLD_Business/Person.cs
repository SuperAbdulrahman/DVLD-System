using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class Person
    {
        enum enMode { AddNew,Update}
        private enMode Mode;
        public int PersonID {
            get;  private set; 
        }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ").Trim(); }
        }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public Country CountryInfo;

        public Person()
        {
            PersonID = 0;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = false; 
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = 0;
            ImagePath = string.Empty;

            Mode = enMode.AddNew;

        }
        private Person(int ID,  string nationalNo,  string firstName,  string secondName,  string thirdName,  string lastName,
 DateTime DOB, bool  gender,  string address,  string phone,  string email,  int nationalityCountryID,  string imagePath)
        {
            this.PersonID = ID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = DOB;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            this.CountryInfo = Country.Find(nationalityCountryID);
            this.Mode = enMode.Update;
        }
        
        public static Person Find(int personID)
        {
            int nationalityCountryID = 0;
            bool gender = false;
            DateTime DOB = DateTime.MinValue;
            string nationalNo ="",firstName = "", secondName = "", thirdName = "", lastName = "",
            address = "", email = "", phone = "", imagePath = "";
            

            if(PersonDataAccess.GetPerson(personID,ref nationalNo,ref firstName,ref secondName,ref thirdName,ref lastName,ref DOB,ref gender, ref address, 
                ref phone, ref email,ref nationalityCountryID, ref imagePath))
            {
                return new Person(personID,nationalNo,firstName,secondName,thirdName,lastName,DOB,gender,address,phone,email,nationalityCountryID,imagePath);
            }
            return null;
        }
        public static Person Find(string nationalNo)
        {
            int personID =0, nationalityCountryID = 0;
            bool gender = false;
            DateTime DOB = DateTime.MinValue;
            string firstName = "", secondName = "", thirdName = "", lastName = "",
            address = "", email = "", phone = "", imagePath = "";


            if (PersonDataAccess.GetPerson(ref personID, nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref DOB, ref gender, ref address,
                ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new Person(personID, nationalNo, firstName, secondName, thirdName, lastName, DOB, gender, address, phone, email, nationalityCountryID, imagePath);
            }
            return null;
        }
        public static bool IsPersonExist(int personID)
        {
            return PersonDataAccess.IsPersonExist(personID);
        }
        public static bool IsPersonExist(string nationalNo)
        {
            return PersonDataAccess.IsPersonExist(nationalNo);
        }

        public bool _AddNewPerson()
        {
            PersonID  = PersonDataAccess.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return (PersonID!=-1);       
        }
        public bool _UpdatePersonInfo()
        {
            return (PersonDataAccess.UpdatePersonInfo(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath));
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
              
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePersonInfo();

            }
            return false;
        }
        public static DataTable GetAllPeople()
        {
            return PersonDataAccess.GetAllPeople();
        }
        public static DataTable GetAllPeopleWithCountryName()
        {
            return PersonDataAccess.GetAllPeopleWithCountryName();
        }
        public static bool DeletePerson(int personID)
        {
            return(PersonDataAccess.DeletePerson(personID));
        }

    }
}
