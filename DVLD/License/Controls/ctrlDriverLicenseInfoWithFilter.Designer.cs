namespace DVLD.License.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ctrlDriverLicenseInfocard1 = new DVLD.License.Controls.ctrlDriverLicenseInfocard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtFindValue);
            this.gbFilter.Controls.Add(this.lblFindBy);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(14, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1024, 88);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFindValue
            // 
            this.txtFindValue.BackColor = System.Drawing.Color.White;
            this.txtFindValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindValue.Location = new System.Drawing.Point(172, 39);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(745, 31);
            this.txtFindValue.TabIndex = 1;
            this.txtFindValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindValue_KeyPress);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(47, 39);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(110, 28);
            this.lblFindBy.TabIndex = 45;
            this.lblFindBy.Text = "License ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.License_View_32;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(945, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 42);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlDriverLicenseInfocard1
            // 
            this.ctrlDriverLicenseInfocard1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfocard1.Location = new System.Drawing.Point(14, 89);
            this.ctrlDriverLicenseInfocard1.Name = "ctrlDriverLicenseInfocard1";
            this.ctrlDriverLicenseInfocard1.Size = new System.Drawing.Size(1036, 440);
            this.ctrlDriverLicenseInfocard1.TabIndex = 50;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlDriverLicenseInfocard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1053, 532);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Label lblFindBy;
        private ctrlDriverLicenseInfocard ctrlDriverLicenseInfocard1;
    }
}
