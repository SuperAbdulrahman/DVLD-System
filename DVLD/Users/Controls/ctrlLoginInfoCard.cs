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

    namespace DVLD.Users
    {
        public partial class ctrlLoginInfoCard : UserControl
        {
            private User _User;
        private int _UserID = -1;

        public int UserID { get { return _UserID; } }
        public int PersonID
            {
                get { return _User?.PersonID ?? -1; }
            }


            public ctrlLoginInfoCard()
            {
                InitializeComponent();
            }

        public bool LoadUserLogginInfo(int userID)
        {
            _User = User.Find(userID);
            if (_User == null)
            {
                _ResetUserInfoCard();
                MessageBox.Show("No User with User ID  = " + userID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _UserID = _User.UserID;
            _FillUserCardInfo();
            return true;
        }


            private void _FillUserCardInfo()
            {
                lblUserIdValue.Text   = _User.UserID.ToString();
                lblUsernameValue.Text = _User.UserName.ToString();
                lblIsActiveValue.Text = _User.IsActive.ToString();
            
            }
            private void _ResetUserInfoCard()
            {
                lblUserIdValue.Text = "??";
                lblUsernameValue.Text = "??";
                lblIsActiveValue.Text = "??";
            }
        }
    }
