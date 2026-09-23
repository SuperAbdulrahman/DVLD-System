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
using static DVLD_Business.TestType;

namespace DVLD.License.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private Driver _DriverInfo;

        private DataTable _dtLocalLicensesList;
        private DataTable _dtInternationalLicenesesList;


        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        public bool LoadDriverLicensesCardInfoByDPersonID(int personID)
        {
            _DriverID = Driver.GetDriverIDForPerson(personID);
            if (_DriverID==-1)
            {

                // ResetApplicationCardInfo();
                MessageBox.Show("No Driver found for person with ID: " + personID + " !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _RefreshLocalLicensesList();
            _RefreshInternationalLicensesList();
            return true;
        }
        public bool LoadDriverLicensesCardInfoByDriverID(int DriverID)
        {
            _DriverID = DriverID;
            if (!Driver.IsDriverExist(_DriverID))
            {
                
               // ResetApplicationCardInfo();
                MessageBox.Show("No Driver found with Driver ID: "+ _DriverID+" !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _RefreshLocalLicensesList();
            _RefreshInternationalLicensesList();
            return true;
        }
        public void Clear ()
        {
            _dtInternationalLicenesesList.Clear();
            _dtLocalLicensesList.Clear();
        }
        private void _RefreshLocalLicensesList()
        {
            _dtLocalLicensesList = DVLD_Business.License.GetLicensesHistoryForDriver(_DriverID);
            if (_dtLocalLicensesList != null)
            {
                dgvLocalLicensesList.DataSource = _dtLocalLicensesList;
            }
            _FormatLocalLicensesGrid();
            _UpdateRecordsCounter(_dtLocalLicensesList,lblRecordsValueLocal);
        }
        private void _FormatLocalLicensesGrid()
        {
            if (dgvLocalLicensesList.Columns.Count > 0)
            {
                dgvLocalLicensesList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvLocalLicensesList.Columns["LicenseID"].HeaderText = "Lic.ID";
                dgvLocalLicensesList.Columns["LicenseID"].FillWeight = 10;

                dgvLocalLicensesList.Columns["ApplicationID"].HeaderText = "App.ID";
                dgvLocalLicensesList.Columns["ApplicationID"].FillWeight = 10;

                dgvLocalLicensesList.Columns["ClassName"].HeaderText = "Class Name";
                dgvLocalLicensesList.Columns["ClassName"].FillWeight = 30;

                dgvLocalLicensesList.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvLocalLicensesList.Columns["IssueDate"].FillWeight = 20;

                dgvLocalLicensesList.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvLocalLicensesList.Columns["ExpirationDate"].FillWeight = 20;

                dgvLocalLicensesList.Columns["IsActive"].HeaderText = "Is Active";
                dgvLocalLicensesList.Columns["IsActive"].FillWeight = 10;

            }
        }

        private void _RefreshInternationalLicensesList()
        {
            _dtInternationalLicenesesList = InternationalLicense.GetInternationalLicensesByDriverID(_DriverID);
            if (_dtInternationalLicenesesList != null)
            {
                dgvInternationalLicensessList.DataSource = _dtInternationalLicenesesList;
            }
            _FormatInternationallLicensesGrid();
            _UpdateRecordsCounter(_dtInternationalLicenesesList, lblRecordsValueInternational);
        }

        private void _FormatInternationallLicensesGrid()
        {
            if (dgvInternationalLicensessList.Columns.Count > 0)
            {
                dgvInternationalLicensessList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvInternationalLicensessList.Columns["InternationalLicenseID"].HeaderText = "Int. License ID";
                dgvInternationalLicensessList.Columns["InternationalLicenseID"].FillWeight = 10;

                dgvInternationalLicensessList.Columns["ApplicationID"].HeaderText = "App. ID";
                dgvInternationalLicensessList.Columns["ApplicationID"].FillWeight = 10;

                dgvInternationalLicensessList.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L. License ID";
                dgvInternationalLicensessList.Columns["IssuedUsingLocalLicenseID"].FillWeight = 15;

                dgvInternationalLicensessList.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternationalLicensessList.Columns["IssueDate"].FillWeight = 20;

                dgvInternationalLicensessList.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternationalLicensessList.Columns["ExpirationDate"].FillWeight = 20;

                dgvInternationalLicensessList.Columns["IsActive"].HeaderText = "Is Active";
                dgvInternationalLicensessList.Columns["IsActive"].FillWeight = 10;
            }
        }

        private int _CountRecords(DataTable dataTableList) => dataTableList.DefaultView.Count;
        private void _UpdateRecordsCounter(DataTable dataTableList, Label lblName)
        {
            int count = _CountRecords(dataTableList);
            if (count > 0)
                lblName.Text = count.ToString();
            else
                lblName.Text = "0";
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgvLocalLicensesList.CurrentRow.Cells["LicenseID"].Value,frmDriverLicenseInfo.enMode.LicenseID);
            frm.ShowDialog();
        }
    }
}
