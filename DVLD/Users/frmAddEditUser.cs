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
    public partial class frmAddEditUser : Form
    {
        public delegate void DataBackEventHandler(object sender, int UserID);
        public event DataBackEventHandler DataBack;

        private int _UserID = -1;
        private User _User;
        enum enMode { AddNew = 0, Edit = 1 }
        private enMode _Mode;
        private bool _canGoToLoginInfo = false;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }
        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            _Mode=enMode.Edit;
            _UserID = userID;
        }
        private void _LoadUserInfo()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    lblTitle.Text = "Add New User";
                    this.Text = "Add New User";
                    break;
                case enMode.Edit:
                    _canGoToLoginInfo = true;
                    lblTitle.Text = "Edit User";
                    this.Text = "Edit User";
                    _User = User.Find(_UserID);

                    if (_User == null)
                    {
                        MessageBox.Show("User not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
            

                    ctrPersonCardWithFilter1.FilterEnabled = false;
                    ctrPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
                    _LoadLoginInfo(_User);
                    break;

            }
        }
        private void _LoadLoginInfo(User user)
        {
            lblUserIDResult.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            cbIsActive.Checked = user.IsActive;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            int personID = ctrPersonCardWithFilter1.PersonID;

            if (personID <= 0)
            {
                MessageBox.Show(
                    "Please select a person first.",
                    "Person Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (_Mode == enMode.AddNew)
            {
                if (User.IsUserExistForPersonID(personID))
                {
                    MessageBox.Show(
                        "User exists for this person, please choose another one.",
                        "User Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _User = new User(personID);
            }

            tabControl1.SelectedTab = tpLoginInfo;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadUserInfo();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _canGoToLoginInfo = true;
            //if (_Mode == enMode.AddNew)
            //{
            //    _User = new User(ctrPersonCardWithFilter1.PersonID);
            //}
            //btnSave.Enabled = true;
        }

      
        private void Validating_textBoxes(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            if (!_ValidationRequired(textBox))
            {
                e.Cancel = true;
                return;
            }
            if(textBox==txtUsername && !_ValidateUsernameUniqueness())
            {
                e.Cancel = true;
                return;
            }
            if(textBox == txtConfirmPassword && !_ValidateConfirmPassword())
            {
                e.Cancel = true;
                return;
            }

        }
        private bool _ValidateConfirmPassword()
        {
            if(txtPassword.Text != txtConfirmPassword.Text)
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
        private bool _ValidateUsernameUniqueness()
        {
            string username = txtUsername.Text.Trim();

            if (_Mode == enMode.AddNew)
            {
                if (User.IsUserExist(username))
                {
                    errorProvider1.SetError(
                        txtUsername,
                        "Username is used by another user.");

                    return false;
                }
            }
            else
            {
                if (_User.UserName != username &&
                    User.IsUserExist(username))
                {
                    errorProvider1.SetError(
                        txtUsername,
                        "Username is used by another user.");

                    return false;
                }
            }

            errorProvider1.SetError(txtUsername, "");
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please Fill Required Fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Fill user Info
            _User.UserName = txtUsername.Text.Trim();
            _User.Password = txtPassword.Text;
            _User.IsActive = cbIsActive.Checked;

            if (MessageBox.Show("Are you sure you want save changes?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_User.Save())
                {
                    MessageBox.Show("Changed Applied Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == enMode.AddNew)
                    {
                        _Mode = enMode.Edit;
                    }
                    _UserID = _User.UserID;
                    DataBack?.Invoke(this,_UserID);
                    _LoadUserInfo();

 
                }
                else
                    MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPage==tpLoginInfo &&!_canGoToLoginInfo)
            {
                e.Cancel = true;
            }
        }
    }
}
