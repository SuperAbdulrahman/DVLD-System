using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem miApplications;
        private ToolStripMenuItem miManageApplicationTypes;
        private ToolStripMenuItem miManageLDApplications;
        private ToolStripMenuItem miNewInternationalLicense;
        private ToolStripMenuItem miPeople;
        private ToolStripMenuItem miUsers;
        private ToolStripMenuItem miAccount;
        private ToolStripMenuItem miSignOut;
        private Panel pnlBackground;
        private IconGlyph iconBackground;
        private Label lblBackgroundCaption;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.miApplications = new ToolStripMenuItem();
            this.miManageApplicationTypes = new ToolStripMenuItem();
            this.miManageLDApplications = new ToolStripMenuItem();
            this.miNewInternationalLicense = new ToolStripMenuItem();
            this.miPeople = new ToolStripMenuItem();
            this.miUsers = new ToolStripMenuItem();
            this.miAccount = new ToolStripMenuItem();
            this.miSignOut = new ToolStripMenuItem();
            this.pnlBackground = new Panel();
            this.iconBackground = new IconGlyph();
            this.lblBackgroundCaption = new Label();
            this.menuStrip1.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.BackColor = AppTheme.Surface;
            this.menuStrip1.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.menuStrip1.ForeColor = AppTheme.TextPrimary;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.miApplications, this.miPeople, this.miUsers, this.miAccount });
            this.menuStrip1.Padding = new Padding(12, 6, 0, 6);
            //
            // miApplications
            //
            this.miApplications.Text = "Applications";
            this.miApplications.DropDownItems.AddRange(new ToolStripItem[] {
                this.miManageApplicationTypes, this.miManageLDApplications, this.miNewInternationalLicense });
            //
            // miManageApplicationTypes
            //
            this.miManageApplicationTypes.Text = "Manage Application Types";
            this.miManageApplicationTypes.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            //
            // miManageLDApplications
            //
            this.miManageLDApplications.Text = "Local Driving License Applications";
            this.miManageLDApplications.Click += new System.EventHandler(this.manageLDApplicationsToolStripMenuItem_Click);
            //
            // miNewInternationalLicense
            //
            this.miNewInternationalLicense.Text = "New International License";
            this.miNewInternationalLicense.Click += new System.EventHandler(this.newInternationalLicenseToolStripMenuItem_Click);
            //
            // miPeople
            //
            this.miPeople.Text = "People";
            this.miPeople.Click += new System.EventHandler(this.managePeopleToolStripMenuItem_Click);
            //
            // miUsers
            //
            this.miUsers.Text = "Users";
            this.miUsers.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            //
            // miAccount
            //
            this.miAccount.Text = "Account Settings";
            this.miAccount.DropDownItems.AddRange(new ToolStripItem[] { this.miSignOut });
            //
            // miSignOut
            //
            this.miSignOut.Text = "Sign Out";
            this.miSignOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            //
            // pnlBackground
            //
            this.pnlBackground.BackColor = AppTheme.Navy;
            this.pnlBackground.Dock = DockStyle.Fill;
            this.pnlBackground.Controls.Add(this.lblBackgroundCaption);
            this.pnlBackground.Controls.Add(this.iconBackground);
            //
            // iconBackground
            //
            this.iconBackground.Icon = IconKind.Car;
            this.iconBackground.Tint = Color.FromArgb(90, 92, 118);
            this.iconBackground.Size = new Size(160, 160);
            this.iconBackground.Anchor = AnchorStyles.None;
            //
            // lblBackgroundCaption
            //
            this.lblBackgroundCaption.AutoSize = true;
            this.lblBackgroundCaption.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
            this.lblBackgroundCaption.ForeColor = Color.FromArgb(90, 92, 118);
            this.lblBackgroundCaption.Text = "DVLD";
            this.lblBackgroundCaption.Anchor = AnchorStyles.None;
            //
            // MainForm
            //
            this.ClientSize = new Size(1200, 720);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.IsMdiContainer = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "DVLD - Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
