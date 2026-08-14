using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class User
    {
        enum enMode { AddNew, Update }
        private enMode Mode;
        public int UserID
        {
            get; private set;
        }
        public int PersonID
        { get;  set; }
        public string UserName
        { get;  set; }
        public string Password 
        { get; set; }
        public bool IsActive
        { get;  set; }
        public Person Person { get; private set; }

        public User(int personID)
        {
            this.UserID = -1;
            this.PersonID = personID;

            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            // This add unecessary lookup
           // this.Person = Person.Find(personID);
            this.Mode = enMode.AddNew;
        }
        private User(int userID,int personID,string username,string password,bool isActive)

        {
            this.UserID = userID;
            this.UserName = username;
            this.Password = password;
            this.IsActive = isActive;
            this.PersonID = personID;
            this.Person = Person.Find(personID);
            Mode = enMode.Update;
        }

        public static User Find(int userID)
        {
            string username = "", password = "";
            bool isActive = false;
            int personID = 0;

            if(UserDataAccess.GetUser(userID,ref personID,ref username,ref password,ref isActive))
            {
                return new User(userID,personID,username,password,isActive);
            }
            return null;
        }
        public static User Find(string username)
        {
            string password = "";
            bool isActive = false;
            int userID=0, personID = 0;

            if (UserDataAccess.GetUser(ref userID, ref personID, username, ref password, ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }
            return null;
        }
        public static User FindByPersonID(int personID)
        {
            int userID = 0;
            string username = "", password = "";
            bool isActive = false;

            if (UserDataAccess.GetUserByPersonID(personID, ref userID, ref username, ref password, ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }
            return null;
        }
        public static User FindByUsernameAndPassword(string username, string password)
        {
            int userID = 0, personID = 0;
            bool isActive = false;

            if (UserDataAccess.GetUserByUsernameAndPassword(ref userID,ref personID,ref username,password,ref isActive))
            {
                return new User(userID, personID, username, password, isActive);
            }
            return null;
        }
        public static bool Delete(int userID)
        { 
            return UserDataAccess.Delete(userID);
        }
        private bool _AddNewUser()
        {
            //// Making sure a person exist before adding a new user
            //if (this.Person == null)
            //{
            //    return false;

            //}
            this.UserID= UserDataAccess.AddNewUser(this.PersonID,this.UserName,this.Password,this.IsActive);
            return (this.UserID > 0);
        }
        private bool _UpdateUserInfo()
        {
            return UserDataAccess.UpdateUserInfo(this.UserID,this.PersonID,this.UserName,this.Password,this.IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUserInfo();
  
                default:
                    break;
            }
            return false;
        }
        public static bool IsUserExist(int userID)
        {
            return UserDataAccess.IsUserExist(userID);
        }
        public static bool IsUserExist(string userName)
        {
            return UserDataAccess.IsUserExist(userName);
        }
        public static bool IsUserExistForPersonID(int personID)
        {
            return UserDataAccess.IsUserExistForPersonID(personID);
        }
        public static DataTable GetAllUsers()
        {
            return UserDataAccess.GetUsers();
        }
       
        // No need for it 
        //public static bool IsUserActive(string username)
        //{
        //    User user = Find(username);
        //    if (user == null)
        //    {
        //        return false;
        //    }
        //    return user.IsActive;
        //}

    }
}
