using System.Windows.Forms;

namespace DVLD.Prototype.License.Controls
{
    /// <summary>
    /// Read-only full license detail card. See
    /// DVLD_UI_Inventory_Report.md item 23.
    /// </summary>
    public partial class ctrlDriverLicenseInfocard : UserControl
    {
        public ctrlDriverLicenseInfocard()
        {
            InitializeComponent();
            LoadDummyData();
        }

        public void LoadDummyData()
        {
            lblClassValue.Text = "Second Class";
            lblNameValue.Text = "Omar Khaled Yousef";
            lblLicenseIDValue.Text = "3021";
            lblNationalNoValue.Text = "985511223";
            lblGenderValue.Text = "Male";
            lblIssueDateValue.Text = "2022-03-14";
            lblExpirationDateValue.Text = "2027-03-14";
            lblIsActiveValue.Text = "Yes";
            lblIsDetainedValue.Text = "No";
        }
    }
}
