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
    public class SwapPairBitsTests
    {
        [TestMethod()]
        public void swapPairBitsTest()
        {
            var s = new SwapPairBits();
            Assert.AreEqual(817, s.swapPairBits(565, 9, 3));
            Assert.AreEqual(1, s.swapPairBits(1, 1, 1));
            Assert.AreEqual(1, s.swapPairBits(2, 2, 1));
            Assert.AreEqual(512, s.swapPairBits(4294967296, 33, 10));
            Assert.AreEqual(4294967296, s.swapPairBits(512, 33, 10));
            Assert.AreEqual(122933013, s.swapPairBits(123456789, 20, 10));
            Assert.AreEqual(1048576, s.swapPairBits(1048576, 9, 3));
        }
    }
}