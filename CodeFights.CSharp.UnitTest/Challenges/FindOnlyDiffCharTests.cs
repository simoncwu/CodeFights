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
    public class FindOnlyDiffCharTests
    {
        [TestMethod]
        public void findOnlyDiffCharTest()
        {
            var f = new FindOnlyDiffChar();
            Assert.AreEqual(4, f.findOnlyDiffChar(new[] { 1, 2, 3, 4 }, new[] { 3, 1, 2 }));
            Assert.AreEqual(9999, f.findOnlyDiffChar(new[] { 7, 6, 10, 100, 9999, 8, 7 }, new[] { 10, 7, 6, 8, 7, 100 }));
            Assert.AreEqual(45, f.findOnlyDiffChar(new[] { 2, 3, 4, 5, 6, 7, 8, 9, 45, 36 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 36 }));
            Assert.AreEqual(95, f.findOnlyDiffChar(new[] { 95, 52, 10, 7, 16, 58, 26, 46, 2, 93, 34, 34, 7, 75, 40, 86, 48, 10, 57, 24, 36, 96, 65, 34, 75, 95, 51, 37, 88, 58, 52, 55, 36, 38, 21, 41, 48, 80, 11, 35, 30, 26, 51, 17, 50, 18, 56, 16, 69, 64 }, new[] { 46, 10, 7, 51, 34, 7, 40, 86, 50, 48, 18, 34, 58, 58, 41, 75, 35, 11, 26, 16, 57, 55, 34, 37, 69, 21, 26, 51, 10, 95, 80, 93, 30, 96, 65, 52, 88, 38, 2, 64, 36, 17, 75, 16, 48, 36, 56, 24, 52 }));
            Assert.AreEqual(100, f.findOnlyDiffChar(new[] { 100, 99, 100, 99, 100, 99, 100 }, new[] { 99, 100, 99, 100, 99, 100 }));
        }
    }
}