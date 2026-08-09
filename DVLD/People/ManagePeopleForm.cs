using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.People;
using DVLD_Business;

namespace DVLD
{
    public partial class ManagePeopleForm : Form
    {
        private DataTable _dtAllPeople;
        private DataTable _dtPeopleForGrid;
        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            cbFilterByOptions.SelectedIndex = 0;
  
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            txtbFilterSearchBar.Visible = false;
            cbGenderFilter.Visible = false;
            if (cbFilterByOptions.SelectedItem?.ToString() == "None")
            {
                _dtPeopleForGrid.DefaultView.RowFilter = "";
                _UpdateRecordsCounter();
                return;
            }
            else if (cbFilterByOptions.SelectedItem?.ToString() == "Gender")
            {
                cbGenderFilter.Visible = true;
                cbGenderFilter.SelectedIndex = 0;
                _UpdateRecordsCounter();
                return;
            }
            _dtPeopleForGrid.DefaultView.RowFilter = "";
            txtbFilterSearchBar.Visible = true;
            txtbFilterSearchBar.Text = string.Empty;
            _UpdateRecordsCounter();
        }
        

        private void _FilterString(string field, string filter)
        {

            // Replaces ' with '' to safely escape the SQL syntax
            string safeFilter = filter.Replace("'", "''");
            _dtPeopleForGrid.DefaultView.RowFilter = $"{field} LIKE '{safeFilter}%'";
            
        }
        private void _FilterInt(string field, int filter)
        {
            _dtPeopleForGrid.DefaultView.RowFilter = $"{field} ={filter}";
        }
        private int _CountRecords()=> _dtPeopleForGrid.DefaultView.Count;

        private void _UpdateRecordsCounter()
        {
            int count = _CountRecords();
            if (count > 0)
                lblRecordsCountValue.Text = count.ToString();
            else
                lblRecordsCountValue.Text = "0";
        }
        private void _RefreshPeopleList()
        {
            _dtAllPeople = Person.GetAllPeopleWithCountryName();
            if (_dtAllPeople != null)
            {
                _dtPeopleForGrid = _dtAllPeople.DefaultView.ToTable(false,
                    "PersonID", "NationalNo", "FirstName", "SecondName",
                     "ThirdName", "LastName", "Gender", "Date Of Birth",
                     "Nationality", "Phone", "Email");
                dgvPeopleList.DataSource = _dtPeopleForGrid;
                _FormatPeopleGrid();
            }
            else
                return;
        }
        private void _FormatPeopleGrid()
        {
            if (dgvPeopleList.Columns.Count > 0)
            {
                dgvPeopleList.Columns["PersonID"].HeaderText = "Person ID";
                dgvPeopleList.Columns["PersonID"].Width = 90;

                dgvPeopleList.Columns["NationalNo"].HeaderText = "National No.";
                dgvPeopleList.Columns["NationalNo"].Width = 110;

                dgvPeopleList.Columns["FirstName"].HeaderText = "First Name";
                dgvPeopleList.Columns["FirstName"].Width = 120;

                dgvPeopleList.Columns["SecondName"].HeaderText = "Second Name";
                dgvPeopleList.Columns["SecondName"].Width = 120;

                dgvPeopleList.Columns["ThirdName"].HeaderText = "Third Name";
                dgvPeopleList.Columns["ThirdName"].Width = 120;

                dgvPeopleList.Columns["LastName"].HeaderText = "Last Name";
                dgvPeopleList.Columns["LastName"].Width = 120;

                dgvPeopleList.Columns["Date Of Birth"].HeaderText = "Date of Birth";
                dgvPeopleList.Columns["Date Of Birth"].Width = 140;

                dgvPeopleList.Columns["Nationality"].Width = 120;
            }
        }

        private void txtbFilterSearchBar_TextChanged(object sender, EventArgs e)
        {
            
            string filter = txtbFilterSearchBar.Text;
            if(string.IsNullOrWhiteSpace (filter))
            {
                _dtPeopleForGrid.DefaultView.RowFilter = "";
                _UpdateRecordsCounter();
                return;
            }
                
            switch (cbFilterByOptions.SelectedItem)
            {
                case "Person ID":
                    if (int.TryParse(filter, out int result)&& result>0)
                    {
                        _FilterInt("PersonID", result);
                    }
                    break;

                case "National No":
                    _FilterString("NationalNo", filter);
                    break;

                case "First Name":
                    _FilterString("FirstName", filter);
                    break;

                case "Second Name":
                    _FilterString("SecondName", filter);
                    break;

                case "Third Name":
                    _FilterString("ThirdName", filter);
                    break;

                case "Last Name":
                    _FilterString("LastName", filter);
                    break;


                case "Nationality":
                    
                    _FilterString("Nationality", filter);
                    break;

                case "Phone":
                    _FilterString("Phone", filter);
                    break;

                case "Email":
                    _FilterString("Email", filter);
                    break;

                default:
                    break;
            }
            _UpdateRecordsCounter();
        }


        private void txtbFilterSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.SelectedItem == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }

        }

        private void cbGenderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbGenderFilter.SelectedIndex == 0)

                _FilterString("Gender", "Male");
            else
                _FilterString("Gender", "Female");

            _UpdateRecordsCounter();
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(int.TryParse(dgvPeopleList.CurrentRow.Cells[0].Value.ToString(),out int PersonID))
            {
                frmAddEditPerson frm = new frmAddEditPerson(PersonID);
                frm.DataBack += _Applychanges;
                frm.ShowDialog();
            }

             
        }
        public void _Applychanges(object sender, int PersonID)
        {
                _RefreshPeopleList();

        }


        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += _Applychanges;
            frm.ShowDialog();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
            if(Person.IsPersonExist(PersonID))
            {
                if (Person.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person was deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Person does not exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID =(int) dgvPeopleList.CurrentRow.Cells[0].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available later !","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available later !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPeopleList_DoubleClick(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }
    }
}
