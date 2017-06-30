using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class AlmostRootSumTests
    {
        [TestMethod()]
        public void almostRootSumTest()
        {
            var a = new AlmostRootSum();
            Assert.AreEqual(92681, a.almostRootSum(2147483647));
            Assert.AreEqual(7, a.almostRootSum(16));
            Assert.AreEqual(22221, a.almostRootSum(123456789));
            Assert.AreEqual(3, a.almostRootSum(3));
            Assert.AreEqual(9, a.almostRootSum(25));
            Assert.AreEqual(15, a.almostRootSum(64));
            Assert.AreEqual(5, a.almostRootSum(8));
            Assert.AreEqual(19, a.almostRootSum(97));
            Assert.AreEqual(89, a.almostRootSum(2000));
            Assert.AreEqual(109, a.almostRootSum(3000));
        }
    }
}