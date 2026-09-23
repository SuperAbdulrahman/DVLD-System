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
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID;
        public frmLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            ctrPersonCardWithFilter1.FilterEnabled = false;
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            if(obj==-1)
            {
                ctrlDriverLicenses1.Clear();
                return;
            }
            if (!ctrlDriverLicenses1.LoadDriverLicensesCardInfoByDPersonID(_PersonID))
                this.Close();
        }
    }
}
