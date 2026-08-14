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
    public partial class frmListUsers : Form
    {
        private DataTable _dtAllUsers;
  

        public frmListUsers()
        {
            InitializeComponent();
        }


        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilterByOptions.SelectedIndex = 0;
           // cbIsActiveFilter.SelectedIndex = 0;
            
        }
        private void _RefreshUsersList()
        {
            _dtAllUsers = User.GetAllUsers();
            dgvUsersList.DataSource = _dtAllUsers;
            _FormatDataGridView();
            _UpdateRecordsCounter();

        }
        private void _FormatDataGridView()
        {
            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns["UserID"].HeaderText = "User ID";
                dgvUsersList.Columns["UserID"].Width = 90;

                dgvUsersList.Columns["PersonID"].HeaderText = "Person ID";
                dgvUsersList.Columns["PersonID"].Width = 90;

                dgvUsersList.Columns["FullName"].HeaderText = "Full Name";
                dgvUsersList.Columns["FullName"].Width = 250;

                dgvUsersList.Columns["UserName"].HeaderText = "Username";
                dgvUsersList.Columns["UserName"].Width = 120;

                dgvUsersList.Columns["IsActive"].HeaderText = "Is Active";
                dgvUsersList.Columns["IsActive"].Width = 90;
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
                    break;

                case "Is Active":
                    cbIsActiveFilter.Visible = true;
                    txtbFilterSearchBar.Visible = false;
                    break;
            }

            _ResetFilter();
        }

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtAllUsers.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";

        }
        private void _FilterInt(string field, int filter)
        {
            _dtAllUsers.DefaultView.RowFilter = $"{field} ={filter}";
        }
        private int _CountRecords() => _dtAllUsers.DefaultView.Count;
            //_dtAllUsers.DefaultView.Count;

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
            _dtAllUsers.DefaultView.RowFilter = "";
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


        private void _DatabackEvent(object sender, int obj)
        {
            _RefreshUsersList();
        }
        private void showUserInfo(object sender,EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
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
            //if (User.IsUserExist(userID))
            //{
                if (User.Delete(userID))
                {
                    MessageBox.Show("User was deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User was not deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //else
            //{
            //    MessageBox.Show("User does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            int userID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            frmChangePassword frm = new frmChangePassword(userID);
            frm.ShowDialog();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void lblRecordsCountValue_Click(object sender, EventArgs e)
        {

        }
    }
}
