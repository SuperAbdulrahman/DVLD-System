using System;
using System.Windows.Forms;
using DVLD.Prototype.ApplicationTypes;
using DVLD.Prototype.Applications;
using DVLD.Prototype.Common;
using DVLD.Prototype.License;
using DVLD.Prototype.People;
using DVLD.Prototype.Users;

namespace DVLD.Prototype
{
    /// <summary>
    /// Application shell — MDI container with a ToolStrip main menu, mirroring
    /// the original MainForm's navigation but trimmed to the screens actually
    /// built for this prototype (dead/unimplemented menu items from the
    /// original were not carried forward — see DVLD_UI_Inventory_Report.md).
    /// </summary>
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChild(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e) => OpenChild(new ManagePeopleForm());
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e) => OpenChild(new frmManageApplicationTypes());
        private void manageLDApplicationsToolStripMenuItem_Click(object sender, EventArgs e) => OpenChild(new frmManageLDApplications());
        private void newInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e) => OpenChild(new frmNewInternationalLicense());
        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e) => OpenChild(new frmListUsers());

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e) => CenterBackgroundMark();
        private void MainForm_Resize(object sender, EventArgs e) => CenterBackgroundMark();

        private void CenterBackgroundMark()
        {
            var area = pnlBackground.ClientSize;
            iconBackground.Location = new System.Drawing.Point(
                (area.Width - iconBackground.Width) / 2,
                (area.Height - iconBackground.Height) / 2 - 24);
            lblBackgroundCaption.Location = new System.Drawing.Point(
                (area.Width - lblBackgroundCaption.PreferredWidth) / 2,
                iconBackground.Bottom + 12);
        }
    }
}
