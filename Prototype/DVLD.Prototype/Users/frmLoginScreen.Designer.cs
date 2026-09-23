using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Users
{
    partial class frmLoginScreen
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlBrand;
        private Label lblBrandTitle;
        private Label lblBrandTag;
        private IconGlyph iconBrand;
        private Label lblLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox cbRememberMe;
        private Button btnLogin;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlBrand = new Panel();
            this.lblBrandTitle = new Label();
            this.lblBrandTag = new Label();
            this.iconBrand = new IconGlyph();
            this.lblLogin = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.cbRememberMe = new CheckBox();
            this.btnLogin = new Button();
            this.btnClose = new Button();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBrand
            //
            this.pnlBrand.BackColor = AppTheme.Navy;
            this.pnlBrand.Dock = DockStyle.Left;
            this.pnlBrand.Width = 380;
            this.pnlBrand.Controls.Add(this.lblBrandTag);
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Controls.Add(this.iconBrand);
            //
            // iconBrand
            //
            this.iconBrand.Icon = IconKind.Car;
            this.iconBrand.Tint = AppTheme.TextOnNavy;
            this.iconBrand.Location = new Point(48, 220);
            this.iconBrand.Size = new Size(72, 72);
            //
            // lblBrandTitle
            //
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new Font("Segoe UI", 28f, FontStyle.Bold);
            this.lblBrandTitle.ForeColor = AppTheme.TextOnNavy;
            this.lblBrandTitle.Location = new Point(44, 300);
            this.lblBrandTitle.Text = "DVLD";
            //
            // lblBrandTag
            //
            this.lblBrandTag.AutoSize = true;
            this.lblBrandTag.Font = AppTheme.FontBody;
            this.lblBrandTag.ForeColor = Color.FromArgb(200, 202, 214);
            this.lblBrandTag.Location = new Point(48, 350);
            this.lblBrandTag.MaximumSize = new Size(280, 0);
            this.lblBrandTag.Text = "Driving Vehicle License Department\r\nPrototype UI v1.0";
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = AppTheme.FontPageTitle;
            this.lblLogin.Location = new Point(440, 90);
            this.lblLogin.Text = "Login to your account";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            AppTheme.ApplyCaption(this.lblUsername);
            this.lblUsername.Location = new Point(440, 170);
            this.lblUsername.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.Font = AppTheme.FontBody;
            this.txtUsername.Location = new Point(440, 195);
            this.txtUsername.Size = new Size(320, 28);
            this.txtUsername.Text = "admin";
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            AppTheme.ApplyCaption(this.lblPassword);
            this.lblPassword.Location = new Point(440, 245);
            this.lblPassword.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.Font = AppTheme.FontBody;
            this.txtPassword.Location = new Point(440, 270);
            this.txtPassword.Size = new Size(320, 28);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Text = "password";
            //
            // cbRememberMe
            //
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Checked = true;
            this.cbRememberMe.Font = AppTheme.FontSmall;
            this.cbRememberMe.Location = new Point(440, 312);
            this.cbRememberMe.Text = "Remember me";
            //
            // btnLogin
            //
            AppTheme.ApplyPrimaryButton(this.btnLogin);
            this.btnLogin.Location = new Point(440, 360);
            this.btnLogin.Size = new Size(320, 40);
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(440, 408);
            this.btnClose.Size = new Size(320, 36);
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // frmLoginScreen
            //
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnClose;
            this.ClientSize = new Size(920, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlBrand);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "DVLD - Login";
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
