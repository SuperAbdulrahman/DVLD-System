namespace DVLD.Applications.Detain
{
    partial class frmDetainLicense
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
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.numericUpDownFees = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblDetainDateValue = new System.Windows.Forms.Label();
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblDetainIDValue = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lliShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lliShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.License.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.numericUpDownFees);
            this.gbDetainInfo.Controls.Add(this.pictureBox5);
            this.gbDetainInfo.Controls.Add(this.pictureBox2);
            this.gbDetainInfo.Controls.Add(this.lblFineFees);
            this.gbDetainInfo.Controls.Add(this.lblCreatedByValue);
            this.gbDetainInfo.Controls.Add(this.lblDetainDateValue);
            this.gbDetainInfo.Controls.Add(this.lblLicenseIDValue);
            this.gbDetainInfo.Controls.Add(this.lblDetainIDValue);
            this.gbDetainInfo.Controls.Add(this.pictureBox4);
            this.gbDetainInfo.Controls.Add(this.lblDetainID);
            this.gbDetainInfo.Controls.Add(this.pictureBox9);
            this.gbDetainInfo.Controls.Add(this.pictureBox7);
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Controls.Add(this.lblDetainDate);
            this.gbDetainInfo.Controls.Add(this.lblLicenseID);
            this.gbDetainInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetainInfo.Location = new System.Drawing.Point(12, 575);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(1022, 172);
            this.gbDetainInfo.TabIndex = 77;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info:";
            // 
            // numericUpDownFees
            // 
            this.numericUpDownFees.DecimalPlaces = 2;
            this.numericUpDownFees.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numericUpDownFees.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownFees.Location = new System.Drawing.Point(228, 131);
            this.numericUpDownFees.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownFees.Name = "numericUpDownFees";
            this.numericUpDownFees.Size = new System.Drawing.Size(138, 30);
            this.numericUpDownFees.TabIndex = 88;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(187, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblFineFees.Location = new System.Drawing.Point(19, 126);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(102, 28);
            this.lblFineFees.TabIndex = 63;
            this.lblFineFees.Text = "Fine Fees:";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCreatedByValue.Location = new System.Drawing.Point(750, 92);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(28, 25);
            this.lblCreatedByValue.TabIndex = 53;
            this.lblCreatedByValue.Text = "??";
            // 
            // lblDetainDateValue
            // 
            this.lblDetainDateValue.AutoSize = true;
            this.lblDetainDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetainDateValue.Location = new System.Drawing.Point(223, 86);
            this.lblDetainDateValue.Name = "lblDetainDateValue";
            this.lblDetainDateValue.Size = new System.Drawing.Size(28, 25);
            this.lblDetainDateValue.TabIndex = 51;
            this.lblDetainDateValue.Text = "??";
            // 
            // lblLicenseIDValue
            // 
            this.lblLicenseIDValue.AutoSize = true;
            this.lblLicenseIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLicenseIDValue.Location = new System.Drawing.Point(750, 36);
            this.lblLicenseIDValue.Name = "lblLicenseIDValue";
            this.lblLicenseIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblLicenseIDValue.TabIndex = 47;
            this.lblLicenseIDValue.Text = "??";
            // 
            // lblDetainIDValue
            // 
            this.lblDetainIDValue.AutoSize = true;
            this.lblDetainIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetainIDValue.Location = new System.Drawing.Point(223, 46);
            this.lblDetainIDValue.Name = "lblDetainIDValue";
            this.lblDetainIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblDetainIDValue.TabIndex = 46;
            this.lblDetainIDValue.Text = "??";
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
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblDetainID.Location = new System.Drawing.Point(19, 43);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(102, 28);
            this.lblDetainID.TabIndex = 44;
            this.lblDetainID.Text = "Detain ID:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Person_32;
            this.pictureBox9.Location = new System.Drawing.Point(714, 86);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(504, 92);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(115, 28);
            this.lblCreatedBy.TabIndex = 39;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblDetainDate.Location = new System.Drawing.Point(19, 84);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(124, 28);
            this.lblDetainDate.TabIndex = 37;
            this.lblDetainDate.Text = "Detain Date:";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.Location = new System.Drawing.Point(500, 35);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(110, 28);
            this.lblLicenseID.TabIndex = 29;
            this.lblLicenseID.Text = "License ID:";
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetain.Enabled = false;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(901, 753);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(133, 43);
            this.btnDetain.TabIndex = 75;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(739, 753);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 43);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lliShowLicenseInfo
            // 
            this.lliShowLicenseInfo.AutoSize = true;
            this.lliShowLicenseInfo.Enabled = false;
            this.lliShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseInfo.Location = new System.Drawing.Point(197, 763);
            this.lliShowLicenseInfo.Name = "lliShowLicenseInfo";
            this.lliShowLicenseInfo.Size = new System.Drawing.Size(152, 23);
            this.lliShowLicenseInfo.TabIndex = 73;
            this.lliShowLicenseInfo.TabStop = true;
            this.lliShowLicenseInfo.Text = "Show License Info:";
            this.lliShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseInfo_LinkClicked);
            // 
            // lliShowLicenseHistory
            // 
            this.lliShowLicenseHistory.AutoSize = true;
            this.lliShowLicenseHistory.Enabled = false;
            this.lliShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseHistory.Location = new System.Drawing.Point(15, 763);
            this.lliShowLicenseHistory.Name = "lliShowLicenseHistory";
            this.lliShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.lliShowLicenseHistory.TabIndex = 74;
            this.lliShowLicenseHistory.TabStop = true;
            this.lliShowLicenseHistory.Text = "Show Licnese History";
            this.lliShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseHistory_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(348, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 54);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Detain License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-8, 51);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1053, 532);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 89;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 800);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lliShowLicenseInfo);
            this.Controls.Add(this.lliShowLicenseHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblDetainDateValue;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblDetainIDValue;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lliShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lliShowLicenseHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownFees;
        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}