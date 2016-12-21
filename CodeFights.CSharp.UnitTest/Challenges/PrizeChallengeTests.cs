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
    public class PrizeChallengeTests
    {
        [TestMethod]
        public void PrizeTest()
        {
            var p = new PrizeChallenge();
            Assert.AreEqual(3, p.Prize(3, 4));
            Assert.AreEqual(-1, p.Prize(2, 4));
            Assert.AreEqual(9, p.Prize(4, 7));
            Assert.AreEqual(16, p.Prize(5, 9));
            Assert.AreEqual(126, p.Prize(15, 19));
            Assert.AreEqual(-1, p.Prize(8, 12));
            Assert.AreEqual(-1, p.Prize(9, 12));
            Assert.AreEqual(278526, p.Prize(123, 4567));
            Assert.AreEqual(-1, p.Prize(5935, 8235));
            Assert.AreEqual(49985001, p.Prize(9999, 10000));
            Assert.AreEqual(0, p.Prize(1, 2));
            Assert.AreEqual(0, p.Prize(1, 10000));
            Assert.AreEqual(-1, p.Prize(15, 27));
            Assert.AreEqual(-1, p.Prize(9996, 10000));
            Assert.AreEqual(23347135, p.Prize(4800, 9731));
            Assert.AreEqual(-1, p.Prize(6666, 9999));
        }
    }
}