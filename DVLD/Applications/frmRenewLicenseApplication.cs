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
    public partial class frmRenewLicenseApplication : Form
    {
        private int _OldLicenseID = -1;
        private DVLD_Business.License _OldLicenseInfo;
        private DVLD_Business.License _NewLicenseInfo;

        private ApplicationType _ApplicationType = ApplicationType.Find((int)ApplicationType.enApplicationType.RenewDrivingLicense);
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }
        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillAppInfo();
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
        }
        private void _FillAppInfo()
        {

            lblAppDateValue.Text = DateTime.Now.ToString();
            lblIssueDateValue.Text = DateTime.Now.ToString();
            lblAppFeesValue.Text = _ApplicationType.ApplicationFees.ToString();
            //lblExperationDateValue.Text = DateTime.Now.AddYears().ToString();
            lblCreatedByValue.Text = SessionInfo.currentUser.UserName;


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _OldLicenseInfo = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;
            lliShowLicenseHistory.Enabled = true;

            if(!_OldLicenseInfo.IsExpired())
            {
                MessageBox.Show($"Selected License is not yet expired , it will expire in: {_OldLicenseInfo.ExpirationDate}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbRenewLicenseApplicationInfo.Enabled = false;
                return;
            }

            _OldLicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;
            lblOldLicenseIDValue.Text = _OldLicenseID.ToString();
            lblLicenseFeesValue.Text = _OldLicenseInfo.LicenseClassInfo.Fees.ToString();
            lblTotalFeesValue.Text = (_ApplicationType.ApplicationFees + _OldLicenseInfo.LicenseClassInfo.Fees).ToString();
            lblExperationDateValue.Text = DateTime.Now.AddYears(_OldLicenseInfo.LicenseClassInfo.ValidityLength).ToString();


            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;
            

            if (_HandleRenewProcess())
            {
                MessageBox.Show("License was Issued successfully! you can view it from license info", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblRIAppIDValue.Text = _NewLicenseInfo.ApplicationID.ToString();
                lblRenewedLicenseIDValue.Text = _NewLicenseInfo.LicenseID.ToString();
                lliShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;

            }


        }

        private bool _HandleRenewProcess()
        {
            bool isSaved = false;
            _NewLicenseInfo = new DVLD_Business.License();
            _NewLicenseInfo.Notes = txtNotes.Text ?? string.Empty;
            var result = _OldLicenseInfo.Renew(_NewLicenseInfo,SessionInfo.currentUser.UserID);
            switch (result)
            {
                case DVLD_Business.License.enRenewLicenseValidationResult.Success:
                    isSaved = true;
                    break;
                case DVLD_Business.License.enRenewLicenseValidationResult.LicenseExpired:
                    MessageBox.Show("Selected License has not expired yet !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enRenewLicenseValidationResult.LicenseDetained:
                    MessageBox.Show("Selected License is detained, Plese request a release application first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enRenewLicenseValidationResult.ThereIsAnActiveRenwedLicenseFromTheSameClass:
                    MessageBox.Show("There is an active renwed license from this license class!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DVLD_Business.License.enRenewLicenseValidationResult.AppFaildToSave:
                    MessageBox.Show("Renew Application faild to be saved! Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enRenewLicenseValidationResult.SaveFaild:
                    MessageBox.Show("License was not saved, Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }


            return isSaved;
        }
        private void lliShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_OldLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void lliShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_NewLicenseInfo.LicenseID,frmDriverLicenseInfo.enMode.LicenseID);
            frm.ShowDialog();
        }
    }
}
