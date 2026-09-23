using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.People.Controls;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.People
{
    partial class frmPersonDetails
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ctrlPersonCard ctrlPersonCard1;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.ctrlPersonCard1 = new ctrlPersonCard();
            this.btnClose = new Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(24, 20);
            this.lblTitle.Text = "Person Details";
            //
            // ctrlPersonCard1
            //
            this.ctrlPersonCard1.Location = new Point(24, 70);
            this.ctrlPersonCard1.Size = new Size(920, 260);
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(844, 348);
            this.btnClose.Size = new Size(100, 36);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // frmPersonDetails
            //
            this.ClientSize = new Size(968, 400);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.lblTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Person Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
