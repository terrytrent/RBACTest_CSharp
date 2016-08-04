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

        public User(string providedUsername, userRights.rights providedRights)
        {
            setUsername(providedUsername);
            setRights(providedRights);
        }

        public void setUsername(string providedUsername)
        {
            username = providedUsername;
        }

        public string getUsername()
        {
            return username;
        }

        public void setRights(userRights.rights providedRights)
        {
            rights = providedRights;
        }

        public userRights.rights getRights()
        {
            return rights;
        }
        

    }
}
