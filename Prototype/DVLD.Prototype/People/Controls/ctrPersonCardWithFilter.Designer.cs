using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.People.Controls
{
    partial class ctrPersonCardWithFilter
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox gbFilter;
        private Label lblFindBy;
        private ComboBox cbFilterType;
        private TextBox txtFindValue;
        private Button btnSearch;
        private ctrlPersonCard ctrlPersonCard1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbFilter = new GroupBox();
            this.lblFindBy = new Label();
            this.cbFilterType = new ComboBox();
            this.txtFindValue = new TextBox();
            this.btnSearch = new Button();
            this.ctrlPersonCard1 = new ctrlPersonCard();
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
            this.gbFilter.Controls.Add(this.cbFilterType);
            this.gbFilter.Controls.Add(this.lblFindBy);
            //
            // lblFindBy
            //
            this.lblFindBy.AutoSize = true;
            AppTheme.ApplyCaption(this.lblFindBy);
            this.lblFindBy.Location = new Point(20, 38);
            this.lblFindBy.Text = "Find By:";
            //
            // cbFilterType
            //
            this.cbFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbFilterType.Font = AppTheme.FontBody;
            this.cbFilterType.Location = new Point(90, 34);
            this.cbFilterType.Size = new Size(150, 26);
            this.cbFilterType.Items.AddRange(new object[] { "Person ID", "National No" });
            //
            // txtFindValue
            //
            this.txtFindValue.Font = AppTheme.FontBody;
            this.txtFindValue.Location = new Point(250, 34);
            this.txtFindValue.Size = new Size(200, 26);
            this.txtFindValue.Text = "104";
            //
            // btnSearch
            //
            AppTheme.ApplyPrimaryButton(this.btnSearch);
            this.btnSearch.Location = new Point(462, 30);
            this.btnSearch.Size = new Size(100, 34);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // ctrlPersonCard1
            //
            this.ctrlPersonCard1.Dock = DockStyle.Fill;
            //
            // ctrPersonCardWithFilter
            //
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFilter);
            this.Size = new Size(940, 360);
            this.BackColor = AppTheme.Surface;
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
