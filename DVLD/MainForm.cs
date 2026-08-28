using DVLD.Applications;
using DVLD.ApplicationTypes;
using DVLD.Drivers;
using DVLD.License;
using DVLD.License.International;
using DVLD.Tests.TestsTypes;
using DVLD.Users;
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


namespace DVLD
{

    public partial class MainForm : Form
    {
        public bool IsLoggingOut { get; private set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripDropDownPeople_Click(object sender, EventArgs e)
        {
            ManagePeopleForm frm = new ManagePeopleForm();
            frm.ShowDialog();
        }



        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(SessionInfo.currentUser.UserID);
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsLoggingOut =true;
            SessionInfo.Logout();
            this.Close();
        }

        private void toolStripDropDownUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void toolStripDropDownDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenses frm = new frmManageInternationalLicenses();
            frm.ShowDialog();
        }

        private void localDrivingLiceneseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLDApplications frm = new frmManageLDApplications();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditNewLocalDrivingLicenseApplication frm = new frmAddEditNewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }
    }
}
