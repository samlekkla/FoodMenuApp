using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupparbeteFoodapplication
{
    public class UserAuthentication
    {
        private bool isLoggedIn;
        private bool isAdmin;

        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                isLoggedIn = true;
                isAdmin = true;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            isLoggedIn = false;
            isAdmin = false;
        }

        public bool IsAdmin()
        {
            return isAdmin;
        }
    }
}


        
    
