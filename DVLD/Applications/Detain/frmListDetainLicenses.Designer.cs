namespace DVLD.Applications.Detain
{
    partial class frmListDetainLicenses
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblRecordsCountValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvDetainedLicensesList = new System.Windows.Forms.DataGridView();
            this.pbManageApplicationsTypesIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.cbIsReleasedFilter = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainedLicensetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).BeginInit();
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
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(108, 234);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(188, 31);
            this.cbFilterByOptions.TabIndex = 28;
            this.cbFilterByOptions.ValueMember = "0";
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // txtbFilterSearchBar
            // 
            this.txtbFilterSearchBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtbFilterSearchBar.Location = new System.Drawing.Point(302, 237);
            this.txtbFilterSearchBar.Name = "txtbFilterSearchBar";
            this.txtbFilterSearchBar.Size = new System.Drawing.Size(501, 28);
            this.txtbFilterSearchBar.TabIndex = 27;
            this.txtbFilterSearchBar.TextChanged += new System.EventHandler(this.txtbFilterSearchBar_TextChanged);
            this.txtbFilterSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterSearchBar_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1181, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(4, 230);
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
            this.lblRecordsCountValue.Location = new System.Drawing.Point(127, 566);
            this.lblRecordsCountValue.Name = "lblRecordsCountValue";
            this.lblRecordsCountValue.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsCountValue.TabIndex = 24;
            this.lblRecordsCountValue.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(5, 566);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(106, 28);
            this.lblRecords.TabIndex = 23;
            this.lblRecords.Text = "#Records: ";
            // 
            // dgvDetainedLicensesList
            // 
            this.dgvDetainedLicensesList.AllowUserToAddRows = false;
            this.dgvDetainedLicensesList.AllowUserToDeleteRows = false;
            this.dgvDetainedLicensesList.AllowUserToOrderColumns = true;
            this.dgvDetainedLicensesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicensesList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicensesList.Location = new System.Drawing.Point(12, 271);
            this.dgvDetainedLicensesList.Name = "dgvDetainedLicensesList";
            this.dgvDetainedLicensesList.ReadOnly = true;
            this.dgvDetainedLicensesList.RowHeadersWidth = 51;
            this.dgvDetainedLicensesList.RowTemplate.Height = 26;
            this.dgvDetainedLicensesList.Size = new System.Drawing.Size(1323, 274);
            this.dgvDetainedLicensesList.TabIndex = 22;
            // 
            // pbManageApplicationsTypesIcon
            // 
            this.pbManageApplicationsTypesIcon.Image = global::DVLD.Properties.Resources.Detain_512;
            this.pbManageApplicationsTypesIcon.Location = new System.Drawing.Point(603, 12);
            this.pbManageApplicationsTypesIcon.Name = "pbManageApplicationsTypesIcon";
            this.pbManageApplicationsTypesIcon.Size = new System.Drawing.Size(246, 153);
            this.pbManageApplicationsTypesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApplicationsTypesIcon.TabIndex = 21;
            this.pbManageApplicationsTypesIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(483, 168);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 54);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Manage Detained Licenses";
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(1197, 218);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(138, 43);
            this.btnDetain.TabIndex = 31;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelease.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(1053, 218);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(138, 43);
            this.btnRelease.TabIndex = 32;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // cbIsReleasedFilter
            // 
            this.cbIsReleasedFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleasedFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbIsReleasedFilter.FormattingEnabled = true;
            this.cbIsReleasedFilter.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleasedFilter.Location = new System.Drawing.Point(302, 234);
            this.cbIsReleasedFilter.Name = "cbIsReleasedFilter";
            this.cbIsReleasedFilter.Size = new System.Drawing.Size(122, 31);
            this.cbIsReleasedFilter.TabIndex = 33;
            this.cbIsReleasedFilter.Visible = false;
            this.cbIsReleasedFilter.SelectedIndexChanged += new System.EventHandler(this.cbIsReleasedFilter_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.ShowLicenseInfoToolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem,
            this.ReleaseDetainedLicensetoolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(277, 184);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            // ShowLicenseInfoToolStripMenuItem
            // 
            this.ShowLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.ShowLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseInfoToolStripMenuItem.Name = "ShowLicenseInfoToolStripMenuItem";
            this.ShowLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.ShowLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.ShowLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseInfoToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // ReleaseDetainedLicensetoolStripMenuItem1
            // 
            this.ReleaseDetainedLicensetoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ReleaseDetainedLicensetoolStripMenuItem1.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.ReleaseDetainedLicensetoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetainedLicensetoolStripMenuItem1.Name = "ReleaseDetainedLicensetoolStripMenuItem1";
            this.ReleaseDetainedLicensetoolStripMenuItem1.Size = new System.Drawing.Size(276, 38);
            this.ReleaseDetainedLicensetoolStripMenuItem1.Text = "Release Detained License";
            this.ReleaseDetainedLicensetoolStripMenuItem1.Click += new System.EventHandler(this.ReleaseDetainedLicensetoolStripMenuItem1_Click);
            // 
            // frmListDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 608);
            this.Controls.Add(this.cbIsReleasedFilter);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.txtbFilterSearchBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvDetainedLicensesList);
            this.Controls.Add(this.pbManageApplicationsTypesIcon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListDetainLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.frmListDetainLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilterByOptions;
        private System.Windows.Forms.TextBox txtbFilterSearchBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblRecordsCountValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvDetainedLicensesList;
        private System.Windows.Forms.PictureBox pbManageApplicationsTypesIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.ComboBox cbIsReleasedFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedLicensetoolStripMenuItem1;
    }
}