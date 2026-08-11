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



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Complete missing fields","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                if (cbRememberMe.Checked)
                    _SaveCurrentSessionInfo(txtUsername.Text, txtPassword.Text);
                else
                    _RemoveCurrentSessionInfo();
                this.Hide();

                using (MainForm frm = new MainForm(_UserID))
                {
                    txtPassword.Text = string.Empty;
                    txtUsername.Text = string.Empty;
                    SessionInfo.currentUser = user;
                    frm.ShowDialog();
                }

                // MainForm was closed.
                // Therefore, user logged out.
                _LoadCurrentSessionInfo();
                this.Show(); ;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username cannot be empty or white space!");
                txtUsername.Focus();
                e.Cancel = true;
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
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPassword, "");
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _LoadCurrentSessionInfo();
        }
        private void _SaveCurrentSessionInfo(string username,string password)
        {
            Util.SaveLoginDataToSessionFile(username, password);
            //SessionInfo.currentUsername = username;
            //SessionInfo.currentPassword = password;
        }
        private void _LoadCurrentSessionInfo()
        {
            string[] LoginInfo = Util.LoadLoginDataFromSessionFile();
            txtUsername.Text = LoginInfo[0];
            txtPassword.Text = LoginInfo[1];
            //txtUsername.Text = SessionInfo.currentUsername;
            //txtPassword.Text = SessionInfo.currentPassword;
        }
        private void _RemoveCurrentSessionInfo()
        {
            _SaveCurrentSessionInfo("","");
            //SessionInfo.currentUsername = string.Empty;
            //SessionInfo.currentPassword = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
