using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class ModulePowerTests
    {
        [TestMethod]
        public void module_powerTest()
        {
            var m = new ModulePower();
            Assert.AreEqual("4", m.module_power("4", "3"));
            Assert.AreEqual("-5", m.module_power("-7", "2"));
            Assert.AreEqual("80", m.module_power("80", "1111"));
            Assert.AreEqual("-1", m.module_power("-999900987", "1"));
            Assert.AreEqual("0", m.module_power("-2", "1"));
            Assert.AreEqual("1", m.module_power("1", "6666666666666"));
            Assert.AreEqual("35", m.module_power("35", "2015"));
            Assert.AreEqual("1", m.module_power("35", "2016"));
            Assert.AreEqual("-98763", m.module_power("-98765", "11102"));
            Assert.AreEqual("-1", m.module_power("-98765", "11111"));
        }
    }
}