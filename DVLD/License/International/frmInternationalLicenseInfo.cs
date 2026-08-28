using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License.International
{
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _IntLicenseID = -1;
        public frmInternationalLicenseInfo(int IntLicenseID)
        {
            InitializeComponent();
            _IntLicenseID = IntLicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInternationalInfo1.LoadDriverIntLicenseInfoByLicenseID(_IntLicenseID);
        }
    }
}
