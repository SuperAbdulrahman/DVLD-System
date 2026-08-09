using DVLD.Users;
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


namespace DVLD
{

    public partial class MainForm : Form
    {
        private User user;
        private int _UserID;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void toolStripDropDownPeople_Click(object sender, EventArgs e)
        {
            ManagePeopleForm frm = new ManagePeopleForm();
            frm.ShowDialog();
        }

        private void realToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            frmLoginScreen frm = new frmLoginScreen();
            frm.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
