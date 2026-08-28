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

namespace DVLD.People
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int personId)
        {
            OnPersonSelected?.Invoke(personId);
        }
        enum enFindMode { PersonID=0, NtionalNo=1}
        enFindMode Mode;
        public int PersonID
        {
            get { return ctrlPersonCard2.PersonID; }
        }

        public Person SelectedPersonInfo
        {
            get { return ctrlPersonCard2.SelectedPersonInfo; }
        }
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddNew.Visible = _ShowAddPerson;
            }
        }
        public void FilterFocus()
        {
            txtFindValue.Focus();
        }
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = (enFindMode)cbFilterType.SelectedIndex;
            txtFindValue.Text = string.Empty;
            errorProvider1.SetError(txtFindValue, "");

        }
        private void FindNow()
        {
            if (Mode == enFindMode.PersonID)
            {
                if (!int.TryParse(txtFindValue.Text, out int personID))
                {
                    MessageBox.Show(
                        "Please enter a valid person ID.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                ctrlPersonCard2.LoadPersonInfo(personID);
            }
            else
            {
                ctrlPersonCard2.LoadPersonInfo(txtFindValue.Text);
            }

            if (FilterEnabled)
            {
                PersonSelected(ctrlPersonCard2.PersonID);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error");
                return;
            }
                FindNow();
            
        }

        private void ctrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterType.SelectedIndex = 0;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += _ApplyChanges;
            frm.ShowDialog();
        }
        private void _ApplyChanges(object sender, int PersonID)
        {
            cbFilterType.SelectedIndex = (int)enFindMode.PersonID;
            txtFindValue.Text = PersonID.ToString();
            ctrlPersonCard2.LoadPersonInfo(PersonID);
            OnPersonSelected(PersonID);
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterType.SelectedIndex = (int)enFindMode.PersonID;
            txtFindValue.Text = PersonID.ToString();
            FindNow(); 
        }

        private void txtFindValue_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFindValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFindValue, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFindValue, null);
            }
        }

        private void txtFindValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                return;
            }

            // Only block characters here, don't show the red error icon yet!
            if (Mode == enFindMode.PersonID)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
