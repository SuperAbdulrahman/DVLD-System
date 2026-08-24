using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class InternationalLicense
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLicenseID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExperationDate { get; set; }
        public bool IsActive { get; set; }
   
        public short ValidityLength { get; set; }

        //Cashe feilds :
        private User _createdByUserInfo;
        private Application _applicationInfo;
        private Driver _driverInfo;
        private License _licenseInfo;
        // instiniste the objects only when needed /called

        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && this.CreatedByUserID != -1)
                {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                }
                return _createdByUserInfo;
            }
        }
        public Application ApplicationInfo
        {
            get
            {
                if (_applicationInfo == null && this.ApplicationID != -1)
                {
                    _applicationInfo = Application.FindBaseApplication(this.ApplicationID);
                }
                return _applicationInfo;
            }
        }
        public Driver DriverInfo
        {
            get
            {
                if (_driverInfo == null && this.DriverID != -1)
                    _driverInfo = Driver.Find(DriverID);
                return _driverInfo;
            }
        }
        public License LicenseInfo
        {
            get
            {
                if (_licenseInfo == null && IssuedUsingLicenseID != -1)
                    _licenseInfo = License.FindByLicenseID(IssuedUsingLicenseID);
                return _licenseInfo;
            }
        }

        public InternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLicenseID = -1;
            IssueDate = DateTime.Now;
            ExperationDate = DateTime.MinValue;
            IsActive = false;

            Mode = enMode.AddNew;
        }
        private InternationalLicense(int internationalLicenseID, int applicationID, int driverID, int issuedUsingLicenseID, int createdByUserID, DateTime issueDate, DateTime experationDate, bool isAtive)
        {

            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLicenseID = issuedUsingLicenseID;
            CreatedByUserID = createdByUserID;
            IssueDate = issueDate;
            ExperationDate = experationDate;
            IsActive = isAtive;

            Mode = enMode.Update;
        } 

        public static InternationalLicense Find(int internationalLicenseID)
        {
            int appID = 0, driverID = 0, issuedUsingLicenseID = 0, createdByUserID = 0;
            DateTime issueDate = DateTime.Now, experationDate = DateTime.MinValue;
            bool isActive = false;
            if(InternationalLicenseDataAccess.GetInternationalLicenseByInternationalLicenseID(internationalLicenseID,ref appID,ref driverID,
                ref issuedUsingLicenseID,ref issueDate,ref experationDate,ref isActive,ref createdByUserID))
            {
                return new InternationalLicense(internationalLicenseID,appID,driverID,issuedUsingLicenseID,createdByUserID,issueDate,experationDate,isActive);
            }
                
            return null;
        }
        public static bool IsInternationalLicenseExist(int internationalLicenseID)
        {
            return InternationalLicenseDataAccess.IsInternationalLicenseExist(internationalLicenseID);
        }
        private bool _Update()
        {
            return InternationalLicenseDataAccess.UpdateInternationalLicense(InternationalLicenseID,this.ApplicationID,this.DriverID,this.IssuedUsingLicenseID,this.ExperationDate,this.IsActive,this.CreatedByUserID);
        }
        private bool _AddNew()
        {
           
            IssueDate = DateTime.Now;
            ExperationDate = IssueDate.AddYears(ValidityLength);
            this.InternationalLicenseID = InternationalLicenseDataAccess.AddNewInternationalLicense(ApplicationID, DriverID, IssuedUsingLicenseID, IssueDate, ExperationDate, IsActive, CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }
        public static bool Delete(int internationalLicenseID)
        {
            return InternationalLicenseDataAccess.Delete(internationalLicenseID);
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
        public static DataTable GetInternationalLicensesByDriverID(int driverID)
        {
            return InternationalLicenseDataAccess.GetInternationalLicensesByDriverID(driverID);
        }
    }
}
