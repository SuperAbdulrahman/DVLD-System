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
    public partial class ctrlDriverLicenseInternationalInfo : UserControl
    {
        private int _IntLicenseID = -1;
        private InternationalLicense _IntLicense;

        public InternationalLicense IntLicenseInfo
        {
            get { return _IntLicense; }
        }
        public ctrlDriverLicenseInternationalInfo()
        {
            InitializeComponent();
        }

        public bool LoadDriverIntLicenseInfoByLicenseID(int IntLicenseID)
        {
            _IntLicenseID = IntLicenseID;
            _IntLicense = InternationalLicense.Find(_IntLicenseID);

            if (_IntLicense == null)
            {
                ResetDriverIntLicenseCardInfo();
                MessageBox.Show("No Int License Found with LicenseID = " + _IntLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _FillDriverIntLicenseCardInfo();
            return true;
        }
        //public bool LoadDriverIntLicenseInfoByAppID(int AppID)
        //{

        //    _IntLicense = DVLD_Business.License.FindByApplicationID(AppID);

        //    if (_IntLicense == null)
        //    {
        //        ResetDriverLicenseCardInfo();
        //        MessageBox.Show("No License Found for Application with ID = " + AppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    _IntLicenseID = _IntLicense.InternationalLicenseID;
        //    _FillDriverIntLicenseCardInfo();
        //    return true;
        //}
        private void ResetDriverIntLicenseCardInfo()
        {

            lblNameValue.Text = "??";
            lblILLicenseIDValue.Text = "??";
            lblAppIDValue.Text = "??";
            lblLicenseIDValue.Text = "??";
            lblNationalNoValue.Text = "??";
            lblGenderValue.Text = "??";
            lblIssueDateValue.Text = "??";
            lblIsActiveValue.Text = "??";
            lblDOBValue.Text = "??";
            lblDriverIDValue.Text = "??";
            lblExpirationDateValue.Text = "??";

            pbImage.Image = Resources.Male_512;

        }
        private void _LoadPersonImage()
        {
            string ImagePath = _IntLicense.DriverInfo.PersonInfo.ImagePath;
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
        private void _FillDriverIntLicenseCardInfo()
        {
            lblNameValue.Text = _IntLicense.DriverInfo.PersonInfo.FullName;
            lblILLicenseIDValue.Text = _IntLicense.InternationalLicenseID.ToString();
            lblAppIDValue.Text = _IntLicense.ApplicationID.ToString();
            lblLicenseIDValue.Text = _IntLicense.IssuedUsingLicenseID.ToString();
            lblNationalNoValue.Text = _IntLicense.DriverInfo.PersonInfo.NationalNo;
            lblGenderValue.Text = (_IntLicense.DriverInfo.PersonInfo.Gender) ? "Female" : "Male";
            lblIssueDateValue.Text = _IntLicense.IssueDate.ToString();
            lblIsActiveValue.Text = (_IntLicense.IsActive) ? "Yes" : "No";
            lblDOBValue.Text = _IntLicense.DriverInfo.PersonInfo.DateOfBirth.ToString();
            lblDriverIDValue.Text = _IntLicense.DriverID.ToString();
            lblExpirationDateValue.Text = _IntLicense.ExperationDate.ToString();

            _LoadPersonImage();
        }
        private void ctrlInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

        }

    }
}
