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
    public class PrimeLengthTests
    {
        [TestMethod()]
        public void primeLengthTest()
        {
            var p = new PrimeLength();
            Assert.AreEqual(6, p.primeLength(13));
            Assert.AreEqual(46, p.primeLength(101));
            Assert.AreEqual(0, p.primeLength(2));
            Assert.AreEqual(34, p.primeLength(69));
            Assert.AreEqual(995, p.primeLength(1979));
            Assert.AreEqual(1023, p.primeLength(2016));
            Assert.AreEqual(159538, p.primeLength(330246));
        }
    }
}