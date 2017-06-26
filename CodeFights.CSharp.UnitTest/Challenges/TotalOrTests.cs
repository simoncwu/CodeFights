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
    public class TotalOrTests
    {
        [TestMethod()]
        public void totalOrTest()
        {
            var t = new TotalOr();
            Assert.AreEqual(7, t.totalOr(5));
            Assert.AreEqual(1, t.totalOr(1));
            Assert.AreEqual(3, t.totalOr(3));
            Assert.AreEqual(31, t.totalOr(23));
            Assert.AreEqual(63, t.totalOr(45));
            Assert.AreEqual(127, t.totalOr(99));
            Assert.AreEqual(255, t.totalOr(150));
            Assert.AreEqual(1023, t.totalOr(999));
            Assert.AreEqual(2047, t.totalOr(1979));
            Assert.AreEqual(4095, t.totalOr(2079));
            Assert.AreEqual(2147483647, t.totalOr(1073741824));
        }
    }
}