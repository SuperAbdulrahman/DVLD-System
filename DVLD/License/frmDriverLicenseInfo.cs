using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License
{
    public partial class frmDriverLicenseInfo : Form
    {
        public enum enMode { AppID,LicenseID}
        enMode _Mode;
        private int _AppID;
        private int _LicenseID;
        public frmDriverLicenseInfo(int ID, enMode mode)
        {
            InitializeComponent();
            _Mode = mode;
            if (_Mode == enMode.AppID)
                _AppID = ID;
           else
                _LicenseID = ID;
        }


        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AppID)
            {
                if(!ctrlDriverLicenseInfocard1.LoadDriverLicenseInfoByAppID(_AppID))
                    Close();
            }
            else
            {
                if (!ctrlDriverLicenseInfocard1.LoadDriverLicenseInfoByLicenseID(_LicenseID))
                    Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
