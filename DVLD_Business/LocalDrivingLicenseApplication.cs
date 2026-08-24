using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class LocalDrivingLicenseApplication :Application
    {
        enum enMode { AddNew, Update }
        enum enLicenseClasses { SmallMotorcycle=1, HeavyMotorcycleLicense=2, Ordinarydrivinglicense=3,
            Commercial=4, Agricultural = 5, SmallAndMediumBus = 6, TruckAndHeavyVehicle = 7}

        private enMode Mode;
        public int LocalDirivingLicenseID {  get; private set; }
        public LicenseClass.enLicenseClasses LicenseClassID { get; set;}

        private LicenseClass _LDLLicenseClass;
        public LicenseClass LicenseClassInfo
        {
            get
            {
                if (_LDLLicenseClass == null && LocalDirivingLicenseID!=1) 
                    _LDLLicenseClass = LicenseClass.Find((int)LicenseClassID);
                return _LDLLicenseClass;
            }

        }


        public LocalDrivingLicenseApplication():base()
        {
            LocalDirivingLicenseID = -1;
            LicenseClassID = LicenseClass.enLicenseClasses.Ordinarydrivinglicense;
            
            Mode = enMode.AddNew;
        }
        private LocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int licenseClassID, int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, enApplicationStatus status, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
            : base(applicationID, applicantPersonID, applicationDate, applicationTypeID, status, lastStatusDate, paidFees, createdByUserID)
        {
            this.LocalDirivingLicenseID = localDrivingLicenseApplicationID;
            this.LicenseClassID = (LicenseClass.enLicenseClasses)licenseClassID;


            this.Mode = enMode.Update;
        }

        public static LocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationByLocalAppID(int id)
        {
            int applicationID = -1, licenseClass = -1;
            bool isFound = LocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationByID(id, ref applicationID, ref licenseClass);
            if (isFound )
            {
                //Find the base application data
                Application baseApp = FindBaseApplication(applicationID);
                if (baseApp == null)
                    return null;
                //Return the full object
                return new LocalDrivingLicenseApplication(id,licenseClass,applicationID,baseApp.ApplicantPersonID,baseApp.ApplicationDate
                    ,baseApp.ApplicationTypeID,baseApp.Status,baseApp.LastStatusDate,baseApp.PaidFees,baseApp.CreatedByUserID);
            }
            return null;
 
        }
        public static LocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationByApplicationID(int appID)
        {
            int localAppID = -1, licenseClass = -1;
            bool isFound = LocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationByApplicationID(appID, ref localAppID, ref licenseClass);
            if(isFound ) 
            {
                //Find the base application data
                Application baseApp = FindBaseApplication(appID);
                if (baseApp == null)
                    return null;
                //Return the full object
                return new LocalDrivingLicenseApplication(localAppID, licenseClass, appID, baseApp.ApplicantPersonID, baseApp.ApplicationDate
                    , baseApp.ApplicationTypeID, baseApp.Status, baseApp.LastStatusDate, baseApp.PaidFees, baseApp.CreatedByUserID);
            }
            return null;

        }
        public bool _AddNewLocalDrivingLicenseApp()
        {
            LocalDirivingLicenseID= LocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID,(int)this.LicenseClassID);
            return (LocalDirivingLicenseID !=-1);
        }
        public bool _UpdateLocalDrivingLicenseApp()
        {
            return LocalDrivingLicenseApplicationsDataAccess.UpdateLocalDrivingLicenseApplication(this.LocalDirivingLicenseID, this.ApplicationID, (int)this.LicenseClassID);
        }

        public bool Save()
        {
            // Step 1: Save the base Application record first
            base.Mode = (Application.enMode)this.Mode;
            if (!base.Save())
                return false;

            // Step 2: Save the Local Driving License Application record using the generated this.ApplicationID
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApp())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApp();

                default:
                    break;
            }
            return false;
        }
        public static DataTable GetAllLocalDrivingLicensApplications()
        {
            return LocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicensApplications();
        }

        public static int GetActiveLocalDrivingLicenseApplicationID(int personID, int licenseClassID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.GetActiveLocalDrivingLicenseApplicationID(personID,licenseClassID);
        }

        public static byte TotalPassedTests(int LDLAppID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.TotalPassedTests(LDLAppID);
        }
        public static byte TotalTrialsPerTest(int LDLAppID,TestType.enTestType TestType)
        {
            return LocalDrivingLicenseApplicationsDataAccess.TotalTrialsPerTest(LDLAppID, (int)TestType);
        }

        public bool DoesPassTestType(TestType.enTestType TestType)
        {
            return LocalDrivingLicenseApplicationsDataAccess.DoesPassTestType(this.LocalDirivingLicenseID, (int)TestType);
        }
        // Inside LocalDrivingLicenseApplication BLL:
        public bool DoesPassPreviousTest(TestType.enTestType currentTestType)
        {
            switch (currentTestType)
            {
                case TestType.enTestType.VisionTest:
                    return true; // No prerequisite for Vision

                case TestType.enTestType.WrittenTest:
                    return this.DoesPassTestType(TestType.enTestType.VisionTest);

                case TestType.enTestType.StreetTest:
                    return this.DoesPassTestType(TestType.enTestType.WrittenTest);

                default:
                    return false;
            }
        }
    }
}
