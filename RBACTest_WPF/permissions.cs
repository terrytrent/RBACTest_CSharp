using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACTest_WPF
{
    class permissions
    {
        static private Dictionary<int, string> setPermissions()
        {
            Dictionary<int, string> perms = new Dictionary<int, string>();
            perms.Add(1, "read");
            perms.Add(2, "create");
            perms.Add(3, "modify");
            perms.Add(4, "delete");
            return perms;
        }

        static private string convertPermMaskToBinary(int permMask)
        {
            return (string)Convert.ToString(permMask, 2).PadLeft(4, '0');
        }

        static public List<string> getPermissionsFromMask(int permMask)
        {
            Dictionary<int, string> perms = setPermissions();
            string binary = convertPermMaskToBinary(permMask);

            List<string> permissionsToreturn = new List<string>();

            char[] reverseArray = binary.ToCharArray();
            Array.Reverse(reverseArray);
            //string reverseBinary = reverseArray.ToString();

            for (int i = 1; i <= reverseArray.Count(); i++)
            {
                switch (reverseArray[i - 1])
                {
                    case '1':
                        permissionsToreturn.Add(perms[i]);
                        break;
                    case '0':
                        break;
                }
            }

            return permissionsToreturn;
        }
    }
}
