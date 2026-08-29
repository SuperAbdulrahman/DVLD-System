using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License.Controls
{
    public partial class ctrlDriverLicenseInfocard : UserControl
    {
        private int _LicenseID;
        private DVLD_Business.License _License;

        public DVLD_Business.License LicenseInfo
        {
            get { return _License; }
        }
        public ctrlDriverLicenseInfocard()
        {
            InitializeComponent();
        }

        public bool LoadDriverLicenseInfoByLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = DVLD_Business.License.FindByLicenseID(_LicenseID);

            if (_License == null)
            {
                ResetDriverLicenseCardInfo();
                MessageBox.Show("No License Found with LicenseID = " + _LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _FillDriverLicenseCardInfo();
            return true;
        }
        public bool LoadDriverLicenseInfoByAppID(int AppID)
        {
            
            _License = DVLD_Business.License.FindByApplicationID(AppID);

            if (_License == null)
            {
                ResetDriverLicenseCardInfo();
                MessageBox.Show("No License Found for Application with ID = " + AppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _LicenseID = _License.LicenseID;
            _FillDriverLicenseCardInfo();
            return true;
        }
        private void ResetDriverLicenseCardInfo()
        {
            lblClassValue.Text = "??";
            lblNameValue.Text = "??";
            lblLicenseIDValue.Text = "??";
            lblNationalNoValue.Text = "??";
            lblGenderValue.Text = "??";
            lblIssueDateValue.Text = "??";
            lblIssueReasonValue.Text = "??";
            lblNotesValue.Text = "??";
            lblIsActiveValue.Text = "??";
            lblDOBValue.Text = "??";
            lblDriverIDValue.Text = "??";
            lblExpirationDateValue.Text = "??";
            lblIsDetainedValue.Text = "??";

            pbImage.Image = Resources.Male_512;

        }
        private void _LoadPersonImage()
        {
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            if (string.IsNullOrEmpty(ImagePath))
            {
                if (lblGenderValue.Text == "Male")
                    pbImage.Image = Resources.Male_512;
                else
                    pbImage.Image = Resources.Female_512;
                return;
            }

            if (File.Exists(ImagePath))
                pbImage.ImageLocation = ImagePath;
            else
                MessageBox.Show($"Could not find this image: = {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillDriverLicenseCardInfo()
        {
            lblClassValue.Text = _License.LicenseClassInfo.Name;
            lblNameValue.Text = _License.DriverInfo.PersonInfo.FullName;
            lblLicenseIDValue.Text = _License.LicenseID.ToString();
            lblNationalNoValue.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGenderValue.Text = (_License.DriverInfo.PersonInfo.Gender)? "Female" : "Male";
            lblIssueDateValue.Text = _License.IssueDate.ToString();
            lblIssueReasonValue.Text = _License.IssueReason.ToString();
            lblNotesValue.Text = _License.Notes ?? "N/A";
            lblIsActiveValue.Text = (_License.IsActive) ? "Yes" : "No";
            lblDOBValue.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
            lblDriverIDValue.Text = _License.DriverID.ToString();
            lblExpirationDateValue.Text = _License.ExpirationDate.ToString();

            lblIsDetainedValue.Text = _License.IsLicenseDetained()!=-1? "Yes" : "No";

            _LoadPersonImage();
        }

    }
}
