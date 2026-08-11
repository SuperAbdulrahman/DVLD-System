using System;
using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business;
using System.IO;

namespace DVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        private Person _Person;
        private int _PersonID;

        //public delegate void applyChanges(bool Result);
        //public event applyChanges isApplied;

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Edit = 1 }
        enMode Mode;
        public frmAddEditPerson()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            Mode = enMode.Edit;
            _PersonID = PersonID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red icons to see the errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // This completely halts the save process!
            }
            if (!_HandlePersonImage())
            {
                return;
            }
            // Saving Updates
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.NationalityCountryID = (int)cbCountries.SelectedValue;
            _Person.DateOfBirth = dateTimePicker1.Value;
            _Person.ImagePath = pbImage.ImageLocation;
            string Title, Caption;
            if (Mode == enMode.AddNew)
            {
                Title = "Are you sure want to add this person ?";
                Caption = "Adding A New Person";

            }
            else
            {
                Title = "Are you sure want to update this person information ?";
                Caption = "Updating Person Info";
            }

            if (MessageBox.Show(Title, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_Person.Save())
                {
                    MessageBox.Show("Changed Applied Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPersonIDResult.Text = _Person.PersonID.ToString();
                    DataBack?.Invoke(this, _Person.PersonID);
                    //isApplied?.Invoke(true);
                }
                else
                    MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {

            _LoadContries();
            _PersonDetails(Mode);

        }
        private void _PersonDetails(enMode mode)
        {
            switch (mode)
            {
                case enMode.AddNew:
                    _Person = new Person();
                    // Defualt options
                    cbCountries.SelectedValue = 191;
                    dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
                    dateTimePicker1.MinDate = DateTime.Now.AddYears(-100);
                    rbMale.Checked = true;
                    llRemove.Visible = false;


                    break;
                case enMode.Edit:
                    _Person = Person.Find(_PersonID);
                    lblTitle.Text = "Edit Person";
                    lblPersonIDResult.Text = _Person.PersonID.ToString();
                    txtFirstName.Text = _Person.FirstName;
                    txtSecondName.Text = _Person.SecondName;
                    txtThirdName.Text = _Person.ThirdName;
                    txtLastName.Text = _Person.LastName;
                    txtNationalNo.Text = _Person.NationalNo;
                    txtEmail.Text = _Person.Email;
                    txtPhone.Text = _Person.Phone;
                    txtAddress.Text = _Person.Address;
                    cbCountries.SelectedValue = _Person.NationalityCountryID;
                    dateTimePicker1.Value = _Person.DateOfBirth;
                    if (!_Person.Gender)
                        rbMale.Checked = true;
                    else
                        rbFemale.Checked = true;
                    pbImage.ImageLocation = _Person.ImagePath;
                    if (string.IsNullOrEmpty(pbImage.ImageLocation))
                        llRemove.Visible = false;

                    break;
                default:
                    break;
            }
        }

        private void _LoadContries()
        {
            DataTable dtCountries = Country.GetAllCountries();
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            cbCountries.DataSource = dtCountries;
        }

        // Validation methods
        private void Validating_textBoxes(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!_ValidationRequired(textBox))
            {
                e.Cancel = true;
                return;
            }
            if (!_ValidateNationalNo())
            {
                e.Cancel = true;
                return;
            }
            if (!_ValidateEmail())
            {
                e.Cancel = true;
                return;
            }
        }
        private bool _ValidationRequired(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "This Field cannot be empty or whitespace!");
                return false;
            }
            errorProvider.SetError(textBox, "");
            return true;
        }
        private bool _ValidateNationalNo()
        {
            if (Person.IsPersonExist(txtNationalNo.Text))
            {
                errorProvider.SetError(txtNationalNo, "National Number already exist, please enter another one");
                return false;
            }

            errorProvider.SetError(txtNationalNo, "");
            return true;

        }
        private bool _ValidateEmail()
        {
            if (!Validation.IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider.SetError(txtEmail, "Please Enter a correct Email Format!");
                return false;

            }
            errorProvider.SetError(txtEmail, "");
            return true;
        }




        private void rbMaleFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation != "")
            {
                if (rbMale.Checked)
                {
                    pbImage.Image = Resources.Male_512;
                    _Person.Gender = false;
                }
                else
                {
                    pbImage.Image = Resources.Female_512;
                    _Person.Gender = true;
                }
            }
        }

        //Image Handling
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image File";
                    openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    //Force the window to start at a predictable directory (Optional)
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    // 5. Open the folder explorer window and wait for the user to hit "OK"
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 6. Extract the complete physical path of the selected image
                        string selectedImagePath = openFileDialog.FileName;

                        // EXAMPLE USE: Load the chosen path directly into a UI PictureBox control
                        pbImage.ImageLocation = selectedImagePath;
                        llRemove.Visible = true;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Picture was not added !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            rbMaleFemale_CheckedChanged(sender, e);
        }
        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {

                        return false;
                    }
                }
            }
            if (pbImage.ImageLocation != null)
            {
                //then we copy the new image to the image folder after we rename it
                string sourceImageFile = pbImage.ImageLocation.ToString();
                if (Util.CopyImageToProjectImageFolder(ref sourceImageFile))
                {
                    pbImage.ImageLocation = sourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}

    


