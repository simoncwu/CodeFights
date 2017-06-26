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
    public class DDeltaTests
    {
        [TestMethod()]
        public void dDeltaTest()
        {
            var d = new DDelta();
            Assert.AreEqual(0, d.dDelta(1, 2));
            Assert.AreEqual(5, d.dDelta(12345, 6));
            Assert.AreEqual(1, d.dDelta(10, 10));
            Assert.AreEqual(0, d.dDelta(65535, 16));
            Assert.AreEqual(2, d.dDelta(42, 3));
            Assert.AreEqual(11, d.dDelta(999, 16));
            Assert.AreEqual(30, d.dDelta(2047, 32));
            Assert.AreEqual(7, d.dDelta(70, 10));
            Assert.AreEqual(15, d.dDelta(240, 16));
            Assert.AreEqual(9, d.dDelta(67890, 13));
        }
    }
}