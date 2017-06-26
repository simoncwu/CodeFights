using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class CountDsTests
    {
        [TestMethod()]
        public void countDsTest()
        {
            var c = new CountDs();
            Assert.AreEqual(0, c.countDs(1));
            Assert.AreEqual(5, c.countDs(5));
            Assert.AreEqual(14, c.countDs(7));
            Assert.AreEqual(20, c.countDs(8));
            Assert.AreEqual(19700, c.countDs(200));
            Assert.AreEqual(0, c.countDs(0));
            Assert.AreEqual(0, c.countDs(2));
            Assert.AreEqual(0, c.countDs(3));
            Assert.AreEqual(1293635, c.countDs(1610));
            Assert.AreEqual(197398514, c.countDs(19871));
            Assert.AreEqual(168847875, c.countDs(18378));
            Assert.AreEqual(733004615, c.countDs(38290));
            Assert.AreEqual(591327, c.countDs(1089));
            Assert.AreEqual(428088429, c.countDs(29262));
            Assert.AreEqual(699249105, c.countDs(37398));
        }
    }
}