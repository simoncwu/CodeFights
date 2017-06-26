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
    public class ChemicalsChallengeTests
    {
        [TestMethod()]
        public void ChemicalsTest()
        {
            var c = new ChemicalsChallenge();
            Assert.AreEqual(4, c.Chemicals(18, new[] { 1, 2, 5, 10 }));
            Assert.AreEqual(3, c.Chemicals(9, new[] { 1, 4, 6 }));
            Assert.AreEqual(2, c.Chemicals(4, new[] { 1, 2, 3 }));
            Assert.AreEqual(3, c.Chemicals(37, new[] { 0, 3, 17, 36, 57, 81, 92 }));
            Assert.AreEqual(0, c.Chemicals(0, new[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(92, c.Chemicals(39883, new[] { 383, 440, 449 }));
            Assert.AreEqual(26, c.Chemicals(20985, new[] { 340, 455, 606, 810, 934 }));
            Assert.AreEqual(-1, c.Chemicals(40119, new[] { 391, 475 }));
            Assert.AreEqual(122, c.Chemicals(24042, new[] { 31, 39, 89, 92, 102, 111, 141, 174, 180, 184, 186, 199 }));
        }
    }
}