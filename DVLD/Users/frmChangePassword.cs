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
    public partial class frmChangePassword : Form
    {
        int _UserID;
        public frmChangePassword()
        {
            InitializeComponent();
            _UserID= SessionInfo.currentUser.UserID;
        }
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            ctrlUserInformation1.LoadUserInfoCard(_UserID);
        }
        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        // Validation events
        private void Validating_textBoxes(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!_ValidationRequired(textBox))
            {
                e.Cancel = true;
                return;
            }
            if (textBox ==txtCurrentPassword  && !_ValidateCurrentPassword())
            {
                e.Cancel = true;
                return;
            }
            if (textBox == txtConfirmPassword && !_ValidateConfirmPassword())
            {
                e.Cancel = true;
                return;
            }
        }
        private bool _ValidateConfirmPassword()
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password does not match!!");
                return false;
            }
            errorProvider1.SetError(txtConfirmPassword, "");
            return true;
        }
        private bool _ValidationRequired(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "This Field cannot be empty or whitespace!");
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }
        private bool _ValidateCurrentPassword()
        {
            if (txtCurrentPassword.Text != SessionInfo.currentUser.Password)
            {
                errorProvider1.SetError(txtCurrentPassword, "Current Password does not match !!");
                return false;
            }
            errorProvider1.SetError(txtCurrentPassword, "");
            return true;


        }

        // buttons :
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please Fill Required Fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to change password?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                SessionInfo.currentUser.Password = txtNewPassword.Text;
                if (SessionInfo.currentUser.Save())
                {
                    MessageBox.Show("Password changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ResetDefualtValues();
                }
                else
                    MessageBox.Show("An error occured ,Password was not changed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
