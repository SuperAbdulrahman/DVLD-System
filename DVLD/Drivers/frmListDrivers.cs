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

namespace DVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        DataTable _dtDriversList;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _RefreshDriversList();
            cbFilterByOptions.SelectedIndex = 0;
        }
        private void _FormatDataGridView()
        {
            if (dgvDriversList.Columns.Count > 0)
            {
                dgvDriversList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvDriversList.Columns["DriverID"].HeaderText = "Driver ID";
                dgvDriversList.Columns["DriverID"].FillWeight = 10;

                dgvDriversList.Columns["PersonID"].HeaderText = "Person ID";
                dgvDriversList.Columns["PersonID"].FillWeight = 10;

                dgvDriversList.Columns["NationalNo"].HeaderText = "National No";
                dgvDriversList.Columns["NationalNo"].FillWeight = 10;

                dgvDriversList.Columns["FullName"].HeaderText = "Full Name";
                dgvDriversList.Columns["FullName"].FillWeight = 30;

                dgvDriversList.Columns["CreatedDate"].HeaderText = "Date";
                dgvDriversList.Columns["CreatedDate"].FillWeight = 20;

                dgvDriversList.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";
                dgvDriversList.Columns["NumberOfActiveLicenses"].FillWeight = 7;

            }
        }

        private void _RefreshDriversList()
        {
            _dtDriversList = Driver.GetDrivers();

            if (_dtDriversList != null)
            {
                dgvDriversList.DataSource = _dtDriversList;
            }
            _FormatDataGridView();
            _UpdateRecordsCounter();

        }
        private int _CountRecords() => _dtDriversList?.DefaultView.Count ?? 0;
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

            if(cbFilterByOptions.SelectedItem =="None")
            {
                txtbFilterSearchBar.Visible = false;
            }
            _ResetFilter();
        }

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtDriversList.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";

        }
        private void _FilterInt(string field, int filter)
        {
            _dtDriversList.DefaultView.RowFilter = $"{field} ={filter}";
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
                case "Driver ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("DriverID", intFilter);
                    break;
                case "Person ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("PersonID", intFilter);
                    break;
                case "National No.":
                    _FilterString("NationalNo", filter);
                    break;
                case "Full Name":
                    _FilterString("FullName", filter);
                    break;
                default:
                    break;
            }

            _UpdateRecordsCounter();
        }
        private void _ResetFilter()
        {
            _dtDriversList.DefaultView.RowFilter = "";
            _UpdateRecordsCounter();
        }

        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterByOptions.SelectedItem == "Person ID" || cbFilterByOptions.SelectedItem == "Driver ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPersonLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)dgvDriversList.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }

        private void ShowPersonInfotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvDriversList.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }
    }
}
