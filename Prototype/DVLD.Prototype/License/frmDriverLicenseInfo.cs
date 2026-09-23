using DVLD.Prototype.Common;

namespace DVLD.Prototype.License
{
    /// <summary>
    /// Minimal read-only viewer wrapping ctrlDriverLicenseInfocard — mirrors
    /// the original frmDriverLicenseInfo (item 32).
    /// </summary>
    public partial class frmDriverLicenseInfo : BaseForm
    {
        public frmDriverLicenseInfo()
        {
            InitializeComponent();
            UseDialogSizing();
        }

        private void btnClose_Click(object sender, System.EventArgs e) => Close();
    }
}
