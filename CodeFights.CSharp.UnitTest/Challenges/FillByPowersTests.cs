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
    public class FillByPowersTests
    {
        [TestMethod()]
        public void fillByPowersTest()
        {
            var f = new FillByPowers();
            Assert.AreEqual(3, f.fillByPowers(3, 10, 2));
            Assert.AreEqual(2, f.fillByPowers(4, 11, 3));
            Assert.AreEqual(20, f.fillByPowers(6, 261, 4));
            Assert.AreEqual(4901, f.fillByPowers(10, 5000, 3));
            Assert.AreEqual(1759, f.fillByPowers(10, 4999, 4));
            Assert.AreEqual(31, f.fillByPowers(15, 11490, 8));
            Assert.AreEqual(36, f.fillByPowers(5, 8100, 6));
            Assert.AreEqual(3948, f.fillByPowers(2, 15000, 2));
            Assert.AreEqual(2524, f.fillByPowers(15, 14770, 5));
            Assert.AreEqual(188, f.fillByPowers(13, 9000, 6));
            Assert.AreEqual(42, f.fillByPowers(8, 14700, 7));
        }
    }
}