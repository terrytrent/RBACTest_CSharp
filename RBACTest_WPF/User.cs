using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACTest_WPF
{
    public class User
    {
        private string username;
        private userRights.rights rights;

        public User()
        { }

        public User(string username, userRights.rights rights)
        {
            Username = username;
            Rights = rights;
        }

        public userRights.rights Rights
        {
            get { return rights; }
            set { rights = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
