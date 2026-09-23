using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Applications
{
    partial class frmManageLDApplications
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private Button btnAddNewLDLApplications;
        private DataGridView dgvLDLApplications;
        private Label lblRecords;
        private Label lblRecordsCountValue;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconTitle = new DVLD.Prototype.Common.IconGlyph();
            this.btnAddNewLDLApplications = new System.Windows.Forms.Button();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecordsCountValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(64, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Local Driving License Applications";
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.Transparent;
            this.iconTitle.Icon = DVLD.Prototype.Common.IconKind.Car;
            this.iconTitle.Location = new System.Drawing.Point(24, 22);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(32, 32);
            this.iconTitle.TabIndex = 6;
            this.iconTitle.Tint = System.Drawing.Color.IndianRed;
            // 
            // btnAddNewLDLApplications
            // 
            this.btnAddNewLDLApplications.Location = new System.Drawing.Point(1050, 22);
            this.btnAddNewLDLApplications.Name = "btnAddNewLDLApplications";
            this.btnAddNewLDLApplications.Size = new System.Drawing.Size(150, 34);
            this.btnAddNewLDLApplications.TabIndex = 4;
            this.btnAddNewLDLApplications.Text = "+ New Application";
            this.btnAddNewLDLApplications.Click += new System.EventHandler(this.btnAddNewLDLApplications_Click);
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApplications.ColumnHeadersHeight = 29;
            this.dgvLDLApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLDLApplications.Location = new System.Drawing.Point(24, 76);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.RowHeadersWidth = 51;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1176, 420);
            this.dgvLDLApplications.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleTestsToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 76);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionToolStripMenuItem,
            this.scheduleWrittenToolStripMenuItem,
            this.scheduleStreetToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionToolStripMenuItem
            // 
            this.scheduleVisionToolStripMenuItem.Name = "scheduleVisionToolStripMenuItem";
            this.scheduleVisionToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.scheduleVisionToolStripMenuItem.Text = "Vision";
            this.scheduleVisionToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionToolStripMenuItem_Click);
            // 
            // scheduleWrittenToolStripMenuItem
            // 
            this.scheduleWrittenToolStripMenuItem.Name = "scheduleWrittenToolStripMenuItem";
            this.scheduleWrittenToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.scheduleWrittenToolStripMenuItem.Text = "Written";
            this.scheduleWrittenToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenToolStripMenuItem_Click);
            // 
            // scheduleStreetToolStripMenuItem
            // 
            this.scheduleStreetToolStripMenuItem.Name = "scheduleStreetToolStripMenuItem";
            this.scheduleStreetToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.scheduleStreetToolStripMenuItem.Text = "Street";
            this.scheduleStreetToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.cancelToolStripMenuItem.Text = "Cancel Application";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(24, 508);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(69, 21);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "Records:";
            // 
            // lblRecordsCountValue
            // 
            this.lblRecordsCountValue.AutoSize = true;
            this.lblRecordsCountValue.Location = new System.Drawing.Point(90, 508);
            this.lblRecordsCountValue.Name = "lblRecordsCountValue";
            this.lblRecordsCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblRecordsCountValue.TabIndex = 1;
            this.lblRecordsCountValue.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1100, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManageLDApplications
            // 
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1224, 560);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.btnAddNewLDLApplications);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageLDApplications";
            this.Text = "Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
