using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class TestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public enTestType TestTypeID { get; private set; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }


        public TestType()

        {
            this.TestTypeID = enTestType.VisionTest;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0;
            Mode = enMode.AddNew;

        }

        private TestType(enTestType ID, string TestTypeTitel, string TestTypeDescription, decimal TestTypeFees)

        {
            this.TestTypeID = ID;
            this.TestTypeTitle = TestTypeTitel;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            Mode = enMode.Update;
        }

        public static TestType Find(enTestType testTypeID)
        {
            string testTypeTitle = "";
            string testTypeDescription = "";
            decimal testTypeFees = 0m;

            if (TestTypeDataAccess.GetTestType((int)testTypeID, ref testTypeTitle, ref testTypeDescription, ref testTypeFees))
            {
                return new TestType(testTypeID, testTypeTitle, testTypeDescription, testTypeFees);
            }

            return null;
        }
        private bool _AddNewTestType()
        {
            //call DataAccess Layer

            this.TestTypeID = (enTestType)TestTypeDataAccess.AddNewTestType(
                this.TestTypeTitle,
                this.TestTypeDescription,
                this.TestTypeFees
            );


            return ((int)this.TestTypeID != -1);
        }
        private bool _UpdateTestType()
        {
            return TestTypeDataAccess.UpdateTestType(
                (int)this.TestTypeID,
                this.TestTypeTitle,
                this.TestTypeDescription,
                this.TestTypeFees
            );
        }
        public static DataTable GetAllTestTypes()
        {
            return TestTypeDataAccess.GetTestTypes();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return _UpdateTestType();

            }

            return false;
        }


    }
}
