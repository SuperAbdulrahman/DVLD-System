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
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID = -1;
        private DVLD_Business.License _LicenseInfo;
        private DetainedLicense _DetainedLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _FillAppInfo();
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
        }
        private void _FillAppInfo()
        {

            lblDetainDateValue.Text = DateTime.Now.ToString();
            lblCreatedByValue.Text = SessionInfo.currentUser.UserName;

        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseInfo = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;
            lliShowLicenseHistory.Enabled = true;
            _LicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;
            lblLicenseID.Text = _LicenseID.ToString();

            btnDetain.Enabled = true;
        }

        private bool _HandleDetainProcess()
        {
            // Fill needed info:
            _DetainedLicense = new DetainedLicense();
            _DetainedLicense.FineFees = numericUpDownFees.Value;
            bool isSaved = false;
            var result = _LicenseInfo.Detain(_DetainedLicense,SessionInfo.currentUser.UserID);
            switch (result)
            {
                case DVLD_Business.License.enDetainLicenseValidation.Success:
                    isSaved = true;
                    break;
                case DVLD_Business.License.enDetainLicenseValidation.LicenseInactive:
                    MessageBox.Show("Selected License is inactive !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enDetainLicenseValidation.LicenseDetained:
                    MessageBox.Show("Selected License is already detained, Plese request a release application first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DVLD_Business.License.enDetainLicenseValidation.SaveFaild:
                    MessageBox.Show("Detained License was not saved, Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }

            return isSaved;
        }


        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;


            if (_HandleDetainProcess())
            {
                MessageBox.Show("License was detained successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDetainDateValue.Text =_DetainedLicense.DetainID.ToString();
                lliShowLicenseInfo.Enabled = true;
                btnDetain.Enabled = false;
                gbDetainInfo.Enabled = false;
            
            }
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
