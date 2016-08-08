using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACTest_WPF
{
    public static class userRights
    {
        [Flags]
        public enum rights
        {
            none = 0,
            read = 1,
            write = 1 << 1,
            create = 1 << 2,
            delete = 1 << 3,

            ReadOnly = read,
            ReadWrite = read | write | create,
            FullControl = read | write | create | delete
        }

        public static bool checkRights(rights permissionToCheck, rights permission)
        {
            if ((permission & permissionToCheck) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int getRightsNumericvalue(rights permissionsToCheck)
        {
            return (int)permissionsToCheck;
        }

    }
}
