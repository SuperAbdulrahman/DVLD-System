using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.People.Controls
{
    partial class ctrlPersonCard
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox gbPersonInfo;
        private PictureBox pbImage;
        private LinkLabel llEditInfo;

        private Label lblPersonID, lblPersonIDValue;
        private Label lblName, lblFullNameValue;
        private Label lblNationalNo, lblNationalNoValue;
        private Label lblGender, lblGenderValue;
        private Label lblEmail, lblEmailValue;
        private Label lblAddress, lblAddressValue;
        private Label lblDateOfBirth, lblDOBValue;
        private Label lblPhone, lblPhoneValue;
        private Label lblCountry, lblCountryValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbPersonInfo = new GroupBox();
            this.pbImage = new PictureBox();
            this.llEditInfo = new LinkLabel();
            this.lblPersonID = new Label(); this.lblPersonIDValue = new Label();
            this.lblName = new Label(); this.lblFullNameValue = new Label();
            this.lblNationalNo = new Label(); this.lblNationalNoValue = new Label();
            this.lblGender = new Label(); this.lblGenderValue = new Label();
            this.lblEmail = new Label(); this.lblEmailValue = new Label();
            this.lblAddress = new Label(); this.lblAddressValue = new Label();
            this.lblDateOfBirth = new Label(); this.lblDOBValue = new Label();
            this.lblPhone = new Label(); this.lblPhoneValue = new Label();
            this.lblCountry = new Label(); this.lblCountryValue = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbPersonInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // gbPersonInfo
            //
            this.gbPersonInfo.Dock = DockStyle.Fill;
            this.gbPersonInfo.Font = AppTheme.FontSectionTitle;
            this.gbPersonInfo.ForeColor = AppTheme.TextPrimary;
            this.gbPersonInfo.Text = "Person Information";
            this.gbPersonInfo.Controls.Add(this.pbImage);
            this.gbPersonInfo.Controls.Add(this.llEditInfo);
            //
            // pbImage
            //
            this.pbImage.BorderStyle = BorderStyle.FixedSingle;
            this.pbImage.Location = new Point(20, 36);
            this.pbImage.Size = new Size(150, 150);
            this.pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbImage.BackColor = AppTheme.SurfaceAlt;
            //
            // llEditInfo
            //
            this.llEditInfo.AutoSize = true;
            this.llEditInfo.Font = AppTheme.FontSmall;
            this.llEditInfo.LinkColor = AppTheme.Navy;
            this.llEditInfo.Location = new Point(20, 196);
            this.llEditInfo.Text = "Edit Person Info";
            this.llEditInfo.LinkClicked += new LinkLabelLinkClickedEventHandler(this.llEditInfo_LinkClicked);

            int col1X = 200, col2X = 520, rowH = 44, top = 36;
            AddPair(this.gbPersonInfo, IconKind.IdCard, ref this.lblPersonID, ref this.lblPersonIDValue, "Person ID", col1X, top + rowH * 0);
            AddPair(this.gbPersonInfo, IconKind.Person, ref this.lblName, ref this.lblFullNameValue, "Full Name", col1X, top + rowH * 1);
            AddPair(this.gbPersonInfo, IconKind.IdCard, ref this.lblNationalNo, ref this.lblNationalNoValue, "National No", col1X, top + rowH * 2);
            AddPair(this.gbPersonInfo, IconKind.Gender, ref this.lblGender, ref this.lblGenderValue, "Gender", col1X, top + rowH * 3);
            AddPair(this.gbPersonInfo, IconKind.Calendar, ref this.lblDateOfBirth, ref this.lblDOBValue, "Date Of Birth", col1X, top + rowH * 4);

            AddPair(this.gbPersonInfo, IconKind.Mail, ref this.lblEmail, ref this.lblEmailValue, "Email", col2X, top + rowH * 0);
            AddPair(this.gbPersonInfo, IconKind.Phone, ref this.lblPhone, ref this.lblPhoneValue, "Phone", col2X, top + rowH * 1);
            AddPair(this.gbPersonInfo, IconKind.Address, ref this.lblAddress, ref this.lblAddressValue, "Address", col2X, top + rowH * 2);
            AddPair(this.gbPersonInfo, IconKind.Globe, ref this.lblCountry, ref this.lblCountryValue, "Country", col2X, top + rowH * 3);
            //
            // ctrlPersonCard
            //
            this.Controls.Add(this.gbPersonInfo);
            this.Size = new Size(920, 260);
            this.BackColor = AppTheme.Surface;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
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
