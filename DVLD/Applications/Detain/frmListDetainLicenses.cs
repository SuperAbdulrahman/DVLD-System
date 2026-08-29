using DVLD.License;
using DVLD.People;
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

namespace DVLD.Applications.Detain
{
    public partial class frmListDetainLicenses : Form
    {
        private DataTable _dtDetainedLicenses;
        public frmListDetainLicenses()
        {
            InitializeComponent();
        }


        private void frmListDetainLicenses_Load(object sender, EventArgs e)
        {
            _RefreshDetainedLicensesList();
            cbFilterByOptions.SelectedIndex = 0;
        }
        private void _FormatDataGridView()
        {
            if (dgvDetainedLicensesList.Columns.Count > 0)
            {
                dgvDetainedLicensesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
                dgvDetainedLicensesList.Columns["DetainID"].HeaderText = "D.ID";
                dgvDetainedLicensesList.Columns["DetainID"].FillWeight = 10;

                dgvDetainedLicensesList.Columns["LicenseID"].HeaderText = "L.ID";
                dgvDetainedLicensesList.Columns["LicenseID"].FillWeight = 10;
        
                dgvDetainedLicensesList.Columns["DetainDate"].HeaderText = "D.Date";
                dgvDetainedLicensesList.Columns["DetainDate"].FillWeight = 21;
          
                dgvDetainedLicensesList.Columns["IsReleased"].HeaderText = "Is Released";
                dgvDetainedLicensesList.Columns["IsReleased"].FillWeight = 10;
        
                dgvDetainedLicensesList.Columns["FineFees"].HeaderText = "Fine Fees";
                dgvDetainedLicensesList.Columns["FineFees"].FillWeight = 20;
              
                dgvDetainedLicensesList.Columns["ReleaseDate"].HeaderText = "Release Date";
                dgvDetainedLicensesList.Columns["ReleaseDate"].FillWeight = 21;

                dgvDetainedLicensesList.Columns["NationalNo"].HeaderText = "N.No";
                dgvDetainedLicensesList.Columns["NationalNo"].FillWeight = 10;

                dgvDetainedLicensesList.Columns["FullName"].HeaderText = "Full Name";
                dgvDetainedLicensesList.Columns["FullName"].FillWeight = 35;

                dgvDetainedLicensesList.Columns["ReleaseApplicationID"].HeaderText = "Release App.ID";
                dgvDetainedLicensesList.Columns["ReleaseApplicationID"].FillWeight = 11;
            }
        }

        private void _RefreshDetainedLicensesList()
        {
            _dtDetainedLicenses = DetainedLicense.GetDetainedLicenses();

            if (_dtDetainedLicenses != null)
            {
                dgvDetainedLicensesList.DataSource = _dtDetainedLicenses;
            }
            _FormatDataGridView();
            _UpdateRecordsCounter();

        }
        private int _CountRecords() => _dtDetainedLicenses?.DefaultView.Count ?? 0;
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
            cbIsReleasedFilter.Visible = false;

            switch (cbFilterByOptions.SelectedItem)
            {
                case "None":
                    txtbFilterSearchBar.Visible = false;
                    break;
                case "Is Released":
                    txtbFilterSearchBar.Visible = false;
                    cbIsReleasedFilter.Visible = true;
                    cbIsReleasedFilter.SelectedIndex = 0;
                    break;
            }

            _ResetFilter();
        }

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtDetainedLicenses.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";

        }
        private void _FilterInt(string field, int filter)
        {
            _dtDetainedLicenses.DefaultView.RowFilter = $"{field} ={filter}";
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
                case "Detain ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("DetainID", intFilter);
                    else
                        _ResetFilter();
                    break;
                case "Release Application ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("ReleaseApplicationID", intFilter);
                    else
                        _ResetFilter();
                    break;
                case "National No":
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
            _dtDetainedLicenses.DefaultView.RowFilter = "";
            _UpdateRecordsCounter();
        }

        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.SelectedItem == "Detain ID"||cbFilterByOptions.SelectedItem== "Release Application ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
            }
        }
        

        private void cbIsReleasedFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsReleasedFilter.SelectedItem)
            {
                case "All":
                    _ResetFilter();
                    break;
                case "Yes":
                    _FilterInt("IsReleased", 1);
                    break;
                case "No":
                    _FilterInt("IsReleased", 0);
                    break;
                default:
                    break;
            }
            _UpdateRecordsCounter();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dgvDetainedLicensesList.CurrentRow.Cells["IsReleased"].Value)
            {
                ReleaseDetainedLicensetoolStripMenuItem1.Enabled = false;
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvDetainedLicensesList.CurrentRow.Cells["LicenseID"].Value;
            DVLD_Business.License selectedLicense = DVLD_Business.License.FindByLicenseID(licenseID);

            frmPersonDetails frm = new frmPersonDetails(selectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void ShowLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvDetainedLicensesList.CurrentRow.Cells["LicenseID"].Value;

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(licenseID,frmDriverLicenseInfo.enMode.LicenseID);
            frm.ShowDialog();

        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvDetainedLicensesList.CurrentRow.Cells["LicenseID"].Value;
            DVLD_Business.License selectedLicense = DVLD_Business.License.FindByLicenseID(licenseID);

            frmLicenseHistory frm = new frmLicenseHistory(selectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void ReleaseDetainedLicensetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvDetainedLicensesList.CurrentRow.Cells["LicenseID"].Value;
            
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(licenseID);
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }
    }
}
