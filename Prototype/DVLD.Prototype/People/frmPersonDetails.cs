using DVLD.Prototype.Common;

namespace DVLD.Prototype.People
{
    /// <summary>
    /// Minimal read-only viewer wrapping ctrlPersonCard — mirrors the
    /// original frmPersonDetails (item 7), rebuilt as a fixed dialog.
    /// </summary>
    public partial class frmPersonDetails : BaseForm
    {
        public frmPersonDetails()
        {
            InitializeComponent();
            UseDialogSizing();
        }

        private void btnClose_Click(object sender, System.EventArgs e) => Close();
    }
}
