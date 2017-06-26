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
    public class DerivativeTests
    {
        [TestMethod()]
        public void derivativeTest()
        {
            var d = new Derivative();
            Assert.AreEqual(20, d.derivative("3*x^2 - x^4 + 8", -2));
            Assert.AreEqual(1, d.derivative("x", 1));
            Assert.AreEqual(1, d.derivative("x", 2));
            Assert.AreEqual(0, d.derivative("1000", 1));
            Assert.AreEqual(54, d.derivative("2*x^3 + 10", 3));
            Assert.AreEqual(9, d.derivative("-3*x^2 + x^3 - 1000", -1));
            Assert.AreEqual(-2894816, d.derivative("23*x^8 + 53*x - -97*x^5 - -44*x^2 + 36*x - 85*x^3 - -23*x", -4));
            Assert.AreEqual(219313, d.derivative("-27*x + 43*x^7 - 89*x", -3));
            Assert.AreEqual(172, d.derivative("2*x^2 - -x^12 - 15*x^3 + 172*x", 0));
            Assert.AreEqual(-3338280, d.derivative("32*x^4 + 96*x^6 - 67*x^9 + 93*x^7", 3));
        }
    }
}