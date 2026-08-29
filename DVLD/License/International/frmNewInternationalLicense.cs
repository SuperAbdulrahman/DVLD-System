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

namespace DVLD.License.International
{
    public partial class frmNewInternationalLicense : Form
    {
        private int _ILicenseID = -1;
        private InternationalLicense _ILicense = new InternationalLicense();

        private int _LocalLicenseID = -1;
        private DVLD_Business.License _LocalLicenseInfo;

        private ApplicationType _ApplicationType = ApplicationType.Find((int)ApplicationType.enApplicationType.NewInternationalLicense);
        private DVLD_Business.Application _ILicenseApplication;
        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            _FillAppInfo();
        }
        private void _FillAppInfo()
        {
            lblAppDateValue.Text = DateTime.Now.ToString();
            lblIssueDateValue.Text = DateTime.Now.ToString();
            lblFeesValue.Text = _ApplicationType.ApplicationFees.ToString();
            lblExperationDateValue.Text =DateTime.Now.AddYears(_ILicense.ValidityLength).ToString();
            lblCreatedByValue.Text = SessionInfo.currentUser.UserName;


        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LocalLicenseInfo = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;
            _LocalLicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;

            lblLocalLicenseIDValue.Text = _LocalLicenseID.ToString();
            lliShowLicenseHistory.Enabled = true;
            btnIssue.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want isee this license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            if (!_HandleInternationalLicenseConstraints())
                return;

            // Check if he got already an active international licnese
            int activeILicenseID = InternationalLicense.GetActiveInternationalLicenseIDByPersonID(_LocalLicenseInfo.DriverInfo.PersonID);
            if(activeILicenseID!=-1)
            {
                MessageBox.Show($"Person Already got an active international license with ID:{activeILicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // All Checks Passed then create a new application
            if(!_CreateNewILlicenseApplication())
            {
                MessageBox.Show("Faild to save international license application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_CreateNewILicense())
            {
                MessageBox.Show("License was Issued successfully! you can view it from license info", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIAppIDValue.Text = _ILicenseApplication.ApplicationID.ToString();
                lblILLicenseIDValue.Text = _ILicense.InternationalLicenseID.ToString();
                lliShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Faild to create international license! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

        }
        private bool _HandleInternationalLicenseConstraints()
        {
            bool isValid = false;
            var result = InternationalLicense.CanIssueFrom(_LocalLicenseInfo);
            switch (result)
            {
                case InternationalLicense.enLicenseValidationResult.Valid:
                    isValid = true;
                    break;
                case InternationalLicense.enLicenseValidationResult.LicenseNotActive:
                    MessageBox.Show("The license is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case InternationalLicense.enLicenseValidationResult.LicenseExpired:
                    MessageBox.Show("The license is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case InternationalLicense.enLicenseValidationResult.WrongLicenseClass:
                    MessageBox.Show("The license class is not valid for an international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            return isValid;
        }
        private bool _CreateNewILlicenseApplication()
        {
            _ILicenseApplication = new DVLD_Business.Application();

            _ILicenseApplication.ApplicantPersonID = _LocalLicenseInfo.DriverInfo.PersonID;
            _ILicenseApplication.ApplicationTypeID = _ApplicationType.ApplicationID;
            _ILicenseApplication.Status = DVLD_Business.Application.enApplicationStatus.Completed;
            _ILicenseApplication.LastStatusDate = DateTime.Now;
            _ILicenseApplication.PaidFees = _ApplicationType.ApplicationFees;
            _ILicenseApplication.CreatedByUserID = SessionInfo.currentUser.UserID;

            if (_ILicenseApplication.Save())
                return true;
            return false;
        }
        private bool _CreateNewILicense()
        {
            _ILicense.ValidityLength = 5;

            _ILicense.ApplicationID = _ILicenseApplication.ApplicationID;
            _ILicense.DriverID = _LocalLicenseInfo.DriverID;
            _ILicense.IssuedUsingLicenseID = _LocalLicenseInfo.LicenseID;
            _ILicense.IsActive = true;
            _ILicense.CreatedByUserID = SessionInfo.currentUser.UserID;

            if(_ILicense.Save())
                return true;
            return false;
        }

        private void lliShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(_ILicenseID);
            frm.ShowDialog();
        }
        private void lliShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_LocalLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
