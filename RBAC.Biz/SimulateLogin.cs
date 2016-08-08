using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RBAC.Common;

namespace RBAC.Biz
{
    public class SimulateLogin
    {
        private User activeUser;
        private bool readPermission;
        private bool writePermission;
        private bool createPermission;
        private bool deletePermission;
        private Dictionary<string,User> simulatedUsers = new Dictionary<string, User>();

        public User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        public bool ReadPermission
        {
            get { return readPermission; }
            set { readPermission = value; }
        }

        public bool WritePermission
        {
            get { return writePermission; }
            set { writePermission = value; }
        }

        public bool CreatePermission
        {
            get { return createPermission; }
            set { createPermission = value; }
        }

        public bool DeletePermission
        {
            get { return deletePermission; }
            set { deletePermission = value; }
        }

        public Dictionary<string, User> SimulatedUsers
        {
            get { return simulatedUsers; }
            set { simulatedUsers = value; }
        }

        public SimulateLogin()
        {
            populateSimulatedLogins();
        }

        private void populateSimulatedLogins()
        {
            SimulatedUsers.Add("terry", new User("ttrent", (UserRights.rights)15));
            SimulatedUsers.Add("joe", new User("jjoe", UserRights.rights.ReadOnly));
            SimulatedUsers.Add("brian", new User("bbrian", UserRights.rights.ReadWrite));
            SimulatedUsers.Add("chris", new User("cchris", UserRights.rights.none));
        }

    }
}
