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
    public partial class frmManageTestTypes : Form
    {

        private DataTable _dtTestTypes;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }


        private void _FormatDataGridView()
        {
            if (dgvTestTypes.Columns.Count > 0)
            {
                dgvTestTypes.Columns["TestTypeID"].HeaderText = "ID";
                dgvTestTypes.Columns["TestTypeID"].Width = 80;

                dgvTestTypes.Columns["TestTypeTitle"].HeaderText = "Title";
                dgvTestTypes.Columns["TestTypeTitle"].Width = 140;

                dgvTestTypes.Columns["TestTypeDescription"].HeaderText = "Description";
                dgvTestTypes.Columns["TestTypeDescription"].Width = 430;

                dgvTestTypes.Columns["TestTypeFees"].HeaderText = "Fees";
                dgvTestTypes.Columns["TestTypeFees"].Width = 80;
            }
        }


        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
            _FormatDataGridView();

        }


        private void _RefreshTestTypesList()
        {
            _dtTestTypes = TestType.GetAllTestTypes();

            if (_dtTestTypes != null)
            {
                dgvTestTypes.DataSource = _dtTestTypes;
            }

            _UpdateRecordsCounter();

        }


        private int _CountRecords() => _dtTestTypes?.DefaultView.Count ?? 0;


        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();

            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";

        }


        private void EditTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEditTestType frm = new frmEditTestType((TestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);

            if (frm.ShowDialog() == DialogResult.OK)
                _RefreshTestTypesList();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
