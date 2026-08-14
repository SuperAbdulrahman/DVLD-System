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

namespace DVLD.Tests.TestsTypes
{
    public partial class frmEditTestType : Form
    {
        private TestType.enTestType _TestTypeID;

        private TestType _TestType;

        public frmEditTestType(TestType.enTestType testTypeID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;
        }


        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = TestType.Find(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show("Could not find this test type", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillTestTypeInfo();
        }


        private void _FillTestTypeInfo()
        {
            lblIDValue.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            numericUpDownFees.Value = _TestType.TestTypeFees;
        }


        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "This Field cannot be empty or whitespace!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBox, "");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red icons to see the errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // set values :
            _TestType.TestTypeTitle = txtTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestTypeFees = numericUpDownFees.Value;


            if (MessageBox.Show("Are you sure you want to apply changes?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_TestType.Save())
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
