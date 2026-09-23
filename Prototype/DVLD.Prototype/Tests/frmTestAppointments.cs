using System;
using System.Data;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.Tests
{
    /// <summary>
    /// List of test appointments for a given test type — see
    /// DVLD_UI_Inventory_Report.md item 40. Reached from
    /// frmManageLDApplications' "Schedule Tests" submenu, matching the
    /// original app's actual navigation (Tests has no top-level menu entry).
    /// </summary>
    public partial class frmTestAppointments : BaseForm
    {
        private readonly DataTable _appointments = new DataTable();
        private readonly string _testType;

        public frmTestAppointments() : this("Vision") { }

        public frmTestAppointments(string testType)
        {
            _testType = testType;
            InitializeComponent();
            lblTitle.Text = $"{_testType} Test Appointments";
            Text = $"{_testType} Test Appointments";
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            _appointments.Columns.Add("AppointmentID", typeof(int));
            _appointments.Columns.Add("Applicant", typeof(string));
            _appointments.Columns.Add("Trial", typeof(int));
            _appointments.Columns.Add("Date", typeof(string));
            _appointments.Columns.Add("Fees", typeof(decimal));

            _appointments.Rows.Add(701, "Omar Khaled Yousef", 1, "2026-09-02", 10.00m);
            _appointments.Rows.Add(702, "Layla Ahmad Al-Hassan", 1, "2026-09-05", 10.00m);

            dgvAppointmentsList.DataSource = _appointments;
            lblRecordsCountValue.Text = _appointments.Rows.Count.ToString();
        }

        private void btnAddNewTestAppointment_Click(object sender, EventArgs e)
        {
            if (!AppMessageDialog.Confirm(this, "Are you sure you want save changes?", "Confirm changes"))
                return;

            _appointments.Rows.Add(_appointments.Rows.Count + 701, "New Applicant", 1, DateTime.Today.ToShortDateString(), 10.00m);
            lblRecordsCountValue.Text = _appointments.Rows.Count.ToString();
            AppMessageDialog.Success(this, "Changed Applied Successfully", "Success");
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentsList.CurrentRow == null) return;
            if (!AppMessageDialog.Confirm(this, "Are you sure you want to apply changes?", "Caution"))
                return;

            AppMessageDialog.Success(this, "Test Result was added successfully.", "Success");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
