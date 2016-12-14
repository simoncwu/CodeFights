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
    public class SquareCheckTests
    {
        [TestMethod]
        public void Square_CheckTest()
        {
            var s = new SquareCheck();
            Assert.IsTrue(s.Square_Check(new[] { 0, 0, 0, 3, 3, 3, 3, 0 }));
            Assert.IsFalse(s.Square_Check(new[] { 0, 2, 0, 4, 0, 7, 12, 2 }));
            Assert.IsTrue(s.Square_Check(new[] { 2, 1, 5, 2, 1, 4, 4, 5 }));
            Assert.IsFalse(s.Square_Check(new[] { 3, 4, 4, 3, 6, 5, 5, 6 }));
            Assert.IsTrue(s.Square_Check(new[] { 3, 4, 4, 3, 5, 4, 4, 5 }));
            Assert.IsFalse(s.Square_Check(new[] { -1, 1, -1, 3, 1, 3, 1, 0 }));
            Assert.IsTrue(s.Square_Check(new[] { 5, 7, 3, 1, 7, 3, 1, 5 }));
            Assert.IsTrue(s.Square_Check(new[] { 8, 5, 5, -2, -2, 1, 1, 8 }));
            Assert.IsFalse(s.Square_Check(new[] { -4, -7, -8, -3, -2, 8, -5, 0 }));
            Assert.IsTrue(s.Square_Check(new[] { 9, 6, 5, 6, 9, 2, 5, 2 }));
            Assert.IsFalse(s.Square_Check(new[] { -4, 4, -10, -5, 0, -7, 0, 1 }));
        }
    }
}