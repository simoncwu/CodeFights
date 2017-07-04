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
    public class GoodSetTests
    {
        [TestMethod()]
        public void goodSetTest()
        {
            var g = new GoodSet();
            Assert.IsFalse(g.goodSet(new[] { 1, 2, 3 }));
            Assert.IsTrue(g.goodSet(new[] { 1, 2, 4 }));
            Assert.IsFalse(g.goodSet(new[] { 1, 2, 4, 6 }));
            Assert.IsTrue(g.goodSet(new[] { 1, 2, 4, 7 }));
            Assert.IsTrue(g.goodSet(new[] { 1, 3, 5, 7 }));
            Assert.IsTrue(g.goodSet(new[] { 0, 3, 6 }));
            Assert.IsTrue(g.goodSet(new[] { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 }));
            Assert.IsFalse(g.goodSet(new[] { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 }));
            Assert.IsTrue(g.goodSet(new[] { 2, 3, 4 }));
            Assert.IsFalse(g.goodSet(new[] { 2, 4, 6 }));
            Assert.IsTrue(g.goodSet(new[] { 3, 4, 6 }));
            Assert.IsTrue(g.goodSet(new[] { 5, 6, 7, 8, 9, 10 }));
            Assert.IsFalse(g.goodSet(new[] { 5, 6, 7, 8, 9, 10, 11 }));
            Assert.IsFalse(g.goodSet(new[] { 3, 4, 7, 11 }));
            Assert.IsFalse(g.goodSet(new[] { 2, 4, 7, 11 }));
            Assert.IsFalse(g.goodSet(new[] { 2, 4, 6, 7, 12 }));
            Assert.IsFalse(g.goodSet(new[] { 2, 4, 6, 12 }));
        }
    }
}