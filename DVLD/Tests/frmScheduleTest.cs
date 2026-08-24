using DVLD.Tests.Controls;
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

namespace DVLD.Tests
{
    public partial class frmScheduleTest : Form
    {
        private int _LDLAppID = -1;
        private int _TestAppointmentID = -1;
        bool _ViewOnly = false;
        TestType.enTestType _TestTypeID;

        public frmScheduleTest(int LocalAppID, TestType.enTestType TestTypeID, int TestAppointmentID = -1, bool ViewOnly = false)
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

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _TestTypeID;
            ctrlScheduleTest1.LoadLDLAppInfo(_LDLAppID,_TestAppointmentID,_ViewOnly);
            if(_ViewOnly)
            {

                btnClose.Location = new Point(
                    btnClose.Location.X,
                    ctrlScheduleTest1.Bottom + 10
                );

                this.ClientSize = new Size(
                    this.ClientSize.Width,
                    btnClose.Bottom + 10
                );
            }
            //if (ctrlScheduleTest1.LDLAppID == -1)
            //    this.Close();
        }
    }
}
