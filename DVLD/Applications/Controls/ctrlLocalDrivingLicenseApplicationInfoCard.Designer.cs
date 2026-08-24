namespace DVLD.Applications.Controls
{
    partial class ctrlLocalDrivingLicenseApplicationInfoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDrivingLicenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lblPassedTestsValue = new System.Windows.Forms.Label();
            this.lblAppliedForLicenseValue = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.lblAppliedForLicense = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPersonID = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ctrlApplicationBasicInfoCard1 = new DVLD.Applications.Controls.ctrlApplicationBasicInfoCard();
            this.gbDrivingLicenseApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDrivingLicenseApplicationInfo
            // 
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.pictureBox2);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.pictureBox1);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.llShowLicenseInfo);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblDLAppID);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblPassedTestsValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblAppliedForLicenseValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblDLAppIDValue);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.pbPersonID);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.pictureBox3);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblPassedTests);
            this.gbDrivingLicenseApplicationInfo.Controls.Add(this.lblAppliedForLicense);
            this.gbDrivingLicenseApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(14, 16);
            this.gbDrivingLicenseApplicationInfo.Name = "gbDrivingLicenseApplicationInfo";
            this.gbDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(1022, 152);
            this.gbDrivingLicenseApplicationInfo.TabIndex = 1;
            this.gbDrivingLicenseApplicationInfo.TabStop = false;
            this.gbDrivingLicenseApplicationInfo.Text = "Driving License Application Info";
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(855, 111);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(148, 23);
            this.llShowLicenseInfo.TabIndex = 55;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblDLAppID.Location = new System.Drawing.Point(19, 52);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(114, 28);
            this.lblDLAppID.TabIndex = 44;
            this.lblDLAppID.Text = "D.L App ID:";
            // 
            // lblPassedTestsValue
            // 
            this.lblPassedTestsValue.AutoSize = true;
            this.lblPassedTestsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTestsValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPassedTestsValue.Location = new System.Drawing.Point(983, 55);
            this.lblPassedTestsValue.Name = "lblPassedTestsValue";
            this.lblPassedTestsValue.Size = new System.Drawing.Size(39, 25);
            this.lblPassedTestsValue.TabIndex = 50;
            this.lblPassedTestsValue.Text = "0/3";
            // 
            // lblAppliedForLicenseValue
            // 
            this.lblAppliedForLicenseValue.AutoSize = true;
            this.lblAppliedForLicenseValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedForLicenseValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAppliedForLicenseValue.Location = new System.Drawing.Point(485, 55);
            this.lblAppliedForLicenseValue.Name = "lblAppliedForLicenseValue";
            this.lblAppliedForLicenseValue.Size = new System.Drawing.Size(28, 25);
            this.lblAppliedForLicenseValue.TabIndex = 47;
            this.lblAppliedForLicenseValue.Text = "??";
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(175, 55);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblDLAppIDValue.TabIndex = 46;
            this.lblDLAppIDValue.Text = "??";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblPassedTests.Location = new System.Drawing.Point(814, 52);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(130, 28);
            this.lblPassedTests.TabIndex = 32;
            this.lblPassedTests.Text = "Passed Tests:";
            // 
            // lblAppliedForLicense
            // 
            this.lblAppliedForLicense.AutoSize = true;
            this.lblAppliedForLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppliedForLicense.Location = new System.Drawing.Point(248, 52);
            this.lblAppliedForLicense.Name = "lblAppliedForLicense";
            this.lblAppliedForLicense.Size = new System.Drawing.Size(195, 28);
            this.lblAppliedForLicense.TabIndex = 30;
            this.lblAppliedForLicense.Text = "Applied For License:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.License_View_32;
            this.pictureBox2.Location = new System.Drawing.Point(819, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PassedTests_32;
            this.pictureBox1.Location = new System.Drawing.Point(950, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // pbPersonID
            // 
            this.pbPersonID.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbPersonID.Location = new System.Drawing.Point(139, 52);
            this.pbPersonID.Name = "pbPersonID";
            this.pbPersonID.Size = new System.Drawing.Size(30, 35);
            this.pbPersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonID.TabIndex = 45;
            this.pbPersonID.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.pictureBox3.Location = new System.Drawing.Point(449, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // ctrlApplicationBasicInfoCard1
            // 
            this.ctrlApplicationBasicInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlApplicationBasicInfoCard1.Location = new System.Drawing.Point(3, 156);
            this.ctrlApplicationBasicInfoCard1.Name = "ctrlApplicationBasicInfoCard1";
            this.ctrlApplicationBasicInfoCard1.Size = new System.Drawing.Size(1058, 312);
            this.ctrlApplicationBasicInfoCard1.TabIndex = 3;
            // 
            // ctrlLocalDrivingLicenseApplicationInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDrivingLicenseApplicationInfo);
            this.Controls.Add(this.ctrlApplicationBasicInfoCard1);
            this.Name = "ctrlLocalDrivingLicenseApplicationInfoCard";
            this.Size = new System.Drawing.Size(1063, 471);
            this.gbDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.gbDrivingLicenseApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDrivingLicenseApplicationInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.Label lblPassedTestsValue;
        private System.Windows.Forms.Label lblAppliedForLicenseValue;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.PictureBox pbPersonID;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label lblAppliedForLicense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlApplicationBasicInfoCard ctrlApplicationBasicInfoCard1;
    }
}
