using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBAC.Common
{
    public class User
    {
        private string username;
        private UserRights.rights rights;

        public User()
        { }

        public User(string username, UserRights.rights rights)
        {
            Username = username;
            Rights = rights;
        }

        public UserRights.rights Rights
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
