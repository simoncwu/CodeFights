using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass]
    public class NumberRuleChallengeTests
    {
        [TestMethod]
        public void NumberRuleTest()
        {
            var n = new NumberRuleChallenge();
            Assert.IsTrue(n.NumberRule(1));
            Assert.IsTrue(n.NumberRule(124));
            Assert.IsTrue(n.NumberRule(248));
            Assert.IsFalse(n.NumberRule(753));
            Assert.IsFalse(n.NumberRule(253));
            Assert.IsFalse(n.NumberRule(483));
            Assert.IsTrue(n.NumberRule(123));
            Assert.IsFalse(n.NumberRule(1000000000));
            Assert.IsTrue(n.NumberRule(99999999));
            Assert.IsTrue(n.NumberRule(0));
            Assert.IsFalse(n.NumberRule(825743724));
            Assert.IsTrue(n.NumberRule(222888889));
            Assert.IsFalse(n.NumberRule(11825148));
            Assert.IsTrue(n.NumberRule(14445668));
            Assert.IsFalse(n.NumberRule(592855757));
        }
    }
}