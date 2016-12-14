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
    public class RangeConsecutiveXorTests
    {
        [TestMethod]
        public void rangeConsecutiveXorTest()
        {
            var r = new RangeConsecutiveXor();
            Assert.AreEqual(7, r.rangeConsecutiveXor(1, 5));
            Assert.AreEqual(4, r.rangeConsecutiveXor(3, 4));
            Assert.AreEqual(1, r.rangeConsecutiveXor(2, 6));
            Assert.AreEqual(4, r.rangeConsecutiveXor(5, 10));
            Assert.AreEqual(1, r.rangeConsecutiveXor(5, 5));
            Assert.AreEqual(22, r.rangeConsecutiveXor(1, 20));
            Assert.AreEqual(696, r.rangeConsecutiveXor(1, 696));
            Assert.AreEqual(11, r.rangeConsecutiveXor(10, 10));
            Assert.AreEqual(53047, r.rangeConsecutiveXor(9, 53053));
            Assert.AreEqual(2, r.rangeConsecutiveXor(35, 96607));
        }
    }
}