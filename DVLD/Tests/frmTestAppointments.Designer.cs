namespace DVLD.Tests
{
    partial class frmTestAppointments
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
            this.lblRecordsCountValue = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAppointmentsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTesttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingLicenseApplicationInfoCard1 = new DVLD.Applications.Controls.ctrlLocalDrivingLicenseApplicationInfoCard();
            this.btnAddNewTestAppointment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbTestTypeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(274, 116);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 54);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // lblRecordsCountValue
            // 
            this.lblRecordsCountValue.AutoSize = true;
            this.lblRecordsCountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRecordsCountValue.Location = new System.Drawing.Point(108, 798);
            this.lblRecordsCountValue.Name = "lblRecordsCountValue";
            this.lblRecordsCountValue.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsCountValue.TabIndex = 21;
            this.lblRecordsCountValue.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(5, 796);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(106, 28);
            this.lblRecords.TabIndex = 20;
            this.lblRecords.Text = "#Records: ";
            // 
            // dgvAppointmentsList
            // 
            this.dgvAppointmentsList.AllowUserToAddRows = false;
            this.dgvAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvAppointmentsList.AllowUserToOrderColumns = true;
            this.dgvAppointmentsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointmentsList.Location = new System.Drawing.Point(10, 664);
            this.dgvAppointmentsList.Name = "dgvAppointmentsList";
            this.dgvAppointmentsList.ReadOnly = true;
            this.dgvAppointmentsList.RowHeadersWidth = 51;
            this.dgvAppointmentsList.RowTemplate.Height = 26;
            this.dgvAppointmentsList.Size = new System.Drawing.Size(1024, 121);
            this.dgvAppointmentsList.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.TakeTesttoolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // TakeTesttoolStripMenuItem1
            // 
            this.TakeTesttoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.TakeTesttoolStripMenuItem1.Image = global::DVLD.Properties.Resources.Test_32;
            this.TakeTesttoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TakeTesttoolStripMenuItem1.Name = "TakeTesttoolStripMenuItem1";
            this.TakeTesttoolStripMenuItem1.Size = new System.Drawing.Size(152, 38);
            this.TakeTesttoolStripMenuItem1.Text = "Take Test";
            this.TakeTesttoolStripMenuItem1.Click += new System.EventHandler(this.TakeTesttoolStripMenuItem1_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppointments.Location = new System.Drawing.Point(12, 630);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(147, 28);
            this.lblAppointments.TabIndex = 16;
            this.lblAppointments.Text = "Appointments:";
            // 
            // ctrlLocalDrivingLicenseApplicationInfoCard1
            // 
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Location = new System.Drawing.Point(-1, 160);
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Name = "ctrlLocalDrivingLicenseApplicationInfoCard1";
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Size = new System.Drawing.Size(1063, 471);
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.TabIndex = 22;
            // 
            // btnAddNewTestAppointment
            // 
            this.btnAddNewTestAppointment.BackgroundImage = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddNewTestAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewTestAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewTestAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTestAppointment.Location = new System.Drawing.Point(933, 615);
            this.btnAddNewTestAppointment.Name = "btnAddNewTestAppointment";
            this.btnAddNewTestAppointment.Size = new System.Drawing.Size(101, 43);
            this.btnAddNewTestAppointment.TabIndex = 19;
            this.btnAddNewTestAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewTestAppointment.Click += new System.EventHandler(this.btnAddNewTestAppointment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(880, 791);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbTestTypeIcon
            // 
            this.pbTestTypeIcon.BackColor = System.Drawing.Color.White;
            this.pbTestTypeIcon.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pbTestTypeIcon.Location = new System.Drawing.Point(434, -1);
            this.pbTestTypeIcon.Name = "pbTestTypeIcon";
            this.pbTestTypeIcon.Size = new System.Drawing.Size(181, 114);
            this.pbTestTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeIcon.TabIndex = 8;
            this.pbTestTypeIcon.TabStop = false;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 846);
            this.Controls.Add(this.btnAddNewTestAppointment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfoCard1);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppointmentsList);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.pbTestTypeIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appontments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestTypeIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsCountValue;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnAddNewTestAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAppointmentsList;
        private System.Windows.Forms.Label lblAppointments;
        private Applications.Controls.ctrlLocalDrivingLicenseApplicationInfoCard ctrlLocalDrivingLicenseApplicationInfoCard1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTesttoolStripMenuItem1;
    }
}