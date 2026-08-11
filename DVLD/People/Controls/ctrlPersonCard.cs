using DVLD.People;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        private Person _Person;
        private int _PersonID;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public Person SelectedPersonInfo
        { get { return _Person; } }
        public ctrlPersonCard()
        {
            InitializeComponent();

        }
        public void LoadPersonInfo(int PersonID)

        {
            _PersonID = PersonID; // Store the ID globally for the Edit button
            _Person = Person.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo(); // You must implement this to clear old labels!
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonCardInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = Person.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonID = _Person.PersonID; // Sync the ID!
            _FillPersonCardInfo();
        }
        private void _FillPersonCardInfo()
        {
            lblPersonIDValue.Text = _Person.PersonID.ToString();
            lblNationalNoValue.Text = _Person.NationalNo;
            lblFullNameValue.Text = _Person.FullName;
            lblPhoneValue.Text = _Person.Phone is null ? "--" : _Person.Phone;
            lblEmailValue.Text = _Person.Email is null?"--":_Person.Email;
            lblAddressValue.Text = _Person.Address is null?"--":_Person.Address;
            lblDOBValue.Text = _Person.DateOfBirth.ToString();
            lblCountryValue.Text = _Person.CountryInfo.CountryName;
            if(!_Person.Gender) // means if person is male
            {
                lblGenderValue.Text = "Male";
            }
            else
                lblGenderValue.Text = "Female";
            _LoadPersonImage();


        }
        private void _LoadPersonImage()
        {
            string ImagePath = _Person.ImagePath;
            if (string.IsNullOrEmpty(ImagePath))
            {
                if (lblGenderValue.Text == "Male")
                    pbImage.Image = Resources.Male_512;
                else
                    pbImage.Image = Resources.Female_512;
                return;
            }
            
            if (File.Exists(ImagePath))
                pbImage.ImageLocation = ImagePath;
            else
                MessageBox.Show($"Could not find this image: = {ImagePath}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
   
        }
        private void _ReloadPersonCard(object sender , int PersonID)
        {

          LoadPersonInfo(PersonID);
        }
        // This MUST be public so parent forms can talk to it!

        private void llEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Can not edit non-existing person,add one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.DataBack += _ReloadPersonCard;
            frm.ShowDialog();
        }
        private void ResetPersonInfo()
        {
            lblPersonIDValue.Text = "??";
            lblNationalNoValue.Text = "??";
            lblFullNameValue.Text = "??";
            lblEmailValue.Text = "??";
            lblDOBValue.Text = "??";
            lblAddressValue.Text = "??";
            lblPhoneValue.Text = "??";
            lblCountryValue.Text = "??";
            lblGenderValue.Text = "??";
            pbImage.Image = Resources.Male_512;
        }


    }
}
