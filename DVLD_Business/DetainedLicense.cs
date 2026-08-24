using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class DetainedLicense
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int DetainID { get; set; }
        public int LicneseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        private License _licenseInfo;
        private User _createdByUserInfo;
        private User _releasedByUserInfo;
        private Application _releaseApplicationInfo;

        // instiniste the objects only when needed /called
        public License LicenseInfo
        {
            get
            {
                if (_licenseInfo == null && this.DetainID != -1 && this.LicneseID != -1)
                {
                    _licenseInfo = License.FindByLicenseID(LicneseID);
                }
                return _licenseInfo;
            }
        }
        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && this.DetainID != -1 && this.CreatedByUserID != -1)
                {
                    _createdByUserInfo = User.Find(CreatedByUserID);
                }
                return _createdByUserInfo;
            }
        }
        public User ReleasedByUserInfo
        {
            get
            {
                if (_releasedByUserInfo == null && this.DetainID != -1 && this.ReleasedByUserID != -1)
                {
                    _releasedByUserInfo = User.Find(ReleasedByUserID);
                }
                return _releasedByUserInfo;
            }
        }
        public Application ReleaseApplicationInfo
        {
            get
            {
                if (_releaseApplicationInfo == null && this.DetainID != -1 && this.ReleaseApplicationID != -1)
                {
                    _releaseApplicationInfo = Application.FindBaseApplication(ReleaseApplicationID);
                }
                return _releaseApplicationInfo;
            }
        }


        public DetainedLicense()
        {
            DetainID = -1;
            LicneseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }
        private DetainedLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            DetainID = detainID;
            LicneseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;

            Mode = enMode.Update;
        }

        public static DetainedLicense Find(int ID)
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MinValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (DetainedLicenseDataAccess.GetDetainedLicense(ID, ref licenseID, ref detainDate, ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new DetainedLicense(ID, licenseID, detainDate, fineFees, createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }

        public static DataTable GetDetainedLicenses()
        {
            return DetainedLicenseDataAccess.GetDetainedLicenses();
        }

        public static bool Delete(int detainID)
        {
            return DetainedLicenseDataAccess.Delete(detainID);
        }

        private bool _AddNew()
        {
            DetainID = DetainedLicenseDataAccess.AddNewDetainedLicense(this.LicneseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (DetainID != -1);
        }

        private bool _Update()
        {
            return DetainedLicenseDataAccess.UpdateDetainedLicense(this.DetainID, this.LicneseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
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

        public static bool IsDetainedLicenseExist(int detainID)
        {
            return DetainedLicenseDataAccess.IsDetainedLicenseExist(detainID);
        }


    }
}
