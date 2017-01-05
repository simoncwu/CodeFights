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
    public class BetaExorTests
    {
        [TestMethod]
        public void betaExorTest()
        {
            var b = new BetaExor();
            Assert.AreEqual(97, b.betaExor("a"));
            Assert.AreEqual(0, b.betaExor(""));
            Assert.AreEqual(121, b.betaExor("CodeFight"));
            Assert.AreEqual(98, b.betaExor("AAbbb"));
            Assert.AreEqual(90, b.betaExor("Hint: This is a valid test! :-P"));
            Assert.AreEqual(121, b.betaExor("codefight"));
            Assert.AreEqual(41, b.betaExor("<Try to #hardcode_results, do you?>"));
        }
    }
}