using DVLD.License;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Detain
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _LicenseID = -1;
        private DVLD_Business.License _LicenseInfo;
        private int _DetainID = -1;
        private DetainedLicense _DetainedLicense;
        private ApplicationType _ApplicationType = ApplicationType.Find((int)ApplicationType.enApplicationType.ReleaseDetainedDrivingLicsense);
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID!=-1)
            {
                ctrlDriverLicenseInfoWithFilter1.LoadByLicenseID(_LicenseID);
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            }

        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            lliShowLicenseHistory.Enabled = true;
            lliShowLicenseInfo.Enabled = true;
            _LicenseInfo = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;
            _DetainID = _LicenseInfo.IsLicenseDetained();
            if (_DetainID==-1)
            {
                MessageBox.Show($"Selected License is not detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DetainedLicense = DetainedLicense.Find(_DetainID);
            if( _DetainedLicense == null )
            {
                MessageBox.Show($"Could not find detained license record!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _LicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;
            lblLicenseIDValue.Text = _LicenseID.ToString();
            lblDetainIDValue.Text = _DetainedLicense.DetainID.ToString();
            lblDetainDateValue.Text = _DetainedLicense.DetainDate.ToString();
            lblCreatedByValue.Text = SessionInfo.currentUser.UserName;
            lblFineFeesValue.Text = _DetainedLicense.FineFees.ToString();
            lblAppFeesValue.Text = _ApplicationType.ApplicationFees.ToString();
            lblTotalFeesValue.Text = (_DetainedLicense.FineFees + _ApplicationType.ApplicationFees).ToString();
             

            btnRelease.Enabled = true;
        }


        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;


            if (_HandleReleaseProcess())
            {
                MessageBox.Show("License was released successfully! you can view it from license info", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblReleaseIDValue.Text = _DetainedLicense.ReleaseApplicationID.ToString();
                btnRelease.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                
            }
        }


        private bool _HandleReleaseProcess()
        {
            bool isSaved = false;
            var result = _LicenseInfo.Release(_DetainedLicense,SessionInfo.currentUser.UserID);
            switch (result)
            {
                case DVLD_Business.License.enReleaseLicenseValidation.Success:
                    isSaved = true;
                    break;
                case DVLD_Business.License.enReleaseLicenseValidation.LicenseNotDetained:
                    MessageBox.Show("Selected License is not detained!!", "License not detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReleaseLicenseValidation.AppFaildToSave:
                    MessageBox.Show("Release detained license application was not saved, Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReleaseLicenseValidation.SaveFaild:
                    MessageBox.Show("Release license was not saved, Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            return isSaved;

        }
        private void lliShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void lliShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseInfo.LicenseID, frmDriverLicenseInfo.enMode.LicenseID);
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
