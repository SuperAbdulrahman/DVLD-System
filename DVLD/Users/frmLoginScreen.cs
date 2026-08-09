using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmLoginScreen : Form
    {
        private User user;
        private int _UserID;
        public frmLoginScreen()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = User.Login(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid Username/Password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!user.IsActive)
            {
                MessageBox.Show("User is inactive ! Please Contact Your Admin", "User Inactive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _UserID = user.UserID;
                MainForm frm = new MainForm(_UserID);
                frm.ShowDialog();
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username cannot be empty or white space!");
                txtUsername.Focus();
            }
            else
                errorProvider.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Username cannot be empty or white space!");
                txtPassword.Focus();
            }
            else
                errorProvider.SetError(txtPassword, "");
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {

        }
        private void _ImportLoginDataFromSessionFile()
        {

        }
    }
}
