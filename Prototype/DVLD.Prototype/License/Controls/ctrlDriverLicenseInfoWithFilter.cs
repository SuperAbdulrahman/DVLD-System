using System;
using System.Windows.Forms;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.License.Controls
{
    /// <summary>
    /// Filter-by-License-ID search box + embedded ctrlDriverLicenseInfocard.
    /// 2nd-most-reused control in the original app (6 host forms) — see
    /// DVLD_UI_Inventory_Report.md item 22.
    /// </summary>
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public event EventHandler<string> OnLicenseSelected;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFindValue.Text.Trim(), out _))
            {
                AppMessageDialog.Failure(this, "Please enter a valid License ID.", "Invalid License ID");
                return;
            }

            ctrlDriverLicenseInfocard1.LoadDummyData();
            OnLicenseSelected?.Invoke(this, txtFindValue.Text.Trim());
        }
    }
}
