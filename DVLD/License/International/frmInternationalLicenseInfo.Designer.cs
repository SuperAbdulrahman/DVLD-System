namespace DVLD.License.International
{
    partial class frmInternationalLicenseInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbManageApplicationsTypesIcon = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLicenseInternationalInfo1 = new DVLD.License.Controls.ctrlDriverLicenseInternationalInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(221, 185);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 54);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Driver International License Info";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(882, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbManageApplicationsTypesIcon
            // 
            this.pbManageApplicationsTypesIcon.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbManageApplicationsTypesIcon.Location = new System.Drawing.Point(389, 12);
            this.pbManageApplicationsTypesIcon.Name = "pbManageApplicationsTypesIcon";
            this.pbManageApplicationsTypesIcon.Size = new System.Drawing.Size(246, 153);
            this.pbManageApplicationsTypesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApplicationsTypesIcon.TabIndex = 17;
            this.pbManageApplicationsTypesIcon.TabStop = false;
            // 
            // ctrlDriverLicenseInternationalInfo1
            // 
            this.ctrlDriverLicenseInternationalInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInternationalInfo1.Location = new System.Drawing.Point(-1, 242);
            this.ctrlDriverLicenseInternationalInfo1.Name = "ctrlDriverLicenseInternationalInfo1";
            this.ctrlDriverLicenseInternationalInfo1.Size = new System.Drawing.Size(1044, 365);
            this.ctrlDriverLicenseInternationalInfo1.TabIndex = 18;
            // 
            // frmInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 673);
            this.Controls.Add(this.ctrlDriverLicenseInternationalInfo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbManageApplicationsTypesIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Info";
            this.Load += new System.EventHandler(this.frmInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationsTypesIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbManageApplicationsTypesIcon;
        private Controls.ctrlDriverLicenseInternationalInfo ctrlDriverLicenseInternationalInfo1;
    }
}