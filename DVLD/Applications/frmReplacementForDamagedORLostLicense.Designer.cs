namespace DVLD.Applications
{
    partial class frmReplacementForDamagedORLostLicense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lliShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lliShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbReplacementDamgedLost = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblReplacedLostLicenseIDValue = new System.Windows.Forms.Label();
            this.lblRIAppIDValue = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRIAppID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblReplacedLostLicenseID = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamgedLicense = new System.Windows.Forms.RadioButton();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.License.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbReplacementDamgedLost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.Location = new System.Drawing.Point(850, 805);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(197, 43);
            this.btnIssueReplacement.TabIndex = 73;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(711, 805);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 43);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lliShowLicenseInfo
            // 
            this.lliShowLicenseInfo.AutoSize = true;
            this.lliShowLicenseInfo.Enabled = false;
            this.lliShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseInfo.Location = new System.Drawing.Point(210, 815);
            this.lliShowLicenseInfo.Name = "lliShowLicenseInfo";
            this.lliShowLicenseInfo.Size = new System.Drawing.Size(148, 23);
            this.lliShowLicenseInfo.TabIndex = 71;
            this.lliShowLicenseInfo.TabStop = true;
            this.lliShowLicenseInfo.Text = "Show License Info";
            this.lliShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseInfo_LinkClicked);
            // 
            // lliShowLicenseHistory
            // 
            this.lliShowLicenseHistory.AutoSize = true;
            this.lliShowLicenseHistory.Enabled = false;
            this.lliShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseHistory.Location = new System.Drawing.Point(28, 815);
            this.lliShowLicenseHistory.Name = "lliShowLicenseHistory";
            this.lliShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.lliShowLicenseHistory.TabIndex = 72;
            this.lliShowLicenseHistory.TabStop = true;
            this.lliShowLicenseHistory.Text = "Show Licnese History";
            this.lliShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseHistory_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(208, -6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(627, 54);
            this.lblTitle.TabIndex = 70;
            this.lblTitle.Text = "Replacement for Damged License";
            // 
            // gbReplacementDamgedLost
            // 
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox5);
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox8);
            this.gbReplacementDamgedLost.Controls.Add(this.lblOldLicenseIDValue);
            this.gbReplacementDamgedLost.Controls.Add(this.lblOldLicenseID);
            this.gbReplacementDamgedLost.Controls.Add(this.lblCreatedByValue);
            this.gbReplacementDamgedLost.Controls.Add(this.lblAppDateValue);
            this.gbReplacementDamgedLost.Controls.Add(this.lblAppFeesValue);
            this.gbReplacementDamgedLost.Controls.Add(this.lblReplacedLostLicenseIDValue);
            this.gbReplacementDamgedLost.Controls.Add(this.lblRIAppIDValue);
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox4);
            this.gbReplacementDamgedLost.Controls.Add(this.lblRIAppID);
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox9);
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox7);
            this.gbReplacementDamgedLost.Controls.Add(this.lblCreatedBy);
            this.gbReplacementDamgedLost.Controls.Add(this.lblAppDate);
            this.gbReplacementDamgedLost.Controls.Add(this.pictureBox10);
            this.gbReplacementDamgedLost.Controls.Add(this.lblAppFees);
            this.gbReplacementDamgedLost.Controls.Add(this.lblReplacedLostLicenseID);
            this.gbReplacementDamgedLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementDamgedLost.Location = new System.Drawing.Point(21, 637);
            this.gbReplacementDamgedLost.Name = "gbReplacementDamgedLost";
            this.gbReplacementDamgedLost.Size = new System.Drawing.Size(1022, 162);
            this.gbReplacementDamgedLost.TabIndex = 75;
            this.gbReplacementDamgedLost.TabStop = false;
            this.gbReplacementDamgedLost.Text = "License Replacement Application Info";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox5.Location = new System.Drawing.Point(714, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox8.Location = new System.Drawing.Point(714, 77);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 62;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(750, 82);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblOldLicenseIDValue.TabIndex = 61;
            this.lblOldLicenseIDValue.Text = "??";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblOldLicenseID.Location = new System.Drawing.Point(500, 77);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(148, 28);
            this.lblOldLicenseID.TabIndex = 60;
            this.lblOldLicenseID.Text = "Old License ID:";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCreatedByValue.Location = new System.Drawing.Point(750, 123);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(28, 25);
            this.lblCreatedByValue.TabIndex = 53;
            this.lblCreatedByValue.Text = "??";
            // 
            // lblAppDateValue
            // 
            this.lblAppDateValue.AutoSize = true;
            this.lblAppDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDateValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAppDateValue.Location = new System.Drawing.Point(223, 86);
            this.lblAppDateValue.Name = "lblAppDateValue";
            this.lblAppDateValue.Size = new System.Drawing.Size(28, 25);
            this.lblAppDateValue.TabIndex = 51;
            this.lblAppDateValue.Text = "??";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeesValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAppFeesValue.Location = new System.Drawing.Point(223, 122);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(28, 25);
            this.lblAppFeesValue.TabIndex = 50;
            this.lblAppFeesValue.Text = "??";
            // 
            // lblReplacedLostLicenseIDValue
            // 
            this.lblReplacedLostLicenseIDValue.AutoSize = true;
            this.lblReplacedLostLicenseIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLostLicenseIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblReplacedLostLicenseIDValue.Location = new System.Drawing.Point(750, 36);
            this.lblReplacedLostLicenseIDValue.Name = "lblReplacedLostLicenseIDValue";
            this.lblReplacedLostLicenseIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblReplacedLostLicenseIDValue.TabIndex = 47;
            this.lblReplacedLostLicenseIDValue.Text = "??";
            // 
            // lblRIAppIDValue
            // 
            this.lblRIAppIDValue.AutoSize = true;
            this.lblRIAppIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRIAppIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRIAppIDValue.Location = new System.Drawing.Point(223, 46);
            this.lblRIAppIDValue.Name = "lblRIAppIDValue";
            this.lblRIAppIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblRIAppIDValue.TabIndex = 46;
            this.lblRIAppIDValue.Text = "??";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(187, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // lblRIAppID
            // 
            this.lblRIAppID.AutoSize = true;
            this.lblRIAppID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblRIAppID.Location = new System.Drawing.Point(19, 43);
            this.lblRIAppID.Name = "lblRIAppID";
            this.lblRIAppID.Size = new System.Drawing.Size(112, 28);
            this.lblRIAppID.TabIndex = 44;
            this.lblRIAppID.Text = "L.R.App ID:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Person_32;
            this.pictureBox9.Location = new System.Drawing.Point(714, 120);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox7.Location = new System.Drawing.Point(187, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(500, 120);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(115, 28);
            this.lblCreatedBy.TabIndex = 39;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.Location = new System.Drawing.Point(19, 84);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(167, 28);
            this.lblAppDate.TabIndex = 37;
            this.lblAppDate.Text = "Application Date:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox10.Location = new System.Drawing.Point(187, 123);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(19, 123);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(166, 28);
            this.lblAppFees.TabIndex = 30;
            this.lblAppFees.Text = "Application Fees:";
            // 
            // lblReplacedLostLicenseID
            // 
            this.lblReplacedLostLicenseID.AutoSize = true;
            this.lblReplacedLostLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblReplacedLostLicenseID.Location = new System.Drawing.Point(500, 35);
            this.lblReplacedLostLicenseID.Name = "lblReplacedLostLicenseID";
            this.lblReplacedLostLicenseID.Size = new System.Drawing.Size(197, 28);
            this.lblReplacedLostLicenseID.TabIndex = 29;
            this.lblReplacedLostLicenseID.Text = "Replaced License ID:";
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamgedLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.Location = new System.Drawing.Point(12, 41);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(1025, 72);
            this.gbReplacementFor.TabIndex = 88;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(205, 33);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(136, 32);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbReplacementFor_CheckedChanged);
            // 
            // rbDamgedLicense
            // 
            this.rbDamgedLicense.AutoSize = true;
            this.rbDamgedLicense.Checked = true;
            this.rbDamgedLicense.Location = new System.Drawing.Point(16, 31);
            this.rbDamgedLicense.Name = "rbDamgedLicense";
            this.rbDamgedLicense.Size = new System.Drawing.Size(175, 32);
            this.rbDamgedLicense.TabIndex = 0;
            this.rbDamgedLicense.TabStop = true;
            this.rbDamgedLicense.Text = "Damged License";
            this.rbDamgedLicense.UseVisualStyleBackColor = true;
            this.rbDamgedLicense.CheckedChanged += new System.EventHandler(this.rbReplacementFor_CheckedChanged);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(1, 112);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1053, 532);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 2;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmReplacementForDamagedORLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 859);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.gbReplacementDamgedLost);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lliShowLicenseInfo);
            this.Controls.Add(this.lliShowLicenseHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacementForDamagedORLostLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacement For Damaged or Lost License";
            this.Load += new System.EventHandler(this.frmReplacementForDamagedORLostLicense_Load);
            this.gbReplacementDamgedLost.ResumeLayout(false);
            this.gbReplacementDamgedLost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lliShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lliShowLicenseHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbReplacementDamgedLost;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblAppDateValue;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblReplacedLostLicenseIDValue;
        private System.Windows.Forms.Label lblRIAppIDValue;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblRIAppID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblReplacedLostLicenseID;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamgedLicense;
        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}