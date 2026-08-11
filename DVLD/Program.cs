using DVLD.People;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen());
            // Application.Run(new frmManageUsers());
          //  Application.Run(new frmAddEditUser(21));
            // Application.Run(new MainForm());
            //Application.Run(new frmAddEditPerson());
            //Another method
            //using (frmLoginScreen frm = new frmLoginScreen())
            //{
            //    if(frm.ShowDialog() == DialogResult.OK)
            //    {
            //        Application.Run(new MainForm());
            //    }
            //}
        }
    }
}
