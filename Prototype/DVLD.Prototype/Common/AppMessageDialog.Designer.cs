using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Common
{
    partial class AppMessageDialog
    {
        private System.ComponentModel.IContainer components = null;
        private IconGlyph icon;
        private Label lblTitle;
        private Label lblMessage;
        private Button btnPrimary;
        private Button btnSecondary;
        private Panel pnlButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.icon = new IconGlyph();
            this.lblTitle = new Label();
            this.lblMessage = new Label();
            this.btnPrimary = new Button();
            this.btnSecondary = new Button();
            this.pnlButtons = new Panel();
            this.SuspendLayout();
            //
            // icon
            //
            this.icon.Location = new Point(24, 28);
            this.icon.Size = new Size(40, 40);
            this.icon.Icon = IconKind.Info;
            this.icon.Tint = AppTheme.Navy;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = AppTheme.FontSectionTitle;
            this.lblTitle.Location = new Point(80, 28);
            this.lblTitle.Size = new Size(120, 24);
            this.lblTitle.Text = "Title";
            //
            // lblMessage
            //
            this.lblMessage.Font = AppTheme.FontBody;
            this.lblMessage.ForeColor = AppTheme.TextSecondary;
            this.lblMessage.Location = new Point(80, 58);
            this.lblMessage.Size = new Size(320, 70);
            this.lblMessage.Text = "Message text goes here.";
            //
            // pnlButtons
            //
            this.pnlButtons.BackColor = AppTheme.SurfaceAlt;
            this.pnlButtons.Dock = DockStyle.Bottom;
            this.pnlButtons.Height = 64;
            this.pnlButtons.Controls.Add(this.btnPrimary);
            this.pnlButtons.Controls.Add(this.btnSecondary);
            //
            // btnPrimary
            //
            this.btnPrimary.Location = new Point(300, 14);
            this.btnPrimary.Size = new Size(100, 36);
            this.btnPrimary.Text = "OK";
            this.btnPrimary.UseVisualStyleBackColor = false;
            this.btnPrimary.Click += new System.EventHandler(this.btnPrimary_Click);
            //
            // btnSecondary
            //
            this.btnSecondary.Location = new Point(190, 14);
            this.btnSecondary.Size = new Size(100, 36);
            this.btnSecondary.Text = "Cancel";
            this.btnSecondary.UseVisualStyleBackColor = false;
            AppTheme.ApplySecondaryButton(this.btnSecondary);
            this.btnSecondary.Click += new System.EventHandler(this.btnSecondary_Click);
            //
            // AppMessageDialog
            //
            this.ClientSize = new Size(420, 180);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = AppTheme.DialogBorderStyle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = string.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
