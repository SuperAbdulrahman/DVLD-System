namespace DVLD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTests = new System.Windows.Forms.Button();
            this.pbMainBackground = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownApplications = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLiceneseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownPeople = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownDrivers = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownAccountSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownApplications,
            this.toolStripDropDownPeople,
            this.toolStripDropDownDrivers,
            this.toolStripDropDownUsers,
            this.toolStripDropDownAccountSettings});
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(41, 41);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(126, 149);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(116, 90);
            this.btnTests.TabIndex = 3;
            this.btnTests.Text = "test";
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // pbMainBackground
            // 
            this.pbMainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainBackground.Image = global::DVLD.Properties.Resources.Logo_Final;
            this.pbMainBackground.Location = new System.Drawing.Point(0, 25);
            this.pbMainBackground.Name = "pbMainBackground";
            this.pbMainBackground.Size = new System.Drawing.Size(1141, 568);
            this.pbMainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainBackground.TabIndex = 1;
            this.pbMainBackground.TabStop = false;
            // 
            // toolStripDropDownApplications
            // 
            this.toolStripDropDownApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.toolStripDropDownApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownApplications.Image = global::DVLD.Properties.Resources.Applications_64;
            this.toolStripDropDownApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownApplications.Name = "toolStripDropDownApplications";
            this.toolStripDropDownApplications.ShowDropDownArrow = false;
            this.toolStripDropDownApplications.Size = new System.Drawing.Size(186, 68);
            this.toolStripDropDownApplications.Text = "Applications";
            this.toolStripDropDownApplications.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewToolStripMenuItem,
            this.replacementForToolStripMenuItem,
            this.realToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(374, 70);
            this.toolStripMenuItem2.Text = " Driving Licenses Services ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(415, 38);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.localLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.localLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.renewToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.renewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(415, 38);
            this.renewToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForToolStripMenuItem
            // 
            this.replacementForToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.replacementForToolStripMenuItem.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForToolStripMenuItem.Name = "replacementForToolStripMenuItem";
            this.replacementForToolStripMenuItem.Size = new System.Drawing.Size(415, 38);
            this.replacementForToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // realToolStripMenuItem
            // 
            this.realToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.realToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            this.realToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.realToolStripMenuItem.Name = "realToolStripMenuItem";
            this.realToolStripMenuItem.Size = new System.Drawing.Size(415, 38);
            this.realToolStripMenuItem.Text = "Release Detained Driving License";
            this.realToolStripMenuItem.Click += new System.EventHandler(this.realToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.retakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(415, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLiceneseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(374, 70);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLiceneseApplicationsToolStripMenuItem
            // 
            this.localDrivingLiceneseApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.localDrivingLiceneseApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.localDrivingLiceneseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLiceneseApplicationsToolStripMenuItem.Name = "localDrivingLiceneseApplicationsToolStripMenuItem";
            this.localDrivingLiceneseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(378, 54);
            this.localDrivingLiceneseApplicationsToolStripMenuItem.Text = "Local Driving Licenese Applications";
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.internationalLicenseApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(378, 54);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.Detain_64;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(374, 70);
            this.toolStripMenuItem1.Text = "Detain License";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.manageDetainedLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_512;
            this.manageDetainedLicensesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses ";
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_512;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaToolStripMenuItem
            // 
            this.releaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.releaToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_512;
            this.releaToolStripMenuItem.Name = "releaToolStripMenuItem";
            this.releaToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.releaToolStripMenuItem.Text = "Release Detained License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(374, 70);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types ";
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(374, 70);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            // 
            // toolStripDropDownPeople
            // 
            this.toolStripDropDownPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownPeople.Image = global::DVLD.Properties.Resources.People_64;
            this.toolStripDropDownPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownPeople.Name = "toolStripDropDownPeople";
            this.toolStripDropDownPeople.ShowDropDownArrow = false;
            this.toolStripDropDownPeople.Size = new System.Drawing.Size(137, 68);
            this.toolStripDropDownPeople.Text = "People";
            this.toolStripDropDownPeople.Click += new System.EventHandler(this.toolStripDropDownPeople_Click);
            // 
            // toolStripDropDownDrivers
            // 
            this.toolStripDropDownDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownDrivers.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.toolStripDropDownDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownDrivers.Name = "toolStripDropDownDrivers";
            this.toolStripDropDownDrivers.ShowDropDownArrow = false;
            this.toolStripDropDownDrivers.Size = new System.Drawing.Size(141, 68);
            this.toolStripDropDownDrivers.Text = "Drivers";
            // 
            // toolStripDropDownUsers
            // 
            this.toolStripDropDownUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownUsers.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.toolStripDropDownUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownUsers.Name = "toolStripDropDownUsers";
            this.toolStripDropDownUsers.ShowDropDownArrow = false;
            this.toolStripDropDownUsers.Size = new System.Drawing.Size(126, 68);
            this.toolStripDropDownUsers.Text = "Users";
            // 
            // toolStripDropDownAccountSettings
            // 
            this.toolStripDropDownAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.toolStripDropDownAccountSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownAccountSettings.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.toolStripDropDownAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownAccountSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownAccountSettings.Name = "toolStripDropDownAccountSettings";
            this.toolStripDropDownAccountSettings.ShowDropDownArrow = false;
            this.toolStripDropDownAccountSettings.Size = new System.Drawing.Size(225, 68);
            this.toolStripDropDownAccountSettings.Text = "Account Settings";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.currentUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.currentUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.currentUserToolStripMenuItem.Text = "Current User Info";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.logOutToolStripMenuItem.Text = "Sign Out";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 593);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.pbMainBackground);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMainBackground;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownApplications;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownPeople;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownDrivers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownUsers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownAccountSettings;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLiceneseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaToolStripMenuItem;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}