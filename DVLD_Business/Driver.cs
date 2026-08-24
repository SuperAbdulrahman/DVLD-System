using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class Driver
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int DriverID { get; private set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        private Person _personInfo;
        private User _createdByUserInfo;

        // instiniste the objects only when needed /called
        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && this.DriverID != -1)
                {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                }
                return _createdByUserInfo;
            }
        }

        public Person PersonInfo
        {
            get
            {
                if (_personInfo == null && this.DriverID != -1)
                {
                    _personInfo = Person.Find(PersonID);
                }
                return _personInfo;
            }
        }

        public Driver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private Driver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;

            Mode = enMode.Update;
        }

        public static Driver Find(int ID)
        {
            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.MinValue;

            if (DriverDataAccess.GetDriver(ID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new Driver(ID, personID, createdByUserID, createdDate);
            }

            return null;
        }

        public static bool Delete(int driverID)
        {
            return DriverDataAccess.Delete(driverID);
        }

        private bool _AddNew()
        {
            DriverID = DriverDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID);

            return (DriverID != -1);
        }

        private bool _Update()
        {
            return DriverDataAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();

                default:
                    break;
            }

            return false;
        }

        public static bool IsDriverExist(int driverID)
        {
            return DriverDataAccess.IsDriverExist(driverID);
        }
        public static int GetDriverIDForPerson(int personID)
        {
            return DriverDataAccess.GetDriverIDForPerson(personID);
        }
        public static DataTable GetDrivers()
        {
            return DriverDataAccess.GetDrivers();
        }




    }
}
