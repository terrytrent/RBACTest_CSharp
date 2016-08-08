using Microsoft.VisualStudio.TestTools.UnitTesting;
using RBACTest_WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACTest_WPF.Tests
{
    [TestClass()]
    public class userRightsTests
    {
        [TestMethod()]
        public void checkRightsTest_Success()
        {
            var expected = true;
            var actual = userRights.checkRights(userRights.rights.FullControl, userRights.rights.create);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void checkRightsTest_Fail()
        {
            var expected = false;
            var actual = userRights.checkRights(userRights.rights.none, userRights.rights.create);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getRightsNumericvalueTest_Success()
        {
            var expected = 15;
            var actual = userRights.getRightsNumericvalue(userRights.rights.FullControl);
            Assert.AreEqual(expected, actual);
        }
    }
}