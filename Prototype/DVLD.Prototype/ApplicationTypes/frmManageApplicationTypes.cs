using System;
using System.Data;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.ApplicationTypes
{
    /// <summary>
    /// Grid list of application types — see DVLD_UI_Inventory_Report.md item 9.
    /// Also hosts the required demo of all 3 AppMessageDialog variants
    /// (Edit -> Confirm -> Success; Simulate Failure -> Confirm -> Failure).
    /// </summary>
    public partial class frmManageApplicationTypes : Common.BaseForm
    {
        private readonly DataTable _types = new DataTable();

        public frmManageApplicationTypes()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            _types.Columns.Add("ID", typeof(int));
            _types.Columns.Add("Title", typeof(string));
            _types.Columns.Add("Fees", typeof(decimal));

            _types.Rows.Add(1, "New Local Driving License", 30.00m);
            _types.Rows.Add(2, "New International Driving License", 20.00m);
            _types.Rows.Add(3, "Renew Driving License", 20.00m);
            _types.Rows.Add(4, "Replace Lost/Damaged License", 15.00m);
            _types.Rows.Add(5, "Release Detained License", 10.00m);

            dgvApplicationTypes.DataSource = _types;
            lblRecordsCountValue.Text = _types.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.CurrentRow == null) return;

            if (!AppMessageDialog.Confirm(this, "Are you sure you want to apply changes?", "Caution"))
                return;

            AppMessageDialog.Success(this, "Changes Applied Successfully", "Success");
        }

        private void btnSimulateFailure_Click(object sender, EventArgs e)
        {
            if (!AppMessageDialog.Confirm(this, "Are you sure you want to apply changes?", "Caution"))
                return;

            AppMessageDialog.Failure(this, "An error occurred, changes didn't apply.", "Failure");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
