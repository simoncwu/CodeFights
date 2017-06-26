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
    public class OnesPositionTests
    {
        [TestMethod()]
        public void onesPositionTest()
        {
            var o = new OnesPosition();
            Assert.AreEqual(5, o.onesPosition(15));
            Assert.AreEqual(1, o.onesPosition(1));
            Assert.AreEqual(1, o.onesPosition(2));
            Assert.AreEqual(3, o.onesPosition(21));
            Assert.AreEqual(7, o.onesPosition(107));
            Assert.AreEqual(3, o.onesPosition(28));
            Assert.AreEqual(19, o.onesPosition(29418));
            Assert.AreEqual(23, o.onesPosition(33535));
            Assert.AreEqual(0, o.onesPosition(0));
        }
    }
}