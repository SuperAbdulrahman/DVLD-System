using System;
using System.Windows.Forms;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.Users
{
    public partial class frmLoginScreen : BaseForm
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0 || txtPassword.Text.Length == 0)
            {
                AppMessageDialog.Failure(this, "Complete missing fields.", "Error");
                return;
            }

            // Prototype: any non-empty credentials "succeed" — no real auth.
            Hide();
            using (var main = new DVLD.Prototype.MainForm())
            {
                main.ShowDialog(this);
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
