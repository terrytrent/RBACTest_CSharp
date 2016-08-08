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
    public class UserRightsTests
    {
        [TestMethod()]
        public void checkRightsTest()
        {
            var expected = true;

            var actual = UserRights.checkRights(UserRights.rights.FullControl, UserRights.rights.create);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void checkRightsTest_Fail()
        {
            var expected = false;

            var actual = UserRights.checkRights(UserRights.rights.none, UserRights.rights.create);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getRightsNumericvalueTest_Success()
        {
            var expected = 15;

            var actual = UserRights.getRightsNumericvalue(UserRights.rights.FullControl);

            Assert.AreEqual(expected, actual);
        }
    }
}