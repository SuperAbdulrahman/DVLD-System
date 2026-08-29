using DVLD.People;
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

namespace DVLD.Applications
{
    public partial class frmAddEditNewLocalDrivingLicenseApplication : Form
    {
        //public delegate void DataBackEventHandler(object sender, int LDAppID);
        //public event DataBackEventHandler DataBack;
        private enum enMode { AddNew, Edit }
        private enMode _Mode;
        
        private int _LocalDrivingLicenseAppID = -1;
        private LocalDrivingLicenseApplication _localDrivingLicenseApp;

        private LicenseClass _LicenseClass;
        public frmAddEditNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditNewLocalDrivingLicenseApplication(int localDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = localDrivingLicenseAppID;
            _Mode = enMode.Edit;
        }
        private void frmAddEditNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadLicenseClassesCB();
            switch (_Mode)
            {
                case enMode.AddNew:
                    tpApplicationInfo.Enabled = false;
                    btnNext.Enabled = false;
                    btnSave.Enabled = false;
                    cbLicenseClass.SelectedIndex = 2;
                    _localDrivingLicenseApp = new LocalDrivingLicenseApplication();
                    break;
                case enMode.Edit:
                    lblTitle.Text = "Edit Local Driving License Application";
                    this.Text = lblTitle.Text;
                    ctrPersonCardWithFilter1.FilterEnabled = false;

                    _localDrivingLicenseApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(_LocalDrivingLicenseAppID);
                    if (_localDrivingLicenseApp == null)
                    {
                        MessageBox.Show($"Local driving license Application with ID {_LocalDrivingLicenseAppID} not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }


                    ctrPersonCardWithFilter1.LoadPersonInfo(_localDrivingLicenseApp.ApplicantPersonID);
                    lblApplicationIDResult.Text = _LocalDrivingLicenseAppID.ToString();
                    lblDateResult.Text = _localDrivingLicenseApp.ApplicationDate.ToString();
                    lblCreatedByResult.Text = _localDrivingLicenseApp.CreatedByUserInfo.UserName.ToString();
                    // I am not sure about the fees..we should show the fees paid for local application at that time
                    lblFeesResult.Text = _localDrivingLicenseApp.PaidFees.ToString();
                    cbLicenseClass.SelectedValue = _localDrivingLicenseApp.LicenseClassID;
                    

                    break;

            }
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
            tabControl1.SelectedTab = tpApplicationInfo;
            _FillApplicationInfoTab();
        }
        private void _LoadLicenseClassesCB()
        {
            DataTable dt = LicenseClass.GetLicenseClasses();
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.DataSource = dt;
        }
        private void _FillApplicationInfoTab()
        {
            ApplicationType appType = ApplicationType.Find((int)ApplicationType.enApplicationType.NewDrivingLicense);
            lblDateResult.Text = DateTime.Now.ToString();
            // lblCreatedBy.Text = SessionInfo.currentUser.UserName;
            lblCreatedByResult.Text = SessionInfo.currentUser.UserName;

            lblFeesResult.Text = appType.ApplicationFees.ToString();
        }



        private void ctrPersonCardWithFilter1_OnPersonSelected(int personID)
        {
            if (personID != -1)
            {
                tpApplicationInfo.Enabled = true;
                btnNext.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Age Validation
            short minAge = _LicenseClass.MinimumAllowedAge;
            DateTime birthDate = ctrPersonCardWithFilter1.SelectedPersonInfo.DateOfBirth;
            int personAge = DateTime.Now.Year - birthDate.Year;
            // we check if the birthdate came or not for exact date detection
            if (birthDate.Date > DateTime.Now.AddYears(-personAge))
            {
                personAge--;
            }

            if (personAge < minAge)
            {
                MessageBox.Show($"Person age is {personAge}, which is less than the minimum allowed age ({minAge}) for this license class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = ctrPersonCardWithFilter1.PersonID;
            int licenseClassID = _LicenseClass.ID;

            //2- Check if person got an active application for the same license class
            int activeAppID = LocalDrivingLicenseApplication.GetActiveLocalDrivingLicenseApplicationID(personID,licenseClassID);
            if(activeAppID != -1)
            {
                MessageBox.Show($"Choose another License Class, the selected Person already has an active application for the selected class with ID = {activeAppID}.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //3- Check if person got an active license for the same license class
            int activeLicenseID = DVLD_Business.License.GetActiveLicenseIDByPersonID(personID, licenseClassID);
            if(activeLicenseID != -1)
            {
                MessageBox.Show($"Person already holds an active license for this class with License ID = {activeLicenseID}.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set Values : 
            _localDrivingLicenseApp.ApplicantPersonID = personID;
            _localDrivingLicenseApp.LicenseClassID = (LicenseClass.enLicenseClasses)licenseClassID;
            _localDrivingLicenseApp.LastStatusDate = DateTime.Now; 
            _localDrivingLicenseApp.ApplicationTypeID =(int) LocalDrivingLicenseApplication.enApplicationType.NewDrivingLicense;

            // ApplicationType appTypeInfo = ApplicationType.Find(_localDrivingLicenseApp.ApplicationTypeID);
            //_localDrivingLicenseApp.PaidFees = appTypeInfo.ApplicationFees;
            _localDrivingLicenseApp.PaidFees =decimal.Parse(lblFeesResult.Text.Trim());
            _localDrivingLicenseApp.CreatedByUserID = SessionInfo.currentUser.UserID;




            // Now Save
            if (MessageBox.Show("Are you sure you want save changes?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                if (_localDrivingLicenseApp.Save())
                {
                    MessageBox.Show("Changed Applied Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == enMode.AddNew)
                    {
                        _Mode = enMode.Edit;
                        lblTitle.Text = "Edit Local Driving License Application";
                        this.Text = lblTitle.Text;
                        _LocalDrivingLicenseAppID = _localDrivingLicenseApp.LocalDirivingLicenseID;
                        lblApplicationIDResult.Text = _LocalDrivingLicenseAppID.ToString();
                    }
                    // DataBack?.Invoke(this, _LocalDrivingLicenseAppID);
                    this.DialogResult = DialogResult.OK;

                }
                else
                    MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLicenseClass.SelectedValue != null && int.TryParse(cbLicenseClass.SelectedValue.ToString(), out int licenseClassID))
            { 
                _LicenseClass = LicenseClass.Find(licenseClassID);

                if (_LicenseClass == null)
                {
                    MessageBox.Show("Please select a valid license class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}