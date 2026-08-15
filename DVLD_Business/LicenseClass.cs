using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class LicenseClass
    {
        enum enMode { AddNew, Update }
        private enMode Mode;
        public int ID { get; private set; }
        public string Name { get;  set; }
        public string Description { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte ValidityLength { get; set; }
        public decimal Fees { get; set; }


        public LicenseClass() { }
        public LicenseClass(int iD, string name, string description, byte minimumAllowedAge, byte validityLength, decimal fees)
        {
            ID = iD;
            Name = name;
            Description = description;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLength = validityLength;
            Fees = fees;

            Mode = enMode.Update;
        }

        public static LicenseClass Find(int ID)
        {
            string name = "", description = "";
            byte minimumAge = 0, validityLength = 0;
            decimal fees = 0;

            if(LicenseClassDataAccess.GetLicenseClass(ID,ref name,ref description,ref minimumAge,ref validityLength,ref fees))
            {
                return new LicenseClass(ID, name, description, minimumAge, validityLength, fees);
            }
            return null;
        }
        private bool _AddNewLicenseClass()
        {
            this.ID = LicenseClassDataAccess.AddNewLicenseClass(Name,Description, MinimumAllowedAge, ValidityLength,Fees);
            return (ID > 0);
        }
        private bool _UpdateLicenseClassInfo()
        {
            return LicenseClassDataAccess.UpdateLicenseClass(ID,Name,Description, MinimumAllowedAge,ValidityLength,Fees);
        }

        public static DataTable GetLicenseClasses()
        {
            return LicenseClassDataAccess.GetLicenseClasses();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLicenseClassInfo();

                default:
                    break;
            }
            return false;
        }
    }
}
