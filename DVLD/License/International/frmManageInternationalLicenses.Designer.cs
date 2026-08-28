namespace DVLD.License.International
{
    partial class frmManageInternationalLicenses
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
            this.cbFilterByOptions = new System.Windows.Forms.ComboBox();
            this.txtbFilterSearchBar = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblRecordsCountValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvInternationalLicenesApplications = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNewInternationalLicenseApp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbManageApplicationsTypesIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenesApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.DisplayMember = "0";
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByOptions.FormattingEnabled = true;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(115, 247);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(188, 31);
            this.cbFilterByOptions.TabIndex = 28;
            this.cbFilterByOptions.ValueMember = "0";
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // txtbFilterSearchBar
            // 
            this.txtbFilterSearchBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtbFilterSearchBar.Location = new System.Drawing.Point(309, 250);
            this.txtbFilterSearchBar.Name = "txtbFilterSearchBar";
            this.txtbFilterSearchBar.Size = new System.Drawing.Size(501, 28);
            this.txtbFilterSearchBar.TabIndex = 27;
            this.txtbFilterSearchBar.TextChanged += new System.EventHandler(this.txtbFilterSearchBar_TextChanged);
            this.txtbFilterSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterSearchBar_KeyPress);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(11, 243);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(105, 31);
            this.lblFilterBy.TabIndex = 25;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblRecordsCountValue
            // 
            this.lblRecordsCountValue.AutoSize = true;
            this.lblRecordsCountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRecordsCountValue.Location = new System.Drawing.Point(134, 579);
            this.lblRecordsCountValue.Name = "lblRecordsCountValue";
            this.lblRecordsCountValue.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsCountValue.TabIndex = 24;
            this.lblRecordsCountValue.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 579);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(106, 28);
            this.lblRecords.TabIndex = 23;
            this.lblRecords.Text = "#Records: ";
            // 
            // dgvInternationalLicenesApplications
            // 
            this.dgvInternationalLicenesApplications.AllowUserToAddRows = false;
            this.dgvInternationalLicenesApplications.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenesApplications.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenesApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenesApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenesApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternationalLicenesApplications.Location = new System.Drawing.Point(19, 284);
            this.dgvInternationalLicenesApplications.Name = "dgvInternationalLicenesApplications";
            this.dgvInternationalLicenesApplications.ReadOnly = true;
            this.dgvInternationalLicenesApplications.RowHeadersWidth = 51;
            this.dgvInternationalLicenesApplications.RowTemplate.Height = 26;
            this.dgvInternationalLicenesApplications.Size = new System.Drawing.Size(1293, 274);
            this.dgvInternationalLicenesApplications.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(300, 181);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 54);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "International License Applications";
            // 
            // btnAddNewInternationalLicenseApp
            // 
            this.btnAddNewInternationalLicenseApp.BackgroundImage = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewInternationalLicenseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewInternationalLicenseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInternationalLicenseApp.Location = new System.Drawing.Point(1158, 235);
            this.btnAddNewInternationalLicenseApp.Name = "btnAddNewInternationalLicenseApp";
            this.btnAddNewInternationalLicenseApp.Size = new System.Drawing.Size(154, 43);
            this.btnAddNewInternationalLicenseApp.TabIndex = 29;
            this.btnAddNewInternationalLicenseApp.UseVisualStyleBackColor = true;
            this.btnAddNewInternationalLicenseApp.Click += new System.EventHandler(this.btnAddNewInternationalLicenseApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1158, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbManageApplicationsTypesIcon
            // 
            this.pbManageApplicationsTypesIcon.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pbManageApplicationsTypesIcon.Location = new System.Drawing.Point(475, 25);
            this.pbManageApplicationsTypesIcon.Name = "pbManageApplicationsTypesIcon";
            this.pbManageApplicationsTypesIcon.Size = new System.Drawing.Size(246, 153);
            this.pbManageApplicationsTypesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApplicationsTypesIcon.TabIndex = 21;
            this.pbManageApplicationsTypesIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.International_32;
            this.pictureBox1.Location = new System.Drawing.Point(679, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.ShowPersonLicenseHistorytoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(277, 118);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.ShowLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.ShowLicenseToolStripMenuItem.Text = "Show License ";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistorytoolStripMenuItem
            // 
            this.ShowPersonLicenseHistorytoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowPersonLicenseHistorytoolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistorytoolStripMenuItem.Name = "ShowPersonLicenseHistorytoolStripMenuItem";
            this.ShowPersonLicenseHistorytoolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.ShowPersonLicenseHistorytoolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistorytoolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistorytoolStripMenuItem_Click);
            // 
            // frmManageInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNewInternationalLicenseApp);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.txtbFilterSearchBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvInternationalLicenesApplications);
            this.Controls.Add(this.pbManageApplicationsTypesIcon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International Licenses Applications";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenesApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewInternationalLicenseApp;
        private System.Windows.Forms.ComboBox cbFilterByOptions;
        private System.Windows.Forms.TextBox txtbFilterSearchBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblRecordsCountValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvInternationalLicenesApplications;
        private System.Windows.Forms.PictureBox pbManageApplicationsTypesIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistorytoolStripMenuItem;
    }
}