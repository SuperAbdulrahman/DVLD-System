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
using static DVLD_Business.TestType;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _LDLAppID = -1;
        private int _TestAppointmentID = -1;
        bool _ViewOnly = false;
        TestType.enTestType _TestTypeID;

        private Test _TestID;
        private Test _Test;


      
        public frmTakeTest(int LocalAppID, TestType.enTestType TestTypeID, int TestAppointmentID = -1, bool ViewOnly = false)
        {
            InitializeComponent();
            _LDLAppID = LocalAppID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = TestAppointmentID;
            _ViewOnly = ViewOnly;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to apply changes?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;
            _Test = new Test();

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text;
            _Test.CreatedByUserID = SessionInfo.testUser.UserID;
            if (_Test.Save())
            {
                MessageBox.Show("Test Result was added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlScheduleTest1.TestID = _Test.TestID;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _TestTypeID;
            ctrlScheduleTest1.LoadLDLAppInfo(_LDLAppID, _TestAppointmentID, _ViewOnly);
        }
    }
}
