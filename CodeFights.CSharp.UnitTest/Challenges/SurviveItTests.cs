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
    public class SurviveItTests
    {
        [TestMethod()]
        public void surviveItTest()
        {
            var s = new SurviveIt();
            Assert.AreEqual(8, s.surviveIt(10));
            Assert.AreEqual(8192, s.surviveIt(10000));
            Assert.AreEqual(16, s.surviveIt(29));
            Assert.AreEqual(1, s.surviveIt(1));
            Assert.AreEqual(536870912, s.surviveIt(1000000000));
        }
    }
}