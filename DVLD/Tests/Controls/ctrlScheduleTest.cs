using DVLD.Properties;
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

namespace DVLD.Tests.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        enum enMode { AddNew=0,Update =1,View=2};
        private enMode _Mode = enMode.AddNew;
        enum enCreationMode { FirstTimeSchedule =0,RetakeTestSchedule=1}
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;


        private int _LocalAppID = -1;
        private int _TestAppointmentID = -1;
        private int _TestID = -1;
        TestType.enTestType _TestTypeID =TestType.enTestType.VisionTest;
        private byte _TotalTrails;


        private LocalDrivingLicenseApplication _LDLApp;
        private TestAppointment _TestAppointment;
        private TestType _TestType;

        public int LDLAppID { get { return _LocalAppID; } }
        public int TestID
        {
            set 
            {  
                _TestID = value;
                if(_TestID!=-1)
                   lblTestIDValue.Text = _TestID.ToString();
            }
            get { return _TestID; }
        }
        private bool _ViewOnly;

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ViewOnly
        {
            get => _ViewOnly;
            set
            {
                _ViewOnly = value;

                gbRetakeTestInfo.Visible = !value;
                btnSave.Visible = !value;
                dateTimePicker1.Visible = !value;
                PanelTestIDStuff.Visible = value;

                if (_ViewOnly)
                {
                    lblTitle.Text = "Scheduled Test";

                    gbTestType.Height = PanelTestIDStuff.Bottom + 20;
                    this.Height = gbTestType.Bottom + 10;
                }
            }
        }


        public TestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case TestType.enTestType.VisionTest:
                        gbTestType.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    case TestType.enTestType.WrittenTest:
                        gbTestType.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    case TestType.enTestType.StreetTest:
                        gbTestType.Text = "Street Test";
                        pbTestTypeImage.Image = Resources.Street_Test_32;
                        break;
                    default:
                        break;
                }

            }
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        public void LoadLDLAppInfo(int LocalAppID,int TestAppointmentID =-1,bool ViewOnly = false)
        {
            if(TestAppointmentID==-1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update; 


            _LocalAppID = LocalAppID;
            _TestAppointmentID = TestAppointmentID;


            _LDLApp = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByLocalAppID(_LocalAppID);
            if (_LDLApp == null)
            {
                ResetScheduleTestCardInfo();
                MessageBox.Show("No Application with AppID = " + _LocalAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            _TestType = TestType.Find(_TestTypeID);
            _TotalTrails = LocalDrivingLicenseApplication.TotalTrialsPerTest(_LocalAppID, _TestTypeID);

            if(ViewOnly)
            {
                _Mode = enMode.View;
                _FillViewModeCard();
                return;
            }
            if(_Mode== enMode.Update)
            {
                _FillUpdateModeCard();
                return;
            }

            // if not update mode then it is a "Add new" so we decide what creationg mode 
            _TestAppointment = new TestAppointment();
            if (_TotalTrails <= 0)
            {
                _CreationMode = enCreationMode.FirstTimeSchedule;
            }
            else
            {
                _CreationMode = enCreationMode.RetakeTestSchedule;
                _PrepareRetakeTestUI();
            }
            dateTimePicker1.MinDate = DateTime.Now;
            _FillMainCardInfo();
    
        }
        private void _FillMainCardInfo()
        {

            lblDLAppIDValue.Text = _LocalAppID.ToString();
            lblClassValue.Text = _LDLApp.LicenseClassInfo.Name;
            lblNameValue.Text = _LDLApp.ApplicantInfo.FullName;
            lblTrailValue.Text = _TotalTrails.ToString();
            lblFeesValue.Text = _TestType.TestTypeFees.ToString();
            lblTotalFeesValue.Text = lblFeesValue.Text;

        }
        private void _FillViewModeCard()
        {
           ViewOnly = true;
            // Fill card : 

            _TestAppointment = TestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                ResetScheduleTestCardInfo();
                MessageBox.Show("No Test Appointment found with AppID = " + _TestAppointmentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Fill the card info :
            _FillMainCardInfo();
            lblDateValue.Visible = true;
            lblDateValue.Text=_TestAppointment.Date.ToString();
        }
        private void _FillUpdateModeCard()
        {
            _TestAppointment = TestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                ResetScheduleTestCardInfo();
                MessageBox.Show("No Test Appointment found with AppID = " + _TestAppointmentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            //Fill the card info :
            _FillMainCardInfo();
           

            // Set the min date so user 
            if (DateTime.Compare(DateTime.Now,_TestAppointment.Date)<0)
                dateTimePicker1.MinDate = DateTime.Now;
            else
                dateTimePicker1.MinDate = _TestAppointment.Date;

            dateTimePicker1.Value = _TestAppointment.Date;
            // Check if it is retake application 
            if (_TestAppointment.RetakeTestAppID == -1)
                return;

            // here it means it got a retake test application so we fill related info:
            gbRetakeTestInfo.Enabled = true;
            lblRetakeTestAppIDValue.Text = _TestAppointment.RetakeTestAppID.ToString();
            // here we do not query the retake app fees because maybe when first we created it it was different.
            // lblRetakeAppFeesValue.Text = (_TestAppointment.PaidFees-_TestType.TestTypeFees).ToString
            lblRetakeAppFeesValue.Text = _TestAppointment.RetakeAppInfo.PaidFees.ToString("0.00");
            lblTotalFeesValue.Text = (_TestAppointment.RetakeAppInfo.PaidFees + _TestType.TestTypeFees).ToString();
        }
        public void ResetScheduleTestCardInfo()
        {
            lblDLAppIDValue.Text = "??";
            lblClassValue.Text = "??";
            lblFeesValue.Text = "??";
            lblNameValue.Text = "??";
            lblTrailValue.Text = "??";
            dateTimePicker1.Value = DateTime.Now;

            lblRetakeTestAppIDValue.Text = "??";
            lblRetakeAppFeesValue.Text = "??";
            lblTotalFeesValue.Text = "??";
        }
        
       
        private void _PrepareRetakeTestUI()
        {
            lblTitle.Text = "Schedule Retake Test";
            gbRetakeTestInfo.Enabled = true;

            decimal retakeAppFees = ApplicationType.Find((int)ApplicationType.enApplicationType.RetakeTest).ApplicationFees;

            lblRetakeTestAppIDValue.Text = "N/A";
            lblRetakeAppFeesValue.Text = retakeAppFees.ToString("0.00");
            lblTotalFeesValue.Text = (_TestType.TestTypeFees + retakeAppFees).ToString("0.00");
        }

        // 2. In Save: Create and Save the Retake Application ONLY when user clicks Save:
        private bool _HandleRetakeApplication()
        {
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                DVLD_Business.Application retakeApp = new DVLD_Business.Application();
                ApplicationType appType = ApplicationType.Find((int)ApplicationType.enApplicationType.RetakeTest);

                retakeApp.ApplicantPersonID = _LDLApp.ApplicantPersonID;
                retakeApp.ApplicationDate = DateTime.Now;
                retakeApp.ApplicationTypeID = appType.ApplicationID;
                retakeApp.Status = DVLD_Business.Application.enApplicationStatus.Completed;
                retakeApp.LastStatusDate = DateTime.Now;
                retakeApp.PaidFees = appType.ApplicationFees;
                retakeApp.CreatedByUserID = SessionInfo.testUser.UserID;

                if (!retakeApp.Save())
                {
                    MessageBox.Show("Failed to create retake application record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestAppID = retakeApp.ApplicationID;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want save changes?", "Confirm changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return; 

            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LDLAppID = _LocalAppID;
            _TestAppointment.Date = dateTimePicker1.Value;
            _TestAppointment.PaidFees = decimal.Parse(lblTotalFeesValue.Text);
            _TestAppointment.CreatedByUserID = SessionInfo.testUser.UserID;


            if (_TestAppointment.Save())
            {
                MessageBox.Show("Changed Applied Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _TestAppointmentID = _TestAppointment.TestAppointmentID;
                _Mode = enMode.Update;
                _FillUpdateModeCard();
            }
            else
                MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
