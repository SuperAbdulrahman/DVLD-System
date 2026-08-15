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
        enum enMode { AddNew,Edit}
        enMode Mode;
        public frmAddEditNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
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
        }
        private void _LoadLicenseClassesCB()
        {
            DataTable dt = LicenseClass.GetLicenseClasses();
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.DisplayMember = "ClassName";

            cbLicenseClass.DataSource = dt;
            cbLicenseClass.SelectedIndex = 2;
        }

        private void frmAddEditNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadLicenseClassesCB();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {

        }
    }
}
