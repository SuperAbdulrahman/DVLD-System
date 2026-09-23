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

            User user = User.FindByUsernameAndPassword(txtUsername.Text, txtPassword.Text);
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

            if (cbRememberMe.Checked)
            {
                _SaveRememberedCredentials(txtUsername.Text, txtPassword.Text);
            }
            else
                _ClearRememberedCredentials();

            SessionInfo.Login(user);

            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;

            this.Hide();
            using (MainForm frm = new MainForm())
            {
                frm.ShowDialog();
                if(frm.IsLoggingOut)
                {
                    _LoadRememberedCredentials();
                    Show();
                }
                else
                    Close();   

            }
            

            // MainForm was closed.
            // Therefore, user logged out.
            

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username cannot be empty or white space!");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password cannot be empty or white space!");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPassword, "");
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _LoadRememberedCredentials();
        }
        private void _SaveRememberedCredentials(string username,string password)
        {
            Util.SaveLoginDataToWinRegistery(username, password);
           // Util.SaveLoginDataToSessionFile(username, password);
            //SessionInfo.currentUsername = username;
            //SessionInfo.currentPassword = password;
        }
        private void _LoadRememberedCredentials()
        {
            //  string[] LoginInfo = Util.LoadLoginDataFromSessionFile();
            string[] LoginInfo = new string [2];
            if(Util.LoadLoginDataFromWinRegistery(LoginInfo))
            {
                txtUsername.Text = LoginInfo[0];
                txtPassword.Text = LoginInfo[1];
            }
            else
                MessageBox.Show("An error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //txtUsername.Text = SessionInfo.currentUsername;a
            //txtPassword.Text = SessionInfo.currentPassword;
        }
        private void _ClearRememberedCredentials()
        {
            _SaveRememberedCredentials("","");
            //SessionInfo.currentUsername = string.Empty;
            //SessionInfo.currentPassword = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
