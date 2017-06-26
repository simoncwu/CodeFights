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
    public class WeightYourTernTests
    {
        [TestMethod()]
        public void weightYourTernTest()
        {
            var w = new WeightYourTern();
            Assert.AreEqual(0, w.weightYourTern(8));
            Assert.AreEqual(-1, w.weightYourTern(-7));
            Assert.AreEqual(-1, w.weightYourTern(5));
            Assert.AreEqual(1, w.weightYourTern(9));
            Assert.AreEqual(0, w.weightYourTern(20));
            Assert.AreEqual(1, w.weightYourTern(29));
            Assert.AreEqual(3, w.weightYourTern(111));
            Assert.AreEqual(4, w.weightYourTern(40));
            Assert.AreEqual(4, w.weightYourTern(94));
            Assert.AreEqual(20, w.weightYourTern(1743392200));
        }
    }
}