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
    public class TotalSameOnesTests
    {
        [TestMethod()]
        public void totalSameOnesTest()
        {
            var t = new TotalSameOnes();
            Assert.AreEqual(4, t.totalSameOnes(8));
            Assert.AreEqual(2, t.totalSameOnes(5));
            Assert.AreEqual(1, t.totalSameOnes(1));
            Assert.AreEqual(2, t.totalSameOnes(2));
            Assert.AreEqual(1, t.totalSameOnes(3));
            Assert.AreEqual(3, t.totalSameOnes(4));
            Assert.AreEqual(2, t.totalSameOnes(23));
            Assert.AreEqual(1, t.totalSameOnes(255));
            Assert.AreEqual(326, t.totalSameOnes(2017));
            Assert.AreEqual(1548, t.totalSameOnes(9999));
        }
    }
}