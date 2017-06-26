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
    public class DigitSumInverseTests
    {
        [TestMethod()]
        public void digitSumInverseTest()
        {
            var d = new DigitSumInverse();
            Assert.AreEqual(6, d.digitSumInverse(5, 2));
            Assert.AreEqual(1, d.digitSumInverse(0, 2));
            Assert.AreEqual(1, d.digitSumInverse(90, 10));
            Assert.AreEqual(0, d.digitSumInverse(100, 10));
        }
    }
}