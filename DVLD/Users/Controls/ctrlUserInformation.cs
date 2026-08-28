using System;
using DVLD_Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users.Controls
{
    public partial class ctrlUserInformation : UserControl
    {

        private int _UserID;

        public int UserID { get { return _UserID; } }


        public ctrlUserInformation()
        {
            InitializeComponent();
        }
        public void LoadUserInfoCard(int userID)
        {
            if (!ctrlLoginInfoCard1.LoadUserLogginInfo(userID))
                return;

            if (!ctrlPersonCard1.LoadPersonInfo(ctrlLoginInfoCard1.PersonID))
                return;
        }
    }
}
