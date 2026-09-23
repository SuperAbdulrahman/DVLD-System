using System;
using System.Data;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.Users
{
    /// <summary>
    /// Main Manage Users grid — see DVLD_UI_Inventory_Report.md item 45.
    /// Fixes the report's flagged UX gap: destructive Delete now shows a
    /// confirmation, same as ManagePeopleForm.
    /// </summary>
    public partial class frmListUsers : BaseForm
    {
        private readonly DataTable _users = new DataTable();

        public frmListUsers()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            _users.Columns.Add("UserID", typeof(int));
            _users.Columns.Add("Username", typeof(string));
            _users.Columns.Add("Full Name", typeof(string));
            _users.Columns.Add("Is Active", typeof(string));

            _users.Rows.Add(1, "admin", "System Administrator", "Yes");
            _users.Rows.Add(2, "reception1", "Nour Samer Qasem", "Yes");
            _users.Rows.Add(3, "clerk2", "Ziad Fadi Mansour", "No");

            dgvUsersList.DataSource = _users;
            lblRecordsCountValue.Text = _users.Rows.Count.ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AppMessageDialog.Success(this, "This prototype does not include the Add/Edit User screen — grid + dialog navigation only.", "Prototype Notice");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null) return;
            string name = dgvUsersList.CurrentRow.Cells["Username"].Value.ToString();

            if (!AppMessageDialog.Confirm(this, $"Are you sure you want to delete user \"{name}\"?", "Caution"))
                return;

            _users.Rows.RemoveAt(dgvUsersList.CurrentRow.Index);
            lblRecordsCountValue.Text = _users.Rows.Count.ToString();
            AppMessageDialog.Success(this, "User was deleted.", "Success");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
