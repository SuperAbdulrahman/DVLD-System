using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.Application;

namespace DVLD_Business
{
    public class Application
    {
        enum enMode { AddNew,Update }
        public enum enApplicationStatus {New =1,Cancelled =2, Completed=3 }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        private enMode Mode;

        public int ID { get; private set; }
        public int ApplicantPersonID { get;  set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus Status {  get; set; }
        public string StatusText
        {
            get { return Status.ToString(); }
        }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        // Private cache backing fields
        private Person _applicantPersonInfo;
        private User _createdByUserInfo;
        private ApplicationType _applicationTypeInfo;
        // instiniste the objects only when needed /called
        public ApplicationType ApplicationTypeInfo
        {
            get
            {
                if (_applicationTypeInfo == null && this.ID != -1)
                {
                    _applicationTypeInfo= ApplicationType.Find(ApplicationTypeID);
                }
                return _applicationTypeInfo;
            }
        }
        public User CreatedByUserInfo
        { 

                get
                {
                    if (_createdByUserInfo == null && this.ID != -1)
                    {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                    }
                    return _createdByUserInfo;
                }
            }
        public Person ApplicantInfo 
        {
            get
            {
                if(_applicantPersonInfo == null && this.ID != -1)
                {
                    _applicantPersonInfo = Person.Find(ApplicantPersonID);
                }
                return _applicantPersonInfo;
            }
        }


        public Application()
        {
            ID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            Status = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0m;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }
        public Application(int id, int applicantID,DateTime Date,int TypeID,enApplicationStatus status
            ,DateTime lastStatusDate,decimal paidFees, int createdByUserID)
        {
            ID = id;
            ApplicantPersonID= applicantID;
            ApplicationDate = Date;
            ApplicationTypeID = TypeID;
            Status = status;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;

            Mode = enMode.Update;
        }

        public static Application Find(int applicationID)
        {
            int applicantPersonID = 0, applicationTypeID = 0,createdByUserID = 0;
            DateTime applicationDate = DateTime.MinValue, lastStatusDate = DateTime.Now;
            byte status = (byte)enApplicationStatus.New;
            decimal paidFees = 0;
            
            if(ApplicationDataAccess.GetApplication(applicationID, ref applicantPersonID,ref applicationDate,ref applicationTypeID, ref status,
                ref lastStatusDate,ref paidFees,ref createdByUserID))
            {
                return new Application(applicationID, applicantPersonID, applicationDate, applicationTypeID, (enApplicationStatus)status,
                 lastStatusDate, paidFees, createdByUserID);
            }
            return null;
        }
        
        private bool _AddNewApplication()
        {
            this.ID= ApplicationDataAccess.AddNewApplication(this.ApplicantPersonID,this.ApplicationDate,this.ApplicationTypeID,(byte)this.Status,this.LastStatusDate,this.PaidFees,this.CreatedByUserID);
            return (ID >0);
        }
        private bool _UpdateApplication()
        {
            return ApplicationDataAccess.UpdateApplicationInfo(this.ID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.Status, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public static bool Delete(int applicationID)
        {
            return ApplicationDataAccess.Delete(applicationID);
        }

        public bool Cancel()
        {
            return ApplicationDataAccess.UpdateStatus(ID, (short)enApplicationStatus.Cancelled);
        }
        public bool SetComplete()
        {
            return ApplicationDataAccess.UpdateStatus(ID, (short)enApplicationStatus.Completed);
        }
        public static bool IsApplicationExist(int applicationID)
        {
            return ApplicationDataAccess.IsApplicationExist(applicationID);
        }
        public static bool DoesPersonHaveActiveApplication(int personID, enApplicationType ApplicationTypeID)
        {
            return ApplicationDataAccess.DoesPersonHaveActiveApplication(personID,(int)ApplicationTypeID);
        }
        public bool DoesPersonHaveActiveApplication(enApplicationType ApplicationTypeID)
        {
            return ApplicationDataAccess.DoesPersonHaveActiveApplication(this.ApplicantPersonID, (int)ApplicationTypeID);
        }
        public static int GetActiveApplicationID(int PersonID, enApplicationType ApplicationTypeID)
        {
            return ApplicationDataAccess.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }
        public int GetActiveApplicationID( enApplicationType ApplicationTypeID)
        {
            return ApplicationDataAccess.GetActiveApplicationID(this.ApplicantPersonID,(int)ApplicationTypeID);
        }
        public static int GetActiveApplicationIDForLicenseClass(int personID, enApplicationType ApplicationTypeID, int licenseClassID)
        {
            return ApplicationDataAccess.GetActiveApplicationIDForLicenseClass(personID, (int)ApplicationTypeID, licenseClassID);
        }
        public static DataTable GetApplications()
        {
            return ApplicationDataAccess.GetApplications();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();

                default:
                    break;
            }
            return false;
        }

    }
}
