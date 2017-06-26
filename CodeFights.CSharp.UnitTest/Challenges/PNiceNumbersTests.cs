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
    public class PNiceNumbersTests
    {
        [TestMethod()]
        public void pNiceNumbersTest()
        {
            var p = new PNiceNumbers();
            Assert.AreEqual(15, p.pNiceNumbers(16, 2));
            Assert.AreEqual(17, p.pNiceNumbers(20, 19));
            Assert.AreEqual(1856, p.pNiceNumbers(2017, 3));
            Assert.AreEqual(36, p.pNiceNumbers(38, 19));
            Assert.AreEqual(802987210, p.pNiceNumbers(999999999, 41));
        }
    }
}