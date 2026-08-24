using DVLD.Properties;
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

namespace DVLD.Tests
{
    public partial class frmTestAppointments : Form
    {
        private bool _IsDataChanged =false;
        private int _LDLAppID;
        private int _TestAppointmentID;

        private LocalDrivingLicenseApplication _LDLApp;
        private TestAppointment _TestAppointment;
        TestType.enTestType testType;
        private DataTable _dtTestAppointmentsPerTestType;


        public frmTestAppointments(int LDLAppID, TestType.enTestType testType)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            this.testType = testType;
        }

  
        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationInfoCard1.LoadAppInfoByLDLAppID(_LDLAppID);
            _LDLApp = ctrlLocalDrivingLicenseApplicationInfoCard1.LDLAppInfo;
            _RefreshTestAppointmentsList();
            _LoadTestTypeAppointments();
        }
        private void _RefreshTestAppointmentsList()
        {
            _dtTestAppointmentsPerTestType = TestAppointment.GetTestAppointmentsByLDLAppIDAndTestType(_LDLAppID, testType);
            if (_dtTestAppointmentsPerTestType != null)
            {
                dgvAppointmentsList.DataSource = _dtTestAppointmentsPerTestType;
            }
            _FormatTestAppointmentsGrid();
            _UpdateRecordsCounter();
        }
        private void _FormatTestAppointmentsGrid()
        {
            if (dgvAppointmentsList.Columns.Count > 0)
            {
                dgvAppointmentsList.Columns["TestAppointmentID"].HeaderText = "Appointment ID";
                dgvAppointmentsList.Columns["TestAppointmentID"].Width = 150;

                dgvAppointmentsList.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                dgvAppointmentsList.Columns["AppointmentDate"].Width = 200;

                dgvAppointmentsList.Columns["PaidFees"].HeaderText = "Paid Fees";
                dgvAppointmentsList.Columns["PaidFees"].Width = 150;

                dgvAppointmentsList.Columns["IsLocked"].HeaderText = "Is Locked";
                dgvAppointmentsList.Columns["IsLocked"].Width = 150;

            }
        }
        private int _CountRecords() => _dtTestAppointmentsPerTestType.DefaultView.Count;
        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();
            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";
        }
        private void _LoadTestTypeAppointments()
        {
            switch (testType)
            {
                case TestType.enTestType.VisionTest:
                    lblTitle.Text = "Vison Test Appointments";
                    pbTestTypeIcon.Image = Resources.Vision_512;
                    break;
                case TestType.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test Appointments";
                    pbTestTypeIcon.Image = Resources.Written_Test_512;
                    break;
                case TestType.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appointments";
                    pbTestTypeIcon.Image = Resources.Schedule_Test_512;
                    break;
                default:
                    break;
            }
        }



        private void btnAddNewTestAppointment_Click(object sender, EventArgs e)
        {
            // Check if there is any active schedule test appointment
            int activeTestAppointmentID = TestAppointment.GetActiveTestAppointmentID(_LDLAppID,testType);
            if(activeTestAppointmentID!=-1)
            {
                MessageBox.Show($"Person already have an active appointment with ID:{activeTestAppointmentID} for this test,you cannot add a new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the user already passed the test 
            if(_LDLApp.DoesPassTestType(testType))
            {
                MessageBox.Show($"Person already passed the test before !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check prerequisite tests
            if (!_LDLApp.DoesPassPreviousTest(testType))
            {
                string prerequisiteTest = (testType == TestType.enTestType.WrittenTest) ? "Vision Test" : "Written Test";
                MessageBox.Show($"Cannot schedule this test. The applicant must pass the {prerequisiteTest} first.", "Prerequisite Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            frmScheduleTest frm = new frmScheduleTest(_LDLAppID,testType);
            if(frm.ShowDialog() == DialogResult.OK)
                _IsDataChanged = true;


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testAppointmentID =(int)dgvAppointmentsList.CurrentRow.Cells[0].Value;
            bool viewOnly = false;
            if ((bool)dgvAppointmentsList.CurrentRow.Cells["IsLocked"].Value)
            {
                MessageBox.Show($"This appointment is locked, you cannot edit it ! but view its detials only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                viewOnly = true;
            }


            frmScheduleTest frm = new frmScheduleTest(_LDLAppID, testType,testAppointmentID,viewOnly);
            if(frm.ShowDialog() == DialogResult.OK)
                _IsDataChanged = true;


        }

        private void TakeTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int testAppointmentID = (int)dgvAppointmentsList.CurrentRow.Cells[0].Value;
            bool viewOnly = true;
            if ((bool)dgvAppointmentsList.CurrentRow.Cells["IsLocked"].Value)
            {
                MessageBox.Show($"This appointment is locked, you cannot retake test for it it !Please request a retake test application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmTakeTest frm = new frmTakeTest(_LDLAppID,testType,testAppointmentID,viewOnly);
            if(frm.ShowDialog() == DialogResult.OK)
            { 
                //_TestAppointment = TestAppointment.Find(testAppointmentID);
                //_TestAppointment.IsLocked = true;
                //_TestAppointment.Save();
                // No need for all of this, we lock it directly from the database!
                _RefreshTestAppointmentsList(); 
                _IsDataChanged = true;
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = _IsDataChanged?DialogResult.OK:DialogResult.Cancel;
            Close();
        }
    }
}
