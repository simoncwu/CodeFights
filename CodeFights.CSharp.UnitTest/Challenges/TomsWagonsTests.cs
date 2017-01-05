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
    public class TomsWagonsTests
    {
        [TestMethod]
        public void toms_wagonsTest()
        {
            var t = new TomsWagons();
            Assert.AreEqual(1, t.toms_wagons(1, 1, 1));
            Assert.AreEqual(24, t.toms_wagons(3, 2, 4));
            Assert.AreEqual(788, t.toms_wagons(2, 1, 30));
            Assert.AreEqual(319, t.toms_wagons(5, 10, 11));
            Assert.AreEqual(226, t.toms_wagons(12, 29, 10));
            Assert.AreEqual(0, t.toms_wagons(5, 30, 0));
            Assert.AreEqual(62, t.toms_wagons(12, 31, 2));
            Assert.AreEqual(1757, t.toms_wagons(7, 20, 57));
            Assert.AreEqual(6848, t.toms_wagons(1, 17, 222));
            Assert.AreEqual(6113, t.toms_wagons(10, 27, 205));
        }
    }
}