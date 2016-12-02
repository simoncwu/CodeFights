using CodeFights.CSharp.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class FindClosestPointWithInclinationChallengeTests
    {
        [TestMethod()]
        public void FindClosestPointWithInclinationTest()
        {
            var f = new FindClosestPointWithInclinationChallenge();
            Assert.AreEqual(2, f.FindClosestPointWithInclination(5, 0.3, 2.4));
            Assert.AreEqual(3, f.FindClosestPointWithInclination(5, 0.3, 2.71));
            Assert.AreEqual(8, f.FindClosestPointWithInclination(5, 0.3, 7.3));
            Assert.AreEqual(10, f.FindClosestPointWithInclination(5, 0.3, 9.31));
            Assert.AreEqual(8, f.FindClosestPointWithInclination(10, 0.3, 7.71));
            Assert.AreEqual(7, f.FindClosestPointWithInclination(10, 0.3, 7.69));
            Assert.AreEqual(0, f.FindClosestPointWithInclination(1, 0.4, 0.2));
            Assert.AreEqual(3, f.FindClosestPointWithInclination(9, 0.3, 3.3));
            Assert.AreEqual(4, f.FindClosestPointWithInclination(4, 0.3, 4.2));
            Assert.AreEqual(5, f.FindClosestPointWithInclination(4, 0.3, 4.4));
            Assert.AreEqual(3, f.FindClosestPointWithInclination(5, 0.3, 3.7));
            Assert.AreEqual(8, f.FindClosestPointWithInclination(8, 0.5, 8));
        }
    }
}