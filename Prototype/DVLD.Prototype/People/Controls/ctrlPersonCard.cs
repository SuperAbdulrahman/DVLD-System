using System;
using System.Windows.Forms;

namespace DVLD.Prototype.People.Controls
{
    /// <summary>
    /// Read-only card for a single Person's details + photo + "Edit" link.
    /// Most-reused control in the original app (6+ host screens) — see
    /// DVLD_UI_Inventory_Report.md item 2.
    /// </summary>
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
            LoadDummyData();
        }

        public event EventHandler EditRequested;

        private void LoadDummyData()
        {
            lblPersonIDValue.Text = "104";
            lblFullNameValue.Text = "Layla Ahmad Al-Hassan";
            lblNationalNoValue.Text = "990102345";
            lblGenderValue.Text = "Female";
            lblEmailValue.Text = "layla.hassan@example.com";
            lblAddressValue.Text = "12 Al-Nasr St, Amman";
            lblDOBValue.Text = "1999-01-02";
            lblPhoneValue.Text = "079-555-1234";
            lblCountryValue.Text = "Jordan";
        }

        private void llEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
