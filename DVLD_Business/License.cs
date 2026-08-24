using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class License
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 }

        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public LicenseClass.enLicenseClasses LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID;

        //Cashe feilds :
        private User _createdByUserInfo;
        private Application _applicationInfo;
        private Driver _driverInfo;
        private LicenseClass _licenseClass;
        // instiniste the objects only when needed /called

        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && this.ApplicationID != -1)
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
                if (_applicationInfo == null && this.LicenseID != -1)
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
                if (_driverInfo == null && this.LicenseID != -1)
                    _driverInfo = Driver.Find(DriverID);
                return _driverInfo;
            }
        }

        public LicenseClass LicenseClassInfo
        {
            get
            {
                if (_licenseClass == null)
                    _licenseClass = LicenseClass.Find((int)LicenseClassID);
                return _licenseClass;
            }
        }

        public License()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = LicenseClass.enLicenseClasses.SmallMotorcycle;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = false;
            IssueReason = enIssueReason.FirstTime;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private License(int licenseID, int applicationID, int driverID,
            LicenseClass.enLicenseClasses licenseClassID, DateTime issueDate,
            DateTime expirationDate, string notes, decimal paidFees,
            bool isActive, enIssueReason issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassID = licenseClassID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;

            Mode = enMode.Update;
        }

        public static License FindByLicenseID(int ID)
        {
            int applicationID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = -1;
            int createdByUserID = -1;

            if (LicenseDataAccess.GetLicenseByLicenseID(ID, ref applicationID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive,
                ref issueReason, ref createdByUserID))
            {
                return new License(ID, applicationID, driverID,
                    (LicenseClass.enLicenseClasses)licenseClass, issueDate,
                    expirationDate, notes, paidFees, isActive,
                    (enIssueReason)issueReason, createdByUserID);
            }

            return null;
        }
        public static License FindByApplicationID(int AppID)
        {
            int licenseID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = -1;
            int createdByUserID = -1;

            if (LicenseDataAccess.GetLicenseByAppID(ref licenseID,  AppID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive,
                ref issueReason, ref createdByUserID))
            {
                return new License(licenseID, AppID, driverID,
                    (LicenseClass.enLicenseClasses)licenseClass, issueDate,
                    expirationDate, notes, paidFees, isActive,
                    (enIssueReason)issueReason, createdByUserID);
            }

            return null;
        }


        public static bool Delete(int licenseID)
        {
            return LicenseDataAccess.Delete(licenseID);
        }

        private bool _AddNew()
        {
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = IssueDate.AddYears(LicenseClassInfo.ValidityLength);

            LicenseID = LicenseDataAccess.AddNewLicense(
                this.ApplicationID,
                this.DriverID,
                (int)this.LicenseClassID,
                this.IssueDate,
                this.ExpirationDate,
                this.Notes,
                this.PaidFees,
                this.IsActive,
                (int)this.IssueReason,
                this.CreatedByUserID);

            return (LicenseID != -1);
        }

        private bool _Update()
        {
            return LicenseDataAccess.UpdateLicense(
                this.LicenseID,
                this.ApplicationID,
                this.DriverID,
                (int)this.LicenseClassID,
                this.IssueDate,
                this.ExpirationDate,
                this.Notes,
                this.PaidFees,
                this.IsActive,
                (int)this.IssueReason,
                this.CreatedByUserID);
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

        public static bool IsLicenseExist(int licenseID)
        {
            return LicenseDataAccess.IsLicenseExist(licenseID);
        }
        public bool IsLicenseDetained()
        {
            return LicenseDataAccess.IsLicenseDetained(this.LicenseID);
        }
        public static int GetActiveLicenseIDByPersonID(int personID, int licenseClassID)
        {
            return LicenseDataAccess.GetActiveLicenseIDByPersonID(personID, licenseClassID);
        }

        public static DataTable GetLicenses()
        {
            return LicenseDataAccess.GetLicenses();
        }
        public static DataTable GetLicensesHistoryForDriver(int driverID)
        {
            return LicenseDataAccess.GetLicensesHistoryForDriver(driverID);
        }
    }
}
