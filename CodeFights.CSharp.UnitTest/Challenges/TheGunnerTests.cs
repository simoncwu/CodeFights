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
    public class TheGunnerTests
    {
        [TestMethod()]
        public void theGunnerTest()
        {
            var t = new TheGunner();
            Assert.AreEqual(4, t.theGunner(new[] { 5, 8, 10 }, new[] { 20, 24, 28 }));
            Assert.AreEqual(5, t.theGunner(new[] { 4, 10, 9 }, new[] { 32, 36, 25 }));
            Assert.AreEqual(14, t.theGunner(new[] { 1, 2, 7 }, new[] { 52, 24, 56 }));
            Assert.AreEqual(6, t.theGunner(new[] { 9, 10, 9 }, new[] { 60, 39 }));
            Assert.AreEqual(7, t.theGunner(new[] { 1, 2, 3 }, new[] { 20 }));
            Assert.AreEqual(8, t.theGunner(new[] { 2, 5, 6 }, new[] { 20, 38, 46 }));
            Assert.AreEqual(6, t.theGunner(new[] { 5, 8, 4 }, new[] { 39, 39, 22 }));
            Assert.AreEqual(9, t.theGunner(new[] { 9, 4, 4 }, new[] { 41, 50, 46 }));
        }
    }
}