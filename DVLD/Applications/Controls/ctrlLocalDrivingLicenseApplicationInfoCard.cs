using DVLD.License;
using DVLD.People;
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

namespace DVLD.Applications.Controls
{
    public partial class ctrlLocalDrivingLicenseApplicationInfoCard : UserControl
    {
        private int _LDLAppID=-1;
        private LocalDrivingLicenseApplication _LDLApp;

        public int LDLAppID { get { return _LDLAppID; } }
        public LocalDrivingLicenseApplication LDLAppInfo {  get { return _LDLApp; } }

        private int _ActiveLicense;
        private byte _PassedTests = 0;
        public byte PassedTests
        {
            get
            {
                return _PassedTests;
            }
        }
        public ctrlLocalDrivingLicenseApplicationInfoCard()
        {
            InitializeComponent();
           
        }
        public bool LoadAppInfoByLDLAppID(int LDLApp)
        {
            _LDLAppID = LDLApp;
            _LDLApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(_LDLAppID);

            if (_LDLApp == null)
            {
                _ResetAppCardInfo();
                MessageBox.Show("No local driving license application with ID = " + _LDLAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LDLAppID = -1;
                return false;
            }
            _FillAppCardInfo();
            return true;
        }
        public bool LoadAppInfoByAppID(int appID)
        {

            _LDLApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByApplicationID(appID);

            if (_LDLApp == null)
            {
                _ResetAppCardInfo();
                MessageBox.Show("No local driving license application with application ID = " + appID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _FillAppCardInfo();
            return true;
        }


        private void _ResetAppCardInfo()
        {
            lblDLAppIDValue.Text = "??";
            lblAppliedForLicenseValue.Text = "??";
            lblPassedTestsValue.Text = "0/3";

            ctrlApplicationBasicInfoCard1.ResetApplicationCardInfo();
        }
        private void _FillAppCardInfo()
        {
            _ActiveLicense = DVLD_Business.License.GetActiveLicenseIDByPersonID(_LDLApp.ApplicantPersonID, (int)_LDLApp.LicenseClassID);
            llShowLicenseInfo.Enabled = (_ActiveLicense != -1);

            lblDLAppIDValue.Text = _LDLApp.LocalDirivingLicenseID.ToString();
            lblAppliedForLicenseValue.Text = _LDLApp.LicenseClassInfo?.Name;
            _FillPassedTestsValue();
            if(_PassedTests==3)
                llShowLicenseInfo.Enabled=true;
            ctrlApplicationBasicInfoCard1.LoadAppInfoByAppID(_LDLApp.ApplicationID);
        }
        private void _FillPassedTestsValue()
        {
             _PassedTests = LocalDrivingLicenseApplication.TotalPassedTests(_LDLAppID);
            if (_PassedTests == 1)
                lblPassedTestsValue.Text = "1/3";
            else if (_PassedTests == 2)
                lblPassedTestsValue.Text = "2/3";
            else if(_PassedTests == 3)
                lblPassedTestsValue.Text = "3/3";
            else
                lblPassedTestsValue.Text = "0/3";
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LDLApp.ApplicationID,frmDriverLicenseInfo.enMode.AppID);
            frm.ShowDialog();   
        }
    }
}
