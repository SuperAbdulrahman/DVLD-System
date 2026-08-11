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
        private User _User;
        private int _UserID;

        public int UserID { get { return _UserID; } }
        public User UserInfo { get { return _User; } }

        public ctrlUserInformation()
        {
            InitializeComponent();
        }
        public void LoadUserInfoCard(int userID)
        {
            ctrlLoginInfoCard1.LoadUserLogginInfo(userID);
            _User = ctrlLoginInfoCard1.UserInfo;
            if ( _User== null)
            {
                return;
            }
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
        }
    }
}
