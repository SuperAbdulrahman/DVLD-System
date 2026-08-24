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
    public partial class frmShowLDLAppInfo : Form
    {
        private int _LDLAppID;
        public frmShowLDLAppInfo(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowLDLAppInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationInfoCard1.LoadAppInfoByLDLAppID(_LDLAppID); 
            if(ctrlLocalDrivingLicenseApplicationInfoCard1.LDLAppID ==-1)
                Close();
        }
    }
}
