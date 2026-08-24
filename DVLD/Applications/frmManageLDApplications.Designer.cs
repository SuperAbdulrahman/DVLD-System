namespace DVLD.Applications
{
    partial class frmManageLDApplications
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbFilterSearchBar = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblRecordsCountValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbFilterByOptions = new System.Windows.Forms.ComboBox();
            this.btnAddNewLDLApplications = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.showAppDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbManageApplicationsTypesIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(321, 188);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(635, 54);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Local Driving License Applications";
            // 
            // txtbFilterSearchBar
            // 
            this.txtbFilterSearchBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtbFilterSearchBar.Location = new System.Drawing.Point(302, 257);
            this.txtbFilterSearchBar.Name = "txtbFilterSearchBar";
            this.txtbFilterSearchBar.Size = new System.Drawing.Size(501, 28);
            this.txtbFilterSearchBar.TabIndex = 17;
            this.txtbFilterSearchBar.TextChanged += new System.EventHandler(this.txtbFilterSearchBar_TextChanged);
            this.txtbFilterSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterSearchBar_KeyPress);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(4, 250);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(105, 31);
            this.lblFilterBy.TabIndex = 15;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblRecordsCountValue
            // 
            this.lblRecordsCountValue.AutoSize = true;
            this.lblRecordsCountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRecordsCountValue.Location = new System.Drawing.Point(127, 586);
            this.lblRecordsCountValue.Name = "lblRecordsCountValue";
            this.lblRecordsCountValue.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsCountValue.TabIndex = 14;
            this.lblRecordsCountValue.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(5, 586);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(106, 28);
            this.lblRecords.TabIndex = 13;
            this.lblRecords.Text = "#Records: ";
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToOrderColumns = true;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLDLApplications.Location = new System.Drawing.Point(12, 291);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.RowHeadersWidth = 51;
            this.dgvLDLApplications.RowTemplate.Height = 26;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1293, 274);
            this.dgvLDLApplications.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.DeletetoolStripMenuItem,
            this.CanceltoolStripMenuItem,
            this.toolStripSeparator2,
            this.ScheduleTestsToolStripMenuItem,
            this.toolStripSeparator3,
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.ShowPersonLicenseHistorytoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(303, 326);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(299, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(299, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(299, 6);
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.DisplayMember = "0";
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByOptions.FormattingEnabled = true;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(108, 254);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(188, 31);
            this.cbFilterByOptions.TabIndex = 18;
            this.cbFilterByOptions.ValueMember = "0";
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // btnAddNewLDLApplications
            // 
            this.btnAddNewLDLApplications.BackgroundImage = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLDLApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLDLApplications.Location = new System.Drawing.Point(1151, 242);
            this.btnAddNewLDLApplications.Name = "btnAddNewLDLApplications";
            this.btnAddNewLDLApplications.Size = new System.Drawing.Size(154, 43);
            this.btnAddNewLDLApplications.TabIndex = 19;
            this.btnAddNewLDLApplications.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApplications.Click += new System.EventHandler(this.btnAddNewLDLApplications_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1151, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // showAppDetailsToolStripMenuItem
            // 
            this.showAppDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.showAppDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showAppDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAppDetailsToolStripMenuItem.Name = "showAppDetailsToolStripMenuItem";
            this.showAppDetailsToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.showAppDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showAppDetailsToolStripMenuItem.Click += new System.EventHandler(this.showAppDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.DeletetoolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.DeletetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem2_Click);
            // 
            // CanceltoolStripMenuItem
            // 
            this.CanceltoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.CanceltoolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.CanceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CanceltoolStripMenuItem.Name = "CanceltoolStripMenuItem";
            this.CanceltoolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.CanceltoolStripMenuItem.Text = "Cancel";
            this.CanceltoolStripMenuItem.Click += new System.EventHandler(this.CanceltoolStripMenuItem1_Click);
            // 
            // ScheduleTestsToolStripMenuItem
            // 
            this.ScheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestsToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ScheduleTestsToolStripMenuItem.Image = global::DVLD.Properties.Resources.TestType_32;
            this.ScheduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestsToolStripMenuItem.Name = "ScheduleTestsToolStripMenuItem";
            this.ScheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.ScheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestsToolStripMenuItem
            // 
            this.scheduleVisionTestsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Vision_Test_Schdule;
            this.scheduleVisionTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestsToolStripMenuItem.Name = "scheduleVisionTestsToolStripMenuItem";
            this.scheduleVisionTestsToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.scheduleVisionTestsToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestsToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestsToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Written_Test_32_Sechdule;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // IssueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Name = "IssueDrivingLicenseFirstTimeToolStripMenuItem";
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.IssueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.ShowLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistorytoolStripMenuItem
            // 
            this.ShowPersonLicenseHistorytoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowPersonLicenseHistorytoolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistorytoolStripMenuItem.Name = "ShowPersonLicenseHistorytoolStripMenuItem";
            this.ShowPersonLicenseHistorytoolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.ShowPersonLicenseHistorytoolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistorytoolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistorytoolStripMenuItem_Click);
            // 
            // pbManageApplicationsTypesIcon
            // 
            this.pbManageApplicationsTypesIcon.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pbManageApplicationsTypesIcon.Location = new System.Drawing.Point(468, 32);
            this.pbManageApplicationsTypesIcon.Name = "pbManageApplicationsTypesIcon";
            this.pbManageApplicationsTypesIcon.Size = new System.Drawing.Size(246, 153);
            this.pbManageApplicationsTypesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApplicationsTypesIcon.TabIndex = 6;
            this.pbManageApplicationsTypesIcon.TabStop = false;
            // 
            // frmManageLDApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 643);
            this.Controls.Add(this.btnAddNewLDLApplications);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.txtbFilterSearchBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.pbManageApplicationsTypesIcon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageLDApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLDApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManageApplicationsTypesIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbFilterSearchBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblRecordsCountValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.ComboBox cbFilterByOptions;
        private System.Windows.Forms.Button btnAddNewLDLApplications;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAppDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanceltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistorytoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}