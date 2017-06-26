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
    public class CoolSubsetsTests
    {
        [TestMethod()]
        public void coolSubsetsTest()
        {
            var c = new CoolSubsets();
            Assert.AreEqual(2, c.coolSubsets(new[] { 1, 7, 2, 7 }));
            Assert.AreEqual(1, c.coolSubsets(new[] { 1, 2, 3 }));
            Assert.AreEqual(3, c.coolSubsets(new[] { 0, 0 }));
            Assert.AreEqual(3, c.coolSubsets(new[] { 4, 4, 0, 0, 0, 0, 4, 0 }));
            Assert.AreEqual(1, c.coolSubsets(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Assert.AreEqual(1, c.coolSubsets(new[] { 1, 1, 1, 1, 50 }));
            Assert.AreEqual(4, c.coolSubsets(new[] { 50, 50, 50, 50, 0 }));
        }
    }
}