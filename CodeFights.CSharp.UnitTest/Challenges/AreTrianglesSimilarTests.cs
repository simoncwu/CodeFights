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
    public class AreTrianglesSimilarTests
    {
        [TestMethod()]
        public void areTrianglesSimilarTest()
        {
            var a = new AreTrianglesSimilar();
            Assert.IsTrue(a.areTrianglesSimilar(new[] { 0, 0, 0, 1, 1, 0, 0, 0, 0, -3, -3, 0 }));
            Assert.IsFalse(a.areTrianglesSimilar(new[] { 0, 0, 0, 1, 1, 0, 0, 0, 0, -4, -2, 0 }));
            Assert.IsFalse(a.areTrianglesSimilar(new[] { 0, 0, 0, 1, 1, 0, -3, 0, 0, -3, 0, 0 }));
            Assert.IsTrue(a.areTrianglesSimilar(new[] { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0 }));
            Assert.IsFalse(a.areTrianglesSimilar(new[] { 0, 0, 0, 5, 4, 0, 0, 0, 4, 3, 4, 0 }));
            Assert.IsFalse(a.areTrianglesSimilar(new[] { 0, 5, 4, 0, 0, 0, 4, 3, 4, 0, 0, 0 }));
            Assert.IsFalse(a.areTrianglesSimilar(new[] { 4, 0, 0, 0, 0, 5, 4, 0, 0, 0, 4, 3 }));
            Assert.IsTrue(a.areTrianglesSimilar(new[] { 3, 4, 4, 7, 6, 1, -2, -1, 0, 5, 4, -7 }));
        }
    }
}