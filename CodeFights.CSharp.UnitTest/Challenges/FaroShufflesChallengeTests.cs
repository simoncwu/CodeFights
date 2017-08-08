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
    public class FaroShufflesChallengeTests
    {
        [TestMethod()]
        public void FaroShufflesTest()
        {
            var f = new FaroShufflesChallenge();
            Assert.AreEqual(3, f.FaroShuffles(8));
            Assert.AreEqual(8, f.FaroShuffles(52));
            Assert.AreEqual(22, f.FaroShuffles(70));
            Assert.AreEqual(10, f.FaroShuffles(12));
            Assert.AreEqual(996, f.FaroShuffles(2172));
            Assert.AreEqual(992, f.FaroShuffles(5954));
        }
    }
}