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
    public class VanyaAndBook1sChallengeTests
    {
        [TestMethod]
        public void VanyaAndBook1sTest()
        {
            var v = new VanyaAndBook1sChallenge();
            Assert.AreEqual(17, v.VanyaAndBook1s(13));
            Assert.AreEqual(4, v.VanyaAndBook1s(4));
            Assert.AreEqual(192, v.VanyaAndBook1s(100));
            Assert.AreEqual(788888898, v.VanyaAndBook1s(100000000));
            Assert.AreEqual(1, v.VanyaAndBook1s(1));
            Assert.AreEqual(624, v.VanyaAndBook1s(244));
            Assert.AreEqual(32617, v.VanyaAndBook1s(8431));
        }
    }
}