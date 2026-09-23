using System;
using System.Windows.Forms;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.People.Controls
{
    /// <summary>
    /// Filter bar (Person ID/National No) + embedded ctrlPersonCard. Fires
    /// OnPersonSelected. See DVLD_UI_Inventory_Report.md item 3.
    /// </summary>
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
            cbFilterType.SelectedIndex = 0;
        }

        public event EventHandler<string> OnPersonSelected;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFindValue.Text.Trim().Length == 0)
            {
                AppMessageDialog.Failure(this, "Please enter a valid search value.", "Error");
                return;
            }

            // Prototype: search always "finds" the dummy card.
            OnPersonSelected?.Invoke(this, txtFindValue.Text.Trim());
        }
    }
}
