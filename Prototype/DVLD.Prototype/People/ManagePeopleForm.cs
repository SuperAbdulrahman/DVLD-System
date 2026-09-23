using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Prototype.Common;

namespace DVLD.Prototype.People
{
    /// <summary>
    /// Grid list/management of all People — see DVLD_UI_Inventory_Report.md
    /// item 4. Fixes the report's flagged UX gap: destructive Delete now
    /// shows an OKCancel confirmation like every Save flow does.
    /// </summary>
    public partial class ManagePeopleForm : BaseForm
    {
        private readonly DataTable _people = new DataTable();

        public ManagePeopleForm()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            _people.Columns.Add("PersonID", typeof(int));
            _people.Columns.Add("Full Name", typeof(string));
            _people.Columns.Add("National No", typeof(string));
            _people.Columns.Add("Gender", typeof(string));
            _people.Columns.Add("Phone", typeof(string));
            _people.Columns.Add("Nationality", typeof(string));

            _people.Rows.Add(101, "Omar Khaled Yousef", "985511223", "Male", "079-111-2233", "Jordan");
            _people.Rows.Add(102, "Sara Naji Odeh", "992233445", "Female", "078-222-3344", "Jordan");
            _people.Rows.Add(103, "Ziad Fadi Mansour", "970044556", "Male", "077-333-4455", "Jordan");
            _people.Rows.Add(104, "Layla Ahmad Al-Hassan", "990102345", "Female", "079-555-1234", "Jordan");
            _people.Rows.Add(105, "Nour Samer Qasem", "985566778", "Female", "079-666-7788", "Jordan");

            dgvPeopleList.DataSource = _people;
            lblRecordsCountValue.Text = _people.Rows.Count.ToString();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AppMessageDialog.Success(this, "This prototype does not include the Add/Edit Person screen — grid + dialog navigation only.", "Prototype Notice");
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            using (var f = new frmFindPerson()) f.ShowDialog(this);
        }

        private void dgvPeopleList_DoubleClick(object sender, EventArgs e) => ShowDetails();
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) => ShowDetails();

        private void ShowDetails()
        {
            if (dgvPeopleList.CurrentRow == null) return;
            using (var f = new frmPersonDetails()) f.ShowDialog(this);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentRow == null) return;
            string name = dgvPeopleList.CurrentRow.Cells["Full Name"].Value.ToString();

            if (!AppMessageDialog.Confirm(this, $"Are you sure you want to delete \"{name}\"?", "Caution"))
                return;

            _people.Rows.RemoveAt(dgvPeopleList.CurrentRow.Index);
            lblRecordsCountValue.Text = _people.Rows.Count.ToString();
            AppMessageDialog.Success(this, "Person was deleted.", "Success");
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
