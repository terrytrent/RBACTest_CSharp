using Microsoft.VisualStudio.TestTools.UnitTesting;
using RBAC.Biz;
using RBAC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBAC.Biz.Tests
{
    [TestClass()]
    public class SimulateLoginTests
    {
        [TestMethod()]
        public void SimulateLoginTest_ActiveUser_ttrent()
        {
            var simulatedLogin = new SimulateLogin();
            simulatedLogin.ActiveUser = simulatedLogin.SimulatedUsers["ttrent"];

            var expected = "Active User is ttrent, rights FullControl";

            var actual = $"Active User is {simulatedLogin.ActiveUser.Username}, rights {simulatedLogin.ActiveUser.Rights}";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimulateLoginTest_ActiveUser_jjoe()
        {
            var simulatedLogin = new SimulateLogin();
            simulatedLogin.ActiveUser = simulatedLogin.SimulatedUsers["jjoe"];

            var expected = "Active User is jjoe, rights ReadOnly";

            var actual = $"Active User is {simulatedLogin.ActiveUser.Username}, rights {simulatedLogin.ActiveUser.Rights}";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimulateLoginTest_ActiveUser_cchris()
        {
            var simulatedLogin = new SimulateLogin();
            simulatedLogin.ActiveUser = simulatedLogin.SimulatedUsers["cchris"];

            var expected = "Active User is cchris, rights none";

            var actual = $"Active User is {simulatedLogin.ActiveUser.Username}, rights {simulatedLogin.ActiveUser.Rights}";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimulateLoginTest_ActiveUser_bbrian()
        {
            var simulatedLogin = new SimulateLogin();
            simulatedLogin.ActiveUser = simulatedLogin.SimulatedUsers["bbrian"];

            var expected = "Active User is bbrian, rights ReadWrite";

            var actual = $"Active User is {simulatedLogin.ActiveUser.Username}, rights {simulatedLogin.ActiveUser.Rights}";

            Assert.AreEqual(expected, actual);
        }
    }
}