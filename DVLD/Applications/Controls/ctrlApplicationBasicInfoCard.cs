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

namespace DVLD.Applications.Controls
{
    public partial class ctrlApplicationBasicInfoCard : UserControl
    {
        private int _AppID = -1;
        private DVLD_Business.Application _AppInfo;

        public int LDLAppID { get { return _AppID; } }
        public DVLD_Business.Application LDLAppInfo { get { return _AppInfo; } }
        public ctrlApplicationBasicInfoCard()
        {
            InitializeComponent();
        }
        public void LoadAppInfoByAppID(int appID)
        {
            _AppID = appID;
            _AppInfo = DVLD_Business.Application.FindBaseApplication(_AppID);

            if (_AppInfo == null)
            {
                ResetApplicationCardInfo();
                MessageBox.Show("No Application with AppID = " + _AppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillAppCardInfo();
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_AppInfo.ApplicantPersonID);
            frm.ShowDialog();
            lblApplicantValue.Text = _AppInfo.ApplicantInfo?.FullName;
        }
        public void ResetApplicationCardInfo()
        {
            lblIDValue.Text = "??";
            lblStatusValue.Text = "??";
            lblFeesValue.Text = "??";
            lblTypeValue.Text = "??";
            lblApplicantValue.Text = "??";
            lblDateValue.Text = "??";
            lblStatusDateValue.Text = "??";
            lblCreatedByValue.Text = "??";
        }
        private void _FillAppCardInfo()
        {
          

            lblIDValue.Text = _AppInfo.ApplicationID.ToString();
            lblStatusValue.Text = _AppInfo.StatusText;
            lblFeesValue.Text = _AppInfo.PaidFees.ToString();
            lblTypeValue.Text = _AppInfo.ApplicationTypeInfo?.ApplicationTypeTitle;
            lblApplicantValue.Text = _AppInfo.ApplicantInfo?.FullName;
            lblDateValue.Text = _AppInfo.ApplicationDate.ToString();
            lblStatusDateValue.Text = _AppInfo.LastStatusDate.ToString();
            lblCreatedByValue.Text = _AppInfo.CreatedByUserInfo?.UserName;
        }
       
    }
}
