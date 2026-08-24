using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class TestAppointment
    {
        private enum enMode { AddNew, Update }
   
        private enMode Mode;

        public int TestAppointmentID { get; private set; }
        public TestType.enTestType TestTypeID { get; set; }
        public int LDLAppID { get;  set; }
        public DateTime Date { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppID { get; set; }
        //private cache backing feilds:
        private TestType _testTypeInfo;
        private User _createdByUserInfo;
        private LocalDrivingLicenseApplication _LDLAppInfo;
        private Application _retakeAppInfo;
        // instiniste the objects only when needed /called
        public TestType TestTypeInfo
        {
            get
            {
                if (_testTypeInfo == null && TestAppointmentID != -1)
                {
                    _testTypeInfo = TestType.Find(TestTypeID);
                }
                return _testTypeInfo;
            }
        }
        public User CreatedByUserInfo
        {

            get
            {
                if (_createdByUserInfo == null && this.TestAppointmentID != -1)
                {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                }
                return _createdByUserInfo;
            }
        }
        public LocalDrivingLicenseApplication LDLAppInfo
        {
            get
            {
                if(_LDLAppInfo ==null && this.TestAppointmentID!=-1)
                {
                    _LDLAppInfo = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(LDLAppID);
                }
               return this._LDLAppInfo;
            }
        }
        public Application RetakeAppInfo
        {
            get
            {
                if (_retakeAppInfo == null && this.TestAppointmentID != -1)
                {
                    _retakeAppInfo = Application.FindBaseApplication(RetakeTestAppID);
                }
                return _retakeAppInfo;
            }
        }


        public TestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = TestType.enTestType.VisionTest;
            LDLAppID = -1;
            Date = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestAppID = -1;

            Mode = enMode.AddNew;
        }
        private TestAppointment(int ID,int testTypeID,int ldlAppID,DateTime date, decimal paidFees,
            int createdByUserID,bool isLocked,int retakeAppID)
        {
            TestAppointmentID = ID;
            TestTypeID = (TestType.enTestType)testTypeID;
            LDLAppID = ldlAppID;
            Date = date;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestAppID= retakeAppID;

            Mode = enMode.Update;
        }
 
        public static TestAppointment Find(int ID)
        {
            int testTypeID = -1,ldlAppID=-1 ,createdByUserID = -1, retakeAppID = -1;
            DateTime date = DateTime.Now;
            decimal paidFees = 0;
            bool isLocked = false;

            if(TestAppointmentDataAccess.GetTestAppointment(ID,ref testTypeID,ref ldlAppID,ref date,ref paidFees,
                ref createdByUserID,ref isLocked,ref retakeAppID))
            {
                return new TestAppointment(ID,testTypeID,ldlAppID,date,paidFees,createdByUserID,isLocked,retakeAppID);
            }

            return null;
        }
        public static bool Delete(int testAppointmentID)
        {
            return TestAppointmentDataAccess.Delete(testAppointmentID);
        }
        private bool _AddNew()
        {
            TestAppointmentID = TestAppointmentDataAccess.AddNewTestAppointment((int)this.TestTypeID, this.LDLAppID, this.Date,
                this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);

            return (TestAppointmentID !=-1);
        }
        private bool _Update()
        {
            return TestAppointmentDataAccess.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LDLAppID, this.Date, this.PaidFees,
                this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);
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
        public static int GetActiveTestAppointmentID(int ldlAppID,TestType.enTestType testType)
        {
            return TestAppointmentDataAccess.GetActiveTestAppointmentID(ldlAppID,(int)testType);
        }
        public static bool IsTestAppointmentExist(int testAppointmentID)
        {
            return TestAppointmentDataAccess.IsTestAppointmentExist(testAppointmentID);
        }
        public static bool IsTestAppointmentLocked(int testAppointmentID)
        {
            return TestAppointmentDataAccess.IsTestAppointmentLocked(testAppointmentID);
        }
        public static DataTable GetTestAppointments()
        {
            return TestAppointmentDataAccess.GetTestAppointments();
        }
        public static DataTable GetTestAppointmentsByLDLAppIDAndTestType(int localDrivingLicenseApplicationID, TestType.enTestType testType)
        {
            return TestAppointmentDataAccess.GetTestAppointmentsByLDLAppIDAndTestType(localDrivingLicenseApplicationID, (int)testType);
        }


    }
}
