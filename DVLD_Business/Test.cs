using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class Test
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int TestID { get; private set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID {  get; set; }

        //private cache backing feilds:
        private User _createdByUserInfo;
        private TestAppointment _testAppointmentInfo;
        // instiniste the objects only when needed /called
        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && this.TestID != -1)
                {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                }
                return _createdByUserInfo;
            }
        }
        public TestAppointment TestAppointmentInfo
        {
            get
            {
                if(_testAppointmentInfo ==null && this.TestID != -1)
                {
                    _testAppointmentInfo = TestAppointment.Find(TestAppointmentID);
                }
                return this._testAppointmentInfo;
            }
        }
        
        public Test()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }
        private Test(int testID,int testAppointmentID,bool testResult,string notes,int createdByUserID)
        {
            TestID=testID;
            TestAppointmentID=testAppointmentID;
            TestResult=testResult;
            Notes=notes;
            CreatedByUserID=createdByUserID;

            Mode = enMode.Update;
        }
        public static Test Find(int ID)
        {
            int testAppointmentID = -1;
            bool testResult = false;
            string notes = string.Empty;
            int createdByUserID = -1;

            if (TestDataAccess.GetTest(ID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID))
            {
                return new Test(ID, testAppointmentID, testResult, notes, createdByUserID);
            }

            return null;
        }

        public static bool Delete(int testID)
        {
            return TestDataAccess.Delete(testID);
        }

        private bool _AddNew()
        {
            TestID = TestDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (TestID != -1);
        }

        private bool _Update()
        {
            return TestDataAccess.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
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

        public static bool IsTestExist(int testID)
        {
            return TestDataAccess.IsTestExist(testID);
        }

        public static DataTable GetTests()
        {
            return TestDataAccess.GetTests();
        }
    }

}

