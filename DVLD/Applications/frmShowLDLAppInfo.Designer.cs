namespace DVLD.Applications
{
    partial class frmShowLDLAppInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseApplicationInfoCard1 = new DVLD.Applications.Controls.ctrlLocalDrivingLicenseApplicationInfoCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(905, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalDrivingLicenseApplicationInfoCard1
            // 
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Location = new System.Drawing.Point(23, 12);
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Name = "ctrlLocalDrivingLicenseApplicationInfoCard1";
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.Size = new System.Drawing.Size(1046, 484);
            this.ctrlLocalDrivingLicenseApplicationInfoCard1.TabIndex = 14;
            // 
            // frmShowLDLAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 566);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfoCard1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowLDLAppInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.frmShowLDLAppInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private Controls.ctrlLocalDrivingLicenseApplicationInfoCard ctrlLocalDrivingLicenseApplicationInfoCard1;
    }
}