using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.License.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox gbFilter;
        private Label lblFindBy;
        private TextBox txtFindValue;
        private Button btnSearch;
        private ctrlDriverLicenseInfocard ctrlDriverLicenseInfocard1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbFilter = new GroupBox();
            this.lblFindBy = new Label();
            this.txtFindValue = new TextBox();
            this.btnSearch = new Button();
            this.ctrlDriverLicenseInfocard1 = new ctrlDriverLicenseInfocard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            //
            // gbFilter
            //
            this.gbFilter.Dock = DockStyle.Top;
            this.gbFilter.Height = 80;
            this.gbFilter.Font = AppTheme.FontSectionTitle;
            this.gbFilter.Text = "Filter";
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtFindValue);
            this.gbFilter.Controls.Add(this.lblFindBy);
            //
            // lblFindBy
            //
            this.lblFindBy.AutoSize = true;
            AppTheme.ApplyCaption(this.lblFindBy);
            this.lblFindBy.Location = new Point(20, 38);
            this.lblFindBy.Text = "License ID:";
            //
            // txtFindValue
            //
            this.txtFindValue.Font = AppTheme.FontBody;
            this.txtFindValue.Location = new Point(120, 34);
            this.txtFindValue.Size = new Size(200, 26);
            this.txtFindValue.Text = "3021";
            //
            // btnSearch
            //
            AppTheme.ApplyPrimaryButton(this.btnSearch);
            this.btnSearch.Location = new Point(332, 30);
            this.btnSearch.Size = new Size(100, 34);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // ctrlDriverLicenseInfocard1
            //
            this.ctrlDriverLicenseInfocard1.Dock = DockStyle.Fill;
            //
            // ctrlDriverLicenseInfoWithFilter
            //
            this.Controls.Add(this.ctrlDriverLicenseInfocard1);
            this.Controls.Add(this.gbFilter);
            this.Size = new Size(940, 360);
            this.BackColor = AppTheme.Surface;
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
