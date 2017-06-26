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
    public class MaxDiscountTests
    {
        [TestMethod()]
        public void maxDiscountTest()
        {
            var m = new MaxDiscount();
            Assert.AreEqual(26, m.maxDiscount(new[] { 10, 20, 17, 7, 16, 19, 16 }));
            Assert.AreEqual(7, m.maxDiscount(new[] { 1, 2, 7, 8, 10, 2 }));
            Assert.AreEqual(28, m.maxDiscount(new[] { 8, 15, 16, 12, 20, 18, 16, 15 }));
            Assert.AreEqual(137, m.maxDiscount(new[] { 85, 23, 22, 94, 27, 23, 86, 25, 85, 90, 73, 67 }));
            Assert.AreEqual(182, m.maxDiscount(new[] { 69, 68, 42, 68, 82, 21, 53, 39, 42, 61, 54, 22, 63, 58, 59 }));
            Assert.AreEqual(240, m.maxDiscount(new[] { 53, 91, 53, 46, 70, 50, 70, 63, 81, 48, 20, 95, 35, 80, 68, 21, 48, 40, 22, 93 }));
            Assert.AreEqual(137, m.maxDiscount(new[] { 85, 23, 22, 94, 27, 23, 86, 25, 85, 90, 73, 67 }));
            Assert.AreEqual(1, m.maxDiscount(new[] { 3, 1, 2 }));
            Assert.AreEqual(519, m.maxDiscount(new[] { 33, 91, 73, 29, 47, 62, 47, 69, 70, 98, 46, 52, 49, 95, 83, 72, 29, 49, 36, 95, 34, 54, 21, 96, 62, 43, 64, 80, 50, 30, 48, 90, 27, 41, 70, 35, 72, 43, 31, 30 }));
        }
    }
}