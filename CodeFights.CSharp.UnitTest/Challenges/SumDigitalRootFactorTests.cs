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
    public class SumDigitalRootFactorTests
    {
        [TestMethod]
        public void sumDigitalRootFactorTest()
        {
            var s = new SumDigitalRootFactor();
            Assert.AreEqual(2, s.sumDigitalRootFactor(2));
            Assert.AreEqual(9, s.sumDigitalRootFactor(4));
            Assert.AreEqual(51, s.sumDigitalRootFactor(10));
            Assert.AreEqual(2717, s.sumDigitalRootFactor(278));
            Assert.AreEqual(38145, s.sumDigitalRootFactor(3239));
        }
    }
}