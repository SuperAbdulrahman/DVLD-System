using System;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.License
{
    /// <summary>
    /// Create a new international license from an eligible local license —
    /// see DVLD_UI_Inventory_Report.md item 31. Chosen as the License module
    /// representative specifically because it hosts
    /// ctrlDriverLicenseInfoWithFilter, one of the 4 selected UserControls.
    /// </summary>
    public partial class frmNewInternationalLicense : BaseForm
    {
        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(object sender, string licenseId)
        {
            lblILAppIDValue.Text = "9001";
            lblApplicationDateValue.Text = DateTime.Today.ToShortDateString();
            lblFeesValue.Text = "20.00";
            lblLocalLicenseIDValue.Text = licenseId;
            lblCreatedByValue.Text = "admin";
            btnIssue.Enabled = true;
            lliShowLicenseInfo.Enabled = true;
        }

        private void lliShowLicenseInfo_LinkClicked(object sender, EventArgs e)
        {
            using (var f = new frmDriverLicenseInfo()) f.ShowDialog(this);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!AppMessageDialog.Confirm(this, "Are you sure you want to issue this license?", "Caution"))
                return;

            lblILicenseIDValue.Text = "IL-5001";
            lblIssueDateValue.Text = DateTime.Today.ToShortDateString();
            lblExpirationDateValue.Text = DateTime.Today.AddYears(5).ToShortDateString();

            AppMessageDialog.Success(this, "License was Issued successfully! You can view it from license info.", "Success");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
