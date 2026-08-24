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
        private int _AppID;
        public frmDriverLicenseInfo(int appID)
        {
            InitializeComponent();
            _AppID = appID;
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfocard1.LoadDriverLicenseInfoByAppID(_AppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
