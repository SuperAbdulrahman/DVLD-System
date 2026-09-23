using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.License.Controls;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.License
{
    partial class frmNewInternationalLicense
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gbApplicationBasicInfo;
        private LinkLabel lliShowLicenseInfo;
        private Button btnIssue;
        private Button btnClose;

        private Label lblILAppID, lblILAppIDValue;
        private Label lblApplicationDate, lblApplicationDateValue;
        private Label lblFees, lblFeesValue;
        private Label lblILicenseID, lblILicenseIDValue;
        private Label lblIssueDate, lblIssueDateValue;
        private Label lblExpirationDate, lblExpirationDateValue;
        private Label lblLocalLicenseID, lblLocalLicenseIDValue;
        private Label lblCreatedBy, lblCreatedByValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.iconTitle = new IconGlyph();
            this.ctrlDriverLicenseInfoWithFilter1 = new ctrlDriverLicenseInfoWithFilter();
            this.gbApplicationBasicInfo = new GroupBox();
            this.lliShowLicenseInfo = new LinkLabel();
            this.btnIssue = new Button();
            this.btnClose = new Button();
            this.lblILAppID = new Label(); this.lblILAppIDValue = new Label();
            this.lblApplicationDate = new Label(); this.lblApplicationDateValue = new Label();
            this.lblFees = new Label(); this.lblFeesValue = new Label();
            this.lblILicenseID = new Label(); this.lblILicenseIDValue = new Label();
            this.lblIssueDate = new Label(); this.lblIssueDateValue = new Label();
            this.lblExpirationDate = new Label(); this.lblExpirationDateValue = new Label();
            this.lblLocalLicenseID = new Label(); this.lblLocalLicenseIDValue = new Label();
            this.lblCreatedBy = new Label(); this.lblCreatedByValue = new Label();
            this.gbApplicationBasicInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // iconTitle
            //
            this.iconTitle.Icon = IconKind.Globe;
            this.iconTitle.Tint = AppTheme.Accent;
            this.iconTitle.Location = new Point(24, 20);
            this.iconTitle.Size = new Size(32, 32);
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(64, 20);
            this.lblTitle.Text = "New International License Application";
            //
            // ctrlDriverLicenseInfoWithFilter1
            //
            this.ctrlDriverLicenseInfoWithFilter1.Location = new Point(24, 66);
            this.ctrlDriverLicenseInfoWithFilter1.Size = new Size(940, 360);
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.EventHandler<string>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            //
            // gbApplicationBasicInfo
            //
            this.gbApplicationBasicInfo.Location = new Point(24, 440);
            this.gbApplicationBasicInfo.Size = new Size(940, 200);
            this.gbApplicationBasicInfo.Font = AppTheme.FontSectionTitle;
            this.gbApplicationBasicInfo.Text = "International License Application Info";
            this.gbApplicationBasicInfo.Controls.Add(this.lliShowLicenseInfo);

            int col1X = 30, col2X = 350, col3X = 670, rowH = 44, top = 36;
            AddPair(this.gbApplicationBasicInfo, IconKind.IdCard, ref this.lblILAppID, ref this.lblILAppIDValue, "I.L.App ID", col1X, top);
            AddPair(this.gbApplicationBasicInfo, IconKind.Calendar, ref this.lblApplicationDate, ref this.lblApplicationDateValue, "Application Date", col1X, top + rowH);
            AddPair(this.gbApplicationBasicInfo, IconKind.Money, ref this.lblFees, ref this.lblFeesValue, "Fees", col1X, top + rowH * 2);
            AddPair(this.gbApplicationBasicInfo, IconKind.IdCard, ref this.lblILicenseID, ref this.lblILicenseIDValue, "I.License ID", col2X, top);
            AddPair(this.gbApplicationBasicInfo, IconKind.Calendar, ref this.lblIssueDate, ref this.lblIssueDateValue, "Issue Date", col2X, top + rowH);
            AddPair(this.gbApplicationBasicInfo, IconKind.Calendar, ref this.lblExpirationDate, ref this.lblExpirationDateValue, "Expiration Date", col2X, top + rowH * 2);
            AddPair(this.gbApplicationBasicInfo, IconKind.IdCard, ref this.lblLocalLicenseID, ref this.lblLocalLicenseIDValue, "Local License ID", col3X, top);
            AddPair(this.gbApplicationBasicInfo, IconKind.Person, ref this.lblCreatedBy, ref this.lblCreatedByValue, "Created By", col3X, top + rowH);
            //
            // lliShowLicenseInfo
            //
            this.lliShowLicenseInfo.AutoSize = true;
            this.lliShowLicenseInfo.Enabled = false;
            this.lliShowLicenseInfo.Font = AppTheme.FontSmall;
            this.lliShowLicenseInfo.Location = new Point(col3X, top + rowH * 2);
            this.lliShowLicenseInfo.Text = "Show License Info";
            this.lliShowLicenseInfo.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lliShowLicenseInfo_LinkClicked);
            //
            // btnIssue
            //
            AppTheme.ApplyPrimaryButton(this.btnIssue);
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new Point(24, 654);
            this.btnIssue.Size = new Size(200, 38);
            this.btnIssue.Text = "Issue License";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(864, 654);
            this.btnClose.Size = new Size(100, 38);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // frmNewInternationalLicense
            //
            this.ClientSize = new Size(988, 716);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.gbApplicationBasicInfo);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.CancelButton = this.btnClose;
            this.Text = "New International License Application";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.gbApplicationBasicInfo.ResumeLayout(false);
            this.gbApplicationBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AddPair(GroupBox parent, IconKind icon, ref Label caption, ref Label value, string text, int x, int y)
        {
            var ic = new IconGlyph { Icon = icon, Tint = AppTheme.Navy, Location = new Point(x, y), Size = new Size(18, 18) };
            caption.AutoSize = true;
            AppTheme.ApplyCaption(caption);
            caption.Location = new Point(x + 26, y - 2);
            caption.Text = text;
            value.AutoSize = true;
            AppTheme.ApplyValue(value);
            value.Location = new Point(x + 26, y + 16);
            value.Text = "N/A";
            value.MaximumSize = new Size(260, 0);
            parent.Controls.Add(ic);
            parent.Controls.Add(caption);
            parent.Controls.Add(value);
        }
    }
}
