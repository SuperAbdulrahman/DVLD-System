using System;
using System.Data;
using DVLD.Prototype.Common;
using DVLD.Prototype.Tests;

namespace DVLD.Prototype.Applications
{
    /// <summary>
    /// Master grid of Local Driving License Applications — see
    /// DVLD_UI_Inventory_Report.md item 16. "Schedule Tests" submenu wires
    /// to frmTestAppointments exactly as the original app's context menu
    /// does (Tests module has no top-level MainForm menu entry either).
    /// </summary>
    public partial class frmManageLDApplications : BaseForm
    {
        private readonly DataTable _apps = new DataTable();

        public frmManageLDApplications()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            _apps.Columns.Add("L.D.L.AppID", typeof(int));
            _apps.Columns.Add("Full Name", typeof(string));
            _apps.Columns.Add("Class", typeof(string));
            _apps.Columns.Add("Status", typeof(string));
            _apps.Columns.Add("Application Date", typeof(string));

            _apps.Rows.Add(501, "Omar Khaled Yousef", "Second Class", "Pending Tests", "2026-06-01");
            _apps.Rows.Add(502, "Sara Naji Odeh", "First Class", "Completed", "2026-05-20");
            _apps.Rows.Add(503, "Ziad Fadi Mansour", "Third Class", "Cancelled", "2026-04-11");
            _apps.Rows.Add(504, "Layla Ahmad Al-Hassan", "Second Class", "Pending Tests", "2026-06-15");

            dgvLDLApplications.DataSource = _apps;
            lblRecordsCountValue.Text = _apps.Rows.Count.ToString();
        }

        private void btnAddNewLDLApplications_Click(object sender, EventArgs e)
        {
            AppMessageDialog.Success(this, "This prototype does not include the New Application wizard — grid + dialog navigation only.", "Prototype Notice");
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLApplications.CurrentRow == null) return;
            if (!AppMessageDialog.Confirm(this, "Are you sure you want to cancel this application?", "Confirm changes"))
                return;

            dgvLDLApplications.CurrentRow.Cells["Status"].Value = "Cancelled";
            AppMessageDialog.Success(this, "Application Status was updated.", "Success");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLApplications.CurrentRow == null) return;
            if (!AppMessageDialog.Confirm(this, "Are you sure you want to delete this application?", "Confirm changes"))
                return;

            _apps.Rows.RemoveAt(dgvLDLApplications.CurrentRow.Index);
            lblRecordsCountValue.Text = _apps.Rows.Count.ToString();
            AppMessageDialog.Success(this, "Application was deleted.", "Success");
        }

        private void scheduleVisionToolStripMenuItem_Click(object sender, EventArgs e) => OpenScheduleTests("Vision");
        private void scheduleWrittenToolStripMenuItem_Click(object sender, EventArgs e) => OpenScheduleTests("Written");
        private void scheduleStreetToolStripMenuItem_Click(object sender, EventArgs e) => OpenScheduleTests("Street");

        private void OpenScheduleTests(string testType)
        {
            using (var f = new frmTestAppointments(testType)) f.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
