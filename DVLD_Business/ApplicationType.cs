using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class ApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ApplicationID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        public ApplicationType()

        {
            this.ApplicationID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
            Mode = enMode.AddNew;

        }

        public ApplicationType(int ID, string ApplicationTypeTitel, decimal ApplicationTypeFees)

        {
            this.ApplicationID = ID;
            this.ApplicationTypeTitle = ApplicationTypeTitel;
            this.ApplicationFees = ApplicationTypeFees;
            Mode = enMode.Update;
        }


        public static ApplicationType Find(int applicationID)
        {
            string applicationTypeTitle = "";
            decimal applicationFees = 0m;

            if (ApplicationTypesDataAccess.GetApplicationType(applicationID, ref applicationTypeTitle, ref applicationFees))
            {
                return new ApplicationType(applicationID, applicationTypeTitle, applicationFees);
            }
            return null;
        }
        private bool _AddNewApplicationType()
        {
            //call DataAccess Layer 

            this.ApplicationID = ApplicationTypesDataAccess.AddNewApplicationType(this.ApplicationTypeTitle, this.ApplicationFees);


            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplicationType()
        {

            return ApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypesDataAccess.GetApplictionTypes();

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplicationType();

            }

            return false;
        }


    }
}
