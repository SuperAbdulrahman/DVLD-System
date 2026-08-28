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

namespace DVLD.License.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int licenseID)
        {
            OnLicenseSelected?.Invoke(licenseID);
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public DVLD_Business.License LicenseInfo
        {
            get { return ctrlDriverLicenseInfocard1.LicenseInfo; }
        }
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindNow();
        }

        public void FilterFocus()
        {
            txtFindValue.Focus();
        }
        private void txtFindValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           
        }
        public void LoadPersonInfo(int licenseID)
        {
            txtFindValue.Text = licenseID.ToString();
            FilterEnabled = false;
            FindNow();
        }
        private void FindNow()
        {
            if (!int.TryParse(txtFindValue.Text.Trim(), out int licenseID))
            {
                MessageBox.Show(
                    "Please enter a valid License ID.",
                    "Invalid License ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FilterFocus();
                return;
            }

            if (ctrlDriverLicenseInfocard1.LoadDriverLicenseInfoByLicenseID(licenseID))
                LicenseSelected(licenseID);
            else
                Focus();
        }
    }
}
