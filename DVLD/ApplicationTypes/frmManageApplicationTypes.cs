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

namespace DVLD.ApplicationTypes
{
    public partial class frmManageApplicationTypes : Form
    {

        private DataTable _dtApplictionTypes;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }


        private void _FormatDataGridView()
        {
            if (dgvApplicationTypes.Columns.Count > 0)
            {
                dgvApplicationTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
                dgvApplicationTypes.Columns["ApplicationTypeID"].Width = 90;

                dgvApplicationTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
                dgvApplicationTypes.Columns["ApplicationTypeTitle"].Width =250;

                dgvApplicationTypes.Columns["ApplicationFees"].HeaderText = "Fees";
                dgvApplicationTypes.Columns["ApplicationFees"].Width = 100;

            }
        }


        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
           _RefreshApplictionsTypesList();
            _FormatDataGridView();
        }
        private void _RefreshApplictionsTypesList()
        {
            _dtApplictionTypes = ApplicationType.GetAllApplicationTypes();
            if (_dtApplictionTypes != null)
            {
                dgvApplicationTypes.DataSource = _dtApplictionTypes;
            }
            _UpdateRecordsCounter();

        }

        private int _CountRecords() =>  _dtApplictionTypes?.DefaultView.Count??0;

        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();
            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";

        }

      
        private void EditApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEditApplicationType frm = new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            if (frm.ShowDialog() == DialogResult.OK)
                _RefreshApplictionsTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
