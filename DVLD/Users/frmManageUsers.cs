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

namespace DVLD.Users
{
    public partial class frmManageUsers : Form
    {
        private DataTable _dtAllUsers;
        private DataTable _dtAllUsersGrid;

        public frmManageUsers()
        {
            InitializeComponent();
        }


        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilterByOptions.SelectedIndex = 0;
            cbIsActiveFilter.SelectedIndex = 0;
            _UpdateRecordsCounter();
        }
        private void _RefreshUsersList()
        {
            _dtAllUsers = User.GetAllUsers();
            if (_dtAllUsers.Rows.Count > 0)
            {
                _dtAllUsersGrid = _dtAllUsers.DefaultView.ToTable(false,"UserID","PersonID", "FullName", "UserName","IsActive");
                dgvUsersList.DataSource = _dtAllUsersGrid;
                _FormatDataGridView();
            }
        }
        private void _FormatDataGridView()
        {
            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns["UserID"].HeaderText = "User ID";
                dgvUsersList.Columns["UserID"].Width = 90;
                dgvUsersList.Columns["UserID"].ReadOnly = true;

                dgvUsersList.Columns["PersonID"].HeaderText = "Person ID";
                dgvUsersList.Columns["PersonID"].Width = 90;
                dgvUsersList.Columns["PersonID"].ReadOnly = true;

                dgvUsersList.Columns["FullName"].HeaderText = "Full Name";
                dgvUsersList.Columns["FullName"].Width = 250;
                dgvUsersList.Columns["FullName"].ReadOnly = true;

                dgvUsersList.Columns["UserName"].HeaderText = "Username";
                dgvUsersList.Columns["UserName"].Width = 120;
                dgvUsersList.Columns["UserName"].ReadOnly = true;

                dgvUsersList.Columns["IsActive"].HeaderText = "Is Active";
                dgvUsersList.Columns["IsActive"].Width = 90;
                dgvUsersList.Columns["IsActive"].ReadOnly = false;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbFilterSearchBar.Visible = true;
            txtbFilterSearchBar.Text = string.Empty;
            cbIsActiveFilter.Visible = false;
            cbIsActiveFilter.SelectedIndex = 0;

            switch (cbFilterByOptions.SelectedItem)
            {
                case "None":
                    txtbFilterSearchBar.Visible = false;
                    cbIsActiveFilter.Visible = false;
                    break;
                case "User ID":
                    break;
                case "Person ID":
                    break;
                case "Full Name":
                    break;
                case "Username":
                    break;
                case "Is Active":
                    cbIsActiveFilter.Visible = true;
                    txtbFilterSearchBar.Visible = false;
                    break;
                default:
                    break;
            }
            _ResetFilter();
        }

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtAllUsersGrid.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";

        }
        private void _FilterInt(string field, int filter)
        {
            _dtAllUsersGrid.DefaultView.RowFilter = $"{field} ={filter}";
        }
        private int _CountRecords() => _dtAllUsersGrid.DefaultView.Count;
            //_dtAllUsersGrid.DefaultView.Count;

        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();
            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";
     
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
          //  string fieldName = "";
            switch (cbFilterByOptions.SelectedItem)
            {
                case "User ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("UserID", intFilter);
                    break;
                case "Person ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("PersonID", intFilter);
                    break;
                case "Full Name":
                    _FilterString("FullName",filter);
                    break;
                case "Username":
                    _FilterString("UserName", filter);
                    break;
                default:
                    break;
            }

            _UpdateRecordsCounter();
        }
        private void _ResetFilter()
        {
            _dtAllUsersGrid.DefaultView.RowFilter = "";
            _UpdateRecordsCounter();
        }

        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterByOptions.SelectedItem =="Person ID"|| cbFilterByOptions.SelectedItem == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
            }
        }

        private void cbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 = All , 1 = Yes , No = 2
            byte filterValue = 0;
            switch (cbIsActiveFilter.SelectedIndex)
            {
                case 0:
                    _ResetFilter();
                    return;
                case 1:
                    filterValue = 1;// 1 means true (active)
                    break;
                case 2:
                    filterValue = 0;// 0 means false (inactive)
                    break;
                default:

                    break;
            }
            _FilterInt("IsActive",filterValue);
            _UpdateRecordsCounter() ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            //if (!int.TryParse(dgvUsersList.CurrentRow.Cells["User ID"].Value.ToString(), out int userID))
            //    return;

            frmUserInfo frm = new frmUserInfo(id);
            frm.ShowDialog();

        }
        private void _DatabackEvent(object sender, int obj)
        {
            _RefreshUsersList();
            _UpdateRecordsCounter();
        }


        private void AddNewUser(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.DataBack += _DatabackEvent;
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.DataBack += _DatabackEvent;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            if (User.IsUserExist(userID))
            {
                if (User.Delete(userID))
                {
                    MessageBox.Show("User was deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User was not deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available later !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available later !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        // I am not sure if this is required but we will be able to edit info from the edit page
        //private void dgvUsersList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //   // if (dgvUsersList.SelectedRows.["Is Active"])
        //}
    }
}
