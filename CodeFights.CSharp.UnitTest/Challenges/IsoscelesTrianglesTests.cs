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
    public class IsoscelesTrianglesTests
    {
        [TestMethod()]
        public void isoscelesTrianglesTest()
        {
            var i = new IsoscelesTriangles();
            Assert.AreEqual(15, i.isoscelesTriangles(new[] { 5, 3, 5, 10, 1, 10, 10 }));
            Assert.AreEqual(41, i.isoscelesTriangles(new[] { 5, 3, 2, 9, 5, 4, 9, 5, 5 }));
            Assert.AreEqual(0, i.isoscelesTriangles(new[] { 1, 2, 3 }));
            Assert.AreEqual(10, i.isoscelesTriangles(new[] { 1, 1, 1, 1, 1 }));
            Assert.AreEqual(84, i.isoscelesTriangles(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 }));
            Assert.AreEqual(4, i.isoscelesTriangles(new[] { 1, 2, 1, 4, 5, 4, 10 }));
            Assert.AreEqual(12, i.isoscelesTriangles(new[] { 5, 5, 10, 6, 6, 11, 7, 8, 9 }));
            Assert.AreEqual(0, i.isoscelesTriangles(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }));
            Assert.AreEqual(8436, i.isoscelesTriangles(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }));
            Assert.AreEqual(22, i.isoscelesTriangles(new[] { 5, 3, 2, 9, 5, 4, 9, 5 }));
        }
    }
}