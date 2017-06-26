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
    public class FindScoreTests
    {
        [TestMethod()]
        public void findScoreTest()
        {
            var f = new FindScore();
            Assert.AreEqual(10, f.findScore(0, 0));
            Assert.AreEqual(1, f.findScore(1, 0));
            Assert.AreEqual(10, f.findScore(0.1, 0));
            Assert.AreEqual(8, f.findScore(0.2, 0.2));
            Assert.AreEqual(9, f.findScore(0, -0.2));
            Assert.AreEqual(3, f.findScore(0.5, 0.5));
            Assert.AreEqual(4, f.findScore(-0.45, 0.45));
            Assert.AreEqual(6, f.findScore(0.3, 0.4));
            Assert.AreEqual(8, f.findScore(0.227, -0.1393));
            Assert.AreEqual(1, f.findScore(-0.91, 0.311));
            Assert.AreEqual(4, f.findScore(-0.645, 0.001));
            Assert.AreEqual(0, f.findScore(-0.615538218153, 0.951369166449));
            Assert.AreEqual(10, f.findScore(0.097, 0.02));
        }
    }
}