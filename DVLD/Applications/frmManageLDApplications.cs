using DVLD.License;
using DVLD.Tests;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Applications
{
    public partial class frmManageLDApplications : Form
    {
        private DataTable _dtLDLApplications;
        private LocalDrivingLicenseApplication _LocalApp;
        public frmManageLDApplications()
        {
            InitializeComponent();
        }
        private void frmManageLDApplications_Load(object sender, EventArgs e)
        {
            _RefreshLDLApplicationsList();
            cbFilterByOptions.SelectedIndex = 0;
 
        }
        private void _FormatDataGridView()
        {
            if (dgvLDLApplications.Columns.Count > 0)
            {
                dgvLDLApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvLDLApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L.App ID";
                dgvLDLApplications.Columns["LocalDrivingLicenseApplicationID"].FillWeight = 10;

                dgvLDLApplications.Columns["ClassName"].HeaderText = "Driving Class";
                dgvLDLApplications.Columns["ClassName"].FillWeight = 20;

                dgvLDLApplications.Columns["NationalNo"].HeaderText = "National No";
                dgvLDLApplications.Columns["NationalNo"].FillWeight = 10;

                dgvLDLApplications.Columns["FullName"].HeaderText = "Full Name";
                dgvLDLApplications.Columns["FullName"].FillWeight = 30;

                dgvLDLApplications.Columns["ApplicationDate"].HeaderText = "Application Date";
                dgvLDLApplications.Columns["ApplicationDate"].FillWeight = 20;

                dgvLDLApplications.Columns["PassedTestCount"].HeaderText = "Passed Tests";
                dgvLDLApplications.Columns["PassedTestCount"].FillWeight = 5;

                dgvLDLApplications.Columns["Status"].HeaderText = "Status";
                dgvLDLApplications.Columns["Status"].FillWeight = 10;
            }
        }

        private void _RefreshLDLApplicationsList()
        {
            _dtLDLApplications = LocalDrivingLicenseApplication.GetAllLocalDrivingLicensApplications();

            if (_dtLDLApplications != null)
            {
                dgvLDLApplications.DataSource = _dtLDLApplications;
            }
            _FormatDataGridView();
            _UpdateRecordsCounter();

        }
        private int _CountRecords() => _dtLDLApplications?.DefaultView.Count ?? 0;
        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();

            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";

        }


        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilterSearchBar.Visible = true;
            txtbFilterSearchBar.Text = string.Empty;


            switch (cbFilterByOptions.SelectedItem)
            {
                case "None":
                    txtbFilterSearchBar.Visible = false;
                    break;
            }

            _ResetFilter();
        }

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtLDLApplications.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";

        }
        private void _FilterInt(string field, int filter)
        {
            _dtLDLApplications.DefaultView.RowFilter = $"{field} ={filter}";
        }


        private void txtbFilterSearchBar_TextChanged(object sender, EventArgs e)
        {

            string filter = txtbFilterSearchBar.Text;
            if (string.IsNullOrWhiteSpace(filter))
            {
                _ResetFilter();
                return;
            }
            int intFilter = 0;


            switch (cbFilterByOptions.SelectedItem)
            {
                case "L.D.L.AppID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("LocalDrivingLicenseApplicationID", intFilter);
                    else
                        _ResetFilter();
                        break;
                case "National No":
                    _FilterString("National No", filter);
                    break;
                case "Full Name":
                    _FilterString("FullName", filter);
                    break;
                case "Status":
                    _FilterString("Status", filter);
                    break;
                default:
                    break;
            }

            _UpdateRecordsCounter();
        }
        private void _ResetFilter()
        {
            _dtLDLApplications.DefaultView.RowFilter = "";
            _UpdateRecordsCounter();
        }

        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.SelectedItem == "L.D.L.AppID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewLDLApplications_Click(object sender, EventArgs e)
        {
            frmAddEditNewLocalDrivingLicenseApplication frm = new frmAddEditNewLocalDrivingLicenseApplication();
            if(frm.ShowDialog() ==DialogResult.OK)
                _RefreshLDLApplicationsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID =(int) dgvLDLApplications.CurrentRow.Cells[0].Value;
            frmAddEditNewLocalDrivingLicenseApplication frm = new frmAddEditNewLocalDrivingLicenseApplication(LocalAppID);
            if (frm.ShowDialog() == DialogResult.OK)
                _RefreshLDLApplicationsList();
        }

        private void CanceltoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

                int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            _LocalApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(LocalAppID);
            if (_LocalApp == null)
            {
                MessageBox.Show($"Did not find application with ID: {LocalAppID} !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_LocalApp.Cancel())
            {
                MessageBox.Show("Application Status was updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshLDLApplicationsList();
            }
            else
            {
                MessageBox.Show("Application stauts was not updated !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeletetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want do delete this application?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
                if (LocalDrivingLicenseApplication.Delete(LocalAppID))
                {
                    MessageBox.Show("Application was deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshLDLApplicationsList();
                }
                else
                {
                    MessageBox.Show("Application was not deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAppDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            frmShowLDLAppInfo frm = new frmShowLDLAppInfo(LocalAppID);
            frm.ShowDialog();
        }
        private void _HandleStripMenueItemOptions()
        {
            _SetInitialContextMenuStripItems();
            string Status = (string)dgvLDLApplications.CurrentRow.Cells["Status"].Value;

            switch (Status)
            {
                case "New":
                    _HandleNewStatusContextMenueItems();
                    break;
                case "Cancelled":
                    break;
                case "Completed":
                    ShowLicenseToolStripMenuItem.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void _HandleNewStatusContextMenueItems()
        {
            editToolStripMenuItem.Enabled = true;
            DeletetoolStripMenuItem.Enabled = true;
            CanceltoolStripMenuItem.Enabled = true;
            ScheduleTestsToolStripMenuItem.Enabled = true;

            int passedTests = (int)dgvLDLApplications.CurrentRow.Cells["PassedTestCount"].Value;
            switch (passedTests)
            {
                case 0:
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    scheduleVisionTestsToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    scheduleVisionTestsToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    ScheduleTestsToolStripMenuItem.Enabled = false;
                    //scheduleVisionTestsToolStripMenuItem.Enabled = false;
                    //scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    //scheduleStreetTestToolStripMenuItem.Enabled = false;
                    IssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    break;
                default:
                    break;
            }

        }
        private void _SetInitialContextMenuStripItems()
        {
            editToolStripMenuItem.Enabled = false;
            DeletetoolStripMenuItem.Enabled = false;
            CanceltoolStripMenuItem.Enabled = false;
            IssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            ShowLicenseToolStripMenuItem.Enabled= false;
            ScheduleTestsToolStripMenuItem.Enabled = false;
  
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _HandleStripMenueItemOptions();
        }

        
        private void _ShowScheduleTestAppointmetScreen(TestType.enTestType testType)
        {
            int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            frmTestAppointments frm = new frmTestAppointments(LocalAppID,testType);
           if(frm.ShowDialog() == DialogResult.OK) 
                _RefreshLDLApplicationsList();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowScheduleTestAppointmetScreen(TestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowScheduleTestAppointmetScreen(TestType.enTestType.StreetTest);
        }
        private void scheduleVisionTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowScheduleTestAppointmetScreen(TestType.enTestType.VisionTest);
        }

        private void IssueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            frmIssueDrivingLicense frm = new frmIssueDrivingLicense(LocalAppID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _RefreshLDLApplicationsList();
            }
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(LocalAppID);
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LocalApp.ApplicationID,frmDriverLicenseInfo.enMode.AppID);
            frm.ShowDialog();

        }

        private void ShowPersonLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalAppID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(LocalAppID);
            frmLicenseHistory frm = new frmLicenseHistory(LocalApp.ApplicantPersonID);
            frm.ShowDialog();
        }
    }

}
