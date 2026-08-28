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

namespace DVLD.License.International
{
    public partial class frmManageInternationalLicenses : Form
    {
        private DataTable _dtInternationalLicenesesList;
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }
        private void _RefreshInternationalLicensesList()
        {
            _dtInternationalLicenesesList = InternationalLicense.GetInternationalLicenses();
            if (_dtInternationalLicenesesList != null)
            {
                dgvInternationalLicenesApplications.DataSource = _dtInternationalLicenesesList;
            }
            _FormatInternationallLicensesGrid();
           _UpdateRecordsCounter();
        }

        private void _FormatInternationallLicensesGrid()
        {
            if (dgvInternationalLicenesApplications.Columns.Count > 0)
            {
                dgvInternationalLicenesApplications.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

               dgvInternationalLicenesApplications.Columns["InternationalLicenseID"].HeaderText = "Int. License ID";
               dgvInternationalLicenesApplications.Columns["InternationalLicenseID"].FillWeight = 10;
      
               dgvInternationalLicenesApplications.Columns["ApplicationID"].HeaderText = "App. ID";
               dgvInternationalLicenesApplications.Columns["ApplicationID"].FillWeight = 10;

               dgvInternationalLicenesApplications.Columns["DriverID"].HeaderText = "Driver ID";
               dgvInternationalLicenesApplications.Columns["DriverID"].FillWeight = 10;

               dgvInternationalLicenesApplications.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L. License ID";
               dgvInternationalLicenesApplications.Columns["IssuedUsingLocalLicenseID"].FillWeight = 15;
          
               dgvInternationalLicenesApplications.Columns["IssueDate"].HeaderText = "Issue Date";
               dgvInternationalLicenesApplications.Columns["IssueDate"].FillWeight = 20;
         
               dgvInternationalLicenesApplications.Columns["ExpirationDate"].HeaderText = "Expiration Date";
               dgvInternationalLicenesApplications.Columns["ExpirationDate"].FillWeight = 20;
       
               dgvInternationalLicenesApplications.Columns["IsActive"].HeaderText = "Is Active";
               dgvInternationalLicenesApplications.Columns["IsActive"].FillWeight = 10;
            }
        }
        private int _CountRecords() => _dtInternationalLicenesesList?.DefaultView.Count ?? 0;
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

        private void _FilterInt(string field, int filter)
        {
            _dtInternationalLicenesesList.DefaultView.RowFilter = $"{field} ={filter}";
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
                case "Int.License ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("InternationalLicenseID", intFilter);
                    else
                        _ResetFilter();
                    break;
                case "Application ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("ApplicationID", intFilter);
                    else
                        _ResetFilter();
                    break;
                case "Driver ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("DriverID", intFilter);
                    else
                        _ResetFilter();
                    return;
                case "L.License ID":
                    if (int.TryParse(filter, out intFilter))
                        _FilterInt("IssuedUsingLocalLicenseID", intFilter);
                    else
                        _ResetFilter();
                    break;
                default:
                    break;
            }

            _UpdateRecordsCounter();
        }
        private void _ResetFilter()
        {
            _dtInternationalLicenesesList.DefaultView.RowFilter = "";
            _UpdateRecordsCounter();
        }

        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddNewInternationalLicenseApp_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            if(frm.ShowDialog()==DialogResult.OK)
                _RefreshInternationalLicensesList();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverID = (int)dgvInternationalLicenesApplications.CurrentRow.Cells["DriverID"].Value;
            Driver driver = Driver.Find(driverID);

            frmPersonDetails frm = new frmPersonDetails(driver.PersonID);
            frm.ShowDialog();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intLicenseID = (int)dgvInternationalLicenesApplications.CurrentRow.Cells["InternationalLicenseID"].Value;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(intLicenseID);
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverID = (int)dgvInternationalLicenesApplications.CurrentRow.Cells["DriverID"].Value;
            Driver driver = Driver.Find(driverID);
            
            frmLicenseHistory frm = new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }

        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshInternationalLicensesList();
            cbFilterByOptions.SelectedIndex = 0;
        }
    }
}
