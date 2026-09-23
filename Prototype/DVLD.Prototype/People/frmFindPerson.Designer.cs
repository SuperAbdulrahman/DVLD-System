using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.People.Controls;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.People
{
    partial class frmFindPerson
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.ctrPersonCardWithFilter1 = new ctrPersonCardWithFilter();
            this.btnClose = new Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(24, 20);
            this.lblTitle.Text = "Find Person";
            //
            // ctrPersonCardWithFilter1
            //
            this.ctrPersonCardWithFilter1.Location = new Point(24, 70);
            this.ctrPersonCardWithFilter1.Size = new Size(940, 360);
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(864, 442);
            this.btnClose.Size = new Size(100, 36);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // frmFindPerson
            //
            this.ClientSize = new Size(988, 494);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrPersonCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Find Person";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
