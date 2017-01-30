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
    public class FindColumnNameChallengeTests
    {
        [TestMethod]
        public void FindColumnNameTest()
        {
            var f = new FindColumnNameChallenge();
            Assert.AreEqual("CV", f.FindColumnName(100));
            Assert.AreEqual("NTQ", f.FindColumnName(10001));
            Assert.AreEqual("EPKR", f.FindColumnName(99000));
            Assert.AreEqual("JXLKR", f.FindColumnName(5000000));
            Assert.AreEqual("BDWGM", f.FindColumnName(999999));
            Assert.AreEqual("BMKZFUW", f.FindColumnName(777777777));
        }
    }
}