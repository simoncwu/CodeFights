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
    public class DanceStepsTests
    {
        [TestMethod()]
        public void danceStepsTest()
        {
            var d = new DanceSteps();
            Assert.AreEqual(4, d.danceSteps("207"));
            Assert.AreEqual(0, d.danceSteps("8"));
            Assert.AreEqual(4, d.danceSteps("221"));
            Assert.AreEqual(10, d.danceSteps("42023"));
            Assert.AreEqual(10, d.danceSteps("42923"));
            Assert.AreEqual(12, d.danceSteps("6224913"));
            Assert.AreEqual(24, d.danceSteps("695996177559"));
            Assert.AreEqual(-1, d.danceSteps("211"));
            Assert.AreEqual(7, d.danceSteps("23456789"));
            Assert.AreEqual(14, d.danceSteps("2468864212521"));
        }
    }
}