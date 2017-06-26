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
    public class ConsecutiveBitTests
    {
        [TestMethod()]
        public void consecutiveBitTest()
        {
            var c = new ConsecutiveBit();
            Assert.IsTrue(c.consecutiveBit(3));
            Assert.IsFalse(c.consecutiveBit(21));
            Assert.IsTrue(c.consecutiveBit(12));
            Assert.IsFalse(c.consecutiveBit(1));
            Assert.IsFalse(c.consecutiveBit(5));
            Assert.IsTrue(c.consecutiveBit(15));
            Assert.IsTrue(c.consecutiveBit(101));
            Assert.IsFalse(c.consecutiveBit(337));
            Assert.IsTrue(c.consecutiveBit(511));
            Assert.IsFalse(c.consecutiveBit(87381));
            Assert.IsTrue(c.consecutiveBit(349527));
            Assert.IsTrue(c.consecutiveBit(764584));
            Assert.IsFalse(c.consecutiveBit(0));
            Assert.IsFalse(c.consecutiveBit(1));
            Assert.IsFalse(c.consecutiveBit(129));
            Assert.IsTrue(c.consecutiveBit(561));
            Assert.IsTrue(c.consecutiveBit(8913));
            Assert.IsFalse(c.consecutiveBit(35409));
            Assert.IsTrue(c.consecutiveBit(283321));
            Assert.IsFalse(c.consecutiveBit(1133225));
            Assert.IsTrue(c.consecutiveBit(2312873));
            Assert.IsFalse(c.consecutiveBit(4541097));
            Assert.IsTrue(c.consecutiveBit(4672169));
            Assert.IsTrue(c.consecutiveBit(9128617));
            Assert.IsFalse(c.consecutiveBit(18172585));
        }
    }
}