using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public static class SessionInfo
    {
        public static User currentUser { get; private set; }
        public static void Login(User user)
        {
            currentUser = user;
        }

        public static void Logout()
        {
            currentUser = null;
        }
        // This will be removed :
        public static User testUser = User.Find(1);
        

    }
}
