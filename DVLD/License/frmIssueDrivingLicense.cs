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

namespace DVLD.License
{
    public partial class frmIssueDrivingLicense : Form
    {
        private int _LDLAppID=-1;
        private LocalDrivingLicenseApplication _LDLApp;

        private int _DriverID=-1;
        private byte _PassedTestsCount;
        public frmIssueDrivingLicense(int LocalAppID)
        {
            InitializeComponent();
            _LDLAppID = LocalAppID;
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            if(!ctrlLocalDrivingLicenseApplicationInfoCard1.LoadAppInfoByLDLAppID(_LDLAppID))
            {
                MessageBox.Show($"Could not load local application info with ID {_LDLAppID} ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            _LDLApp = ctrlLocalDrivingLicenseApplicationInfoCard1.LDLAppInfo;
            txtNotes.Focus();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want isee this license?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            _PassedTestsCount = ctrlLocalDrivingLicenseApplicationInfoCard1.PassedTests;
            if(_PassedTestsCount!=3)
            {
                MessageBox.Show($"Cannot Issue this license for this person since he passed {_PassedTestsCount}/{3} Only ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if driver exists for person or create  a new driver
            _DriverID = Driver.GetDriverIDForPerson(_LDLApp.ApplicantPersonID);
            if (_DriverID==-1)
            {
                _CreateANewDriver();
            }
            // Fill License Info
            DVLD_Business.License license = new DVLD_Business.License();

            license.ApplicationID = _LDLApp.ApplicationID;
            license.DriverID =_DriverID;
            license.LicenseClassID = _LDLApp.LicenseClassID;
            license.Notes = txtNotes.Text;
            license.PaidFees = _LDLApp.LicenseClassInfo.Fees;
            license.IsActive = true;
            license.IssueReason = DVLD_Business.License.enIssueReason.FirstTime;
            license.CreatedByUserID = SessionInfo.testUser.UserID;

            if(license.Save())
            {
                MessageBox.Show("License was Issued successfully! you can view it from license info", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LDLApp.SetComplete();
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("An Error Occuerd ! License was not Added!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void _CreateANewDriver()
        {
            Driver driver = new Driver();

            driver.PersonID = _LDLApp.ApplicantPersonID;
            driver.CreatedByUserID = SessionInfo.testUser.UserID;

            if(!driver.Save())
            {
                MessageBox.Show("The driver was not added !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // DVLD_Business.License.Delete() I think I should delete the licnse here if something went wrong at this stage
                return;
            }
            _DriverID = driver.DriverID;

        }
    }
}
