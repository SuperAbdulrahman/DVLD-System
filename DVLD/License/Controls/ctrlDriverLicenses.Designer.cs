namespace DVLD.License.Controls
{
    partial class ctrlDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.lblRecordsValueLocal = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvLocalLicensesList = new System.Windows.Forms.DataGridView();
            this.lblLocalLicenseHistory = new System.Windows.Forms.Label();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.lblRecordsValueInternational = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensessList = new System.Windows.Forms.DataGridView();
            this.lblInternationalLicensesHistory = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesList)).BeginInit();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensessList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLocal);
            this.tabControl1.Controls.Add(this.tpInternational);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl1.Location = new System.Drawing.Point(6, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 287);
            this.tabControl1.TabIndex = 0;
            // 
            // tpLocal
            // 
            this.tpLocal.BackColor = System.Drawing.Color.White;
            this.tpLocal.Controls.Add(this.lblRecordsValueLocal);
            this.tpLocal.Controls.Add(this.lblRecords);
            this.tpLocal.Controls.Add(this.dgvLocalLicensesList);
            this.tpLocal.Controls.Add(this.lblLocalLicenseHistory);
            this.tpLocal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tpLocal.Location = new System.Drawing.Point(4, 34);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(1235, 249);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            // 
            // lblRecordsValueLocal
            // 
            this.lblRecordsValueLocal.AutoSize = true;
            this.lblRecordsValueLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsValueLocal.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRecordsValueLocal.Location = new System.Drawing.Point(108, 205);
            this.lblRecordsValueLocal.Name = "lblRecordsValueLocal";
            this.lblRecordsValueLocal.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsValueLocal.TabIndex = 34;
            this.lblRecordsValueLocal.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(6, 205);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(106, 28);
            this.lblRecords.TabIndex = 33;
            this.lblRecords.Text = "#Records: ";
            // 
            // dgvLocalLicensesList
            // 
            this.dgvLocalLicensesList.AllowUserToAddRows = false;
            this.dgvLocalLicensesList.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesList.AllowUserToOrderColumns = true;
            this.dgvLocalLicensesList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocalLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicensesList.Location = new System.Drawing.Point(6, 52);
            this.dgvLocalLicensesList.Name = "dgvLocalLicensesList";
            this.dgvLocalLicensesList.ReadOnly = true;
            this.dgvLocalLicensesList.RowHeadersWidth = 51;
            this.dgvLocalLicensesList.RowTemplate.Height = 26;
            this.dgvLocalLicensesList.Size = new System.Drawing.Size(1199, 135);
            this.dgvLocalLicensesList.TabIndex = 32;
            // 
            // lblLocalLicenseHistory
            // 
            this.lblLocalLicenseHistory.AutoSize = true;
            this.lblLocalLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblLocalLicenseHistory.Location = new System.Drawing.Point(6, 12);
            this.lblLocalLicenseHistory.Name = "lblLocalLicenseHistory";
            this.lblLocalLicenseHistory.Size = new System.Drawing.Size(208, 28);
            this.lblLocalLicenseHistory.TabIndex = 31;
            this.lblLocalLicenseHistory.Text = "Local License History:";
            // 
            // tpInternational
            // 
            this.tpInternational.BackColor = System.Drawing.Color.White;
            this.tpInternational.Controls.Add(this.lblRecordsValueInternational);
            this.tpInternational.Controls.Add(this.label2);
            this.tpInternational.Controls.Add(this.dgvInternationalLicensessList);
            this.tpInternational.Controls.Add(this.lblInternationalLicensesHistory);
            this.tpInternational.Location = new System.Drawing.Point(4, 34);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(1235, 249);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            // 
            // lblRecordsValueInternational
            // 
            this.lblRecordsValueInternational.AutoSize = true;
            this.lblRecordsValueInternational.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsValueInternational.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRecordsValueInternational.Location = new System.Drawing.Point(108, 205);
            this.lblRecordsValueInternational.Name = "lblRecordsValueInternational";
            this.lblRecordsValueInternational.Size = new System.Drawing.Size(23, 28);
            this.lblRecordsValueInternational.TabIndex = 38;
            this.lblRecordsValueInternational.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "#Records: ";
            // 
            // dgvInternationalLicensessList
            // 
            this.dgvInternationalLicensessList.AllowUserToAddRows = false;
            this.dgvInternationalLicensessList.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensessList.AllowUserToOrderColumns = true;
            this.dgvInternationalLicensessList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInternationalLicensessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensessList.Location = new System.Drawing.Point(6, 52);
            this.dgvInternationalLicensessList.Name = "dgvInternationalLicensessList";
            this.dgvInternationalLicensessList.ReadOnly = true;
            this.dgvInternationalLicensessList.RowHeadersWidth = 51;
            this.dgvInternationalLicensessList.RowTemplate.Height = 26;
            this.dgvInternationalLicensessList.Size = new System.Drawing.Size(1199, 135);
            this.dgvInternationalLicensessList.TabIndex = 36;
            // 
            // lblInternationalLicensesHistory
            // 
            this.lblInternationalLicensesHistory.AutoSize = true;
            this.lblInternationalLicensesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblInternationalLicensesHistory.Location = new System.Drawing.Point(5, 15);
            this.lblInternationalLicensesHistory.Name = "lblInternationalLicensesHistory";
            this.lblInternationalLicensesHistory.Size = new System.Drawing.Size(287, 28);
            this.lblInternationalLicensesHistory.TabIndex = 35;
            this.lblInternationalLicensesHistory.Text = "International Licenses History:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 70);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.ShowLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1278, 393);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesList)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensessList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.Label lblLocalLicenseHistory;
        private System.Windows.Forms.Label lblRecordsValueLocal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvLocalLicensesList;
        private System.Windows.Forms.Label lblRecordsValueInternational;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalLicensessList;
        private System.Windows.Forms.Label lblInternationalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
    }
}
