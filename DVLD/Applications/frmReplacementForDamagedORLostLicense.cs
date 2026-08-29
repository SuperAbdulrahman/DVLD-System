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

namespace DVLD.Applications
{
    public partial class frmReplacementForDamagedORLostLicense : Form
    {
        private int _OldLicenseID = -1;
        private DVLD_Business.License _OldLicenseInfo;
        private DVLD_Business.License _NewLicenseInfo;
        private ApplicationType _ApplicationType =ApplicationType.Find((int)ApplicationType.enApplicationType.ReplaceDamagedDrivingLicense);

        public frmReplacementForDamagedORLostLicense()
        {
            InitializeComponent();
        }
        private void frmReplacementForDamagedORLostLicense_Load(object sender, EventArgs e)
        {
            _FillAppInfo();
        }

        private void _FillAppInfo()
        {

            lblAppDateValue.Text = DateTime.Now.ToString();
            lblAppFeesValue.Text = _ApplicationType.ApplicationFees.ToString();
            lblCreatedByValue.Text = SessionInfo.currentUser.UserName;

        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to replace this license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;


            if (_HandleReplacementProcess())
            {
                MessageBox.Show("License was Issued successfully! you can view it from license info", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblRIAppIDValue.Text = _NewLicenseInfo.ApplicationID.ToString();
                lblReplacedLostLicenseIDValue.Text = _NewLicenseInfo.LicenseID.ToString();
                lliShowLicenseInfo.Enabled = true;
                btnIssueReplacement.Enabled = false;
                gbReplacementFor.Enabled = false;
            }

        }
        private bool _HandleReplacementProcess()
        {
            bool isSaved = false;
            _NewLicenseInfo = new DVLD_Business.License();

            var result = _OldLicenseInfo.ReplaceDamgedLostLicense(_NewLicenseInfo,(ApplicationType.enApplicationType) _ApplicationType.ApplicationID, SessionInfo.currentUser.UserID);
            switch (result)
            {
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.Success:
                    isSaved = true;
                    break;
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.LicenseExpired:
                    MessageBox.Show("This license has expired. Please renew the license instead.", "License Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.LicenseInactive:
                    MessageBox.Show("Selected License is inactive!, Please renew the license instead!", "License inactive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.LicenseDetained:
                    MessageBox.Show("Selected License is detained, Plese request a release application first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.AppFaildToSave:
                    MessageBox.Show("Replacement Application faild to be saved! Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enReplaceDamgedLostValidationResult.SaveFaild:
                    MessageBox.Show("License was not saved, Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
          

            return isSaved;
        }
        private void rbReplacementFor_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDamgedLicense.Checked)
            {
                lblTitle.Text = "Replacement for Damaged License";
                _ApplicationType = ApplicationType.Find((int)ApplicationType.enApplicationType.ReplaceDamagedDrivingLicense);
            }
            else
            {
                lblTitle.Text = "Replacement for Lost License";
                _ApplicationType = ApplicationType.Find((int)ApplicationType.enApplicationType.ReplaceLostDrivingLicense);
            }
            lblAppFeesValue.Text = _ApplicationType.ApplicationFees.ToString() ;
            
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _OldLicenseInfo = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;
            lliShowLicenseHistory.Enabled = true;

            _OldLicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;
            lblOldLicenseIDValue.Text = _OldLicenseID.ToString();
            btnIssueReplacement.Enabled = true;
        }
        private void lliShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_OldLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void lliShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_NewLicenseInfo.LicenseID, frmDriverLicenseInfo.enMode.LicenseID);
            frm.ShowDialog();
        }


    }
}
