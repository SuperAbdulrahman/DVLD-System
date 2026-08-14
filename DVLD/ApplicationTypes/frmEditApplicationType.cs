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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace DVLD.ApplicationTypes
{
    public partial class frmEditApplicationType : Form
    {


        private int _ApplicationTypeID = -1;
        private ApplicationType _ApplicationType;
        public frmEditApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = applicationTypeID;
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _ApplicationType = ApplicationType.Find(_ApplicationTypeID);
            if (_ApplicationType == null)
            {
                MessageBox.Show("Could not find this application type", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillApplicationTypeInfo();
        }

        private void _FillApplicationTypeInfo()
        {
            lblIDValue.Text = _ApplicationType.ApplicationID.ToString();
            txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
            numericUpDownFees.Value = _ApplicationType.ApplicationFees;
        }
        
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "This Field cannot be empty or whitespace!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtTitle, "");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red icons to see the errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // set values :
            _ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
            _ApplicationType.ApplicationFees = numericUpDownFees.Value;



            if (MessageBox.Show("Are you sure you want to apply changes?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_ApplicationType.Save())
                {
                    MessageBox.Show("Changed Applied Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("An error occured , changes didn't apply", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
