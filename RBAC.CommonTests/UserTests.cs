using Microsoft.VisualStudio.TestTools.UnitTesting;
using RBAC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBAC.Common.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserTest_ConstructorCreated()
        {
            var user = new User("ttrent",UserRights.rights.FullControl);

            var expected = "Username is ttrent, Rights is FullControl";

            var actual = $"Username is {user.Username}, Rights is {user.Rights.ToString()}";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UserTest_SetCreated()
        {
            var user = new User();
            user.Username = "ttrent";
            user.Rights = UserRights.rights.FullControl;

            var expected = "Username is ttrent, Rights is FullControl";

            var actual = $"Username is {user.Username}, Rights is {user.Rights.ToString()}";

            Assert.AreEqual(expected, actual);
        }
    }
}