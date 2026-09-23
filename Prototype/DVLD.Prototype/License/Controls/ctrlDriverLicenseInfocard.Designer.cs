using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.License.Controls
{
    partial class ctrlDriverLicenseInfocard
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox gbDriverLicenseInfo;
        private PictureBox pbImage;

        private Label lblClass, lblClassValue;
        private Label lblName, lblNameValue;
        private Label lblLicenseID, lblLicenseIDValue;
        private Label lblNationalNo, lblNationalNoValue;
        private Label lblGender, lblGenderValue;
        private Label lblIssueDate, lblIssueDateValue;
        private Label lblExpirationDate, lblExpirationDateValue;
        private Label lblIsActive, lblIsActiveValue;
        private Label lblIsDetained, lblIsDetainedValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbDriverLicenseInfo = new GroupBox();
            this.pbImage = new PictureBox();
            this.lblClass = new Label(); this.lblClassValue = new Label();
            this.lblName = new Label(); this.lblNameValue = new Label();
            this.lblLicenseID = new Label(); this.lblLicenseIDValue = new Label();
            this.lblNationalNo = new Label(); this.lblNationalNoValue = new Label();
            this.lblGender = new Label(); this.lblGenderValue = new Label();
            this.lblIssueDate = new Label(); this.lblIssueDateValue = new Label();
            this.lblExpirationDate = new Label(); this.lblExpirationDateValue = new Label();
            this.lblIsActive = new Label(); this.lblIsActiveValue = new Label();
            this.lblIsDetained = new Label(); this.lblIsDetainedValue = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbDriverLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // gbDriverLicenseInfo
            //
            this.gbDriverLicenseInfo.Dock = DockStyle.Fill;
            this.gbDriverLicenseInfo.Font = AppTheme.FontSectionTitle;
            this.gbDriverLicenseInfo.Text = "Driver License Information";
            this.gbDriverLicenseInfo.Controls.Add(this.pbImage);
            //
            // pbImage
            //
            this.pbImage.BorderStyle = BorderStyle.FixedSingle;
            this.pbImage.Location = new Point(20, 36);
            this.pbImage.Size = new Size(150, 150);
            this.pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbImage.BackColor = AppTheme.SurfaceAlt;

            int col1X = 200, col2X = 520, rowH = 44, top = 36;
            AddPair(this.gbDriverLicenseInfo, IconKind.Car, ref this.lblClass, ref this.lblClassValue, "Class", col1X, top + rowH * 0);
            AddPair(this.gbDriverLicenseInfo, IconKind.Person, ref this.lblName, ref this.lblNameValue, "Name", col1X, top + rowH * 1);
            AddPair(this.gbDriverLicenseInfo, IconKind.IdCard, ref this.lblLicenseID, ref this.lblLicenseIDValue, "License ID", col1X, top + rowH * 2);
            AddPair(this.gbDriverLicenseInfo, IconKind.IdCard, ref this.lblNationalNo, ref this.lblNationalNoValue, "National No", col1X, top + rowH * 3);
            AddPair(this.gbDriverLicenseInfo, IconKind.Gender, ref this.lblGender, ref this.lblGenderValue, "Gender", col1X, top + rowH * 4);

            AddPair(this.gbDriverLicenseInfo, IconKind.Calendar, ref this.lblIssueDate, ref this.lblIssueDateValue, "Issue Date", col2X, top + rowH * 0);
            AddPair(this.gbDriverLicenseInfo, IconKind.Calendar, ref this.lblExpirationDate, ref this.lblExpirationDateValue, "Expiration Date", col2X, top + rowH * 1);
            AddPair(this.gbDriverLicenseInfo, IconKind.Check, ref this.lblIsActive, ref this.lblIsActiveValue, "Is Active?", col2X, top + rowH * 2);
            AddPair(this.gbDriverLicenseInfo, IconKind.Warning, ref this.lblIsDetained, ref this.lblIsDetainedValue, "Is Detained?", col2X, top + rowH * 3);
            //
            // ctrlDriverLicenseInfocard
            //
            this.Controls.Add(this.gbDriverLicenseInfo);
            this.Size = new Size(920, 260);
            this.BackColor = AppTheme.Surface;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbDriverLicenseInfo.ResumeLayout(false);
            this.gbDriverLicenseInfo.PerformLayout();
            this.ResumeLayout(false);
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
            value.Text = "??";
            value.MaximumSize = new Size(280, 0);
            parent.Controls.Add(ic);
            parent.Controls.Add(caption);
            parent.Controls.Add(value);
        }
    }
}
