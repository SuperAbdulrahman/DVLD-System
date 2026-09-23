using DVLD.Prototype.Common;

namespace DVLD.Prototype.People
{
    /// <summary>
    /// Hosts ctrPersonCardWithFilter — mirrors the original frmFindPerson
    /// (item 6), which existed but was never actually wired up in the real
    /// app. Wired here from ManagePeopleForm's "Find Person" action.
    /// </summary>
    public partial class frmFindPerson : BaseForm
    {
        public frmFindPerson()
        {
            InitializeComponent();
            UseDialogSizing();
        }

        private void btnClose_Click(object sender, System.EventArgs e) => Close();
    }
}
