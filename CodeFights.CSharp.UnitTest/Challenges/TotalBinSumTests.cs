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
    public class TotalBinSumTests
    {
        [TestMethod()]
        public void totalBinSumTest()
        {
            var t = new TotalBinSum();
            Assert.AreEqual(16, t.totalBinSum("1001"));
            Assert.AreEqual(8, t.totalBinSum("00101"));
            Assert.AreEqual(8, t.totalBinSum("101"));
            Assert.AreEqual(5567, t.totalBinSum("101011100011"));
            Assert.AreEqual(44585, t.totalBinSum("00101011100011000"));
            Assert.AreEqual(44815802, t.totalBinSum("01010101011110101011100100"));
            Assert.AreEqual(0, t.totalBinSum("00"));
            Assert.AreEqual(682221351, t.totalBinSum("111010011010111011101101011010010"));
            Assert.AreEqual(30998030, t.totalBinSum("1001101011101110111110110011010111100011010111011101101011010010"));
            Assert.AreEqual(807610166, t.totalBinSum("1111101011101110111110111000110101111000110101110111011010110100"));
        }
    }
}