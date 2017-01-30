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
    public class PossibleRingTests
    {
        [TestMethod]
        public void possibleRingTest()
        {
            var p = new PossibleRing();
            Assert.AreEqual(4, p.possibleRing("C6H6"));
            Assert.AreEqual(1, p.possibleRing("C2H4O"));
            Assert.AreEqual(1, p.possibleRing("C3H6"));
            Assert.AreEqual(-1, p.possibleRing("CH4"));
            Assert.AreEqual(-1, p.possibleRing("1CH2"));
            Assert.AreEqual(3, p.possibleRing("C5H6O"));
            Assert.AreEqual(4, p.possibleRing("C5H5N"));
            Assert.AreEqual(-1, p.possibleRing("C5H5O"));
            Assert.AreEqual(-1, p.possibleRing("C2H6O"));
        }
    }
}