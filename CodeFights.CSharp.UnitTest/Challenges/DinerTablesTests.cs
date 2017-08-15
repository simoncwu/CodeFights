using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class DinerTablesTests
    {
        [TestMethod()]
        public void dinerTablesTest()
        {
            var d = new DinerTables();
            Assert.AreEqual(5, d.dinerTables(100));
            Assert.AreEqual(1, d.dinerTables(0));
            Assert.AreEqual(2, d.dinerTables(1));
            Assert.AreEqual(3, d.dinerTables(4));
            Assert.AreEqual(18, d.dinerTables(2251799813685248));
            Assert.AreEqual(12, d.dinerTables(123456789));
            Assert.AreEqual(8, d.dinerTables(25914));
        }
    }
}