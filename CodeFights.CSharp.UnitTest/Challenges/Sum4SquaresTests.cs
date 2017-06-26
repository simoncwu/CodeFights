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
    public class Sum4SquaresTests
    {
        [TestMethod()]
        public void sum4SquaresTest()
        {
            var s = new Sum4Squares();
            Assert.AreEqual(1, s.sum4Squares(0));
            Assert.AreEqual(8, s.sum4Squares(1));
            Assert.AreEqual(192, s.sum4Squares(23));
            Assert.AreEqual(744, s.sum4Squares(50));
            Assert.AreEqual(1152, s.sum4Squares(70));
            Assert.AreEqual(288, s.sum4Squares(88));
            Assert.AreEqual(1248, s.sum4Squares(99));
            Assert.AreEqual(744, s.sum4Squares(100));
            Assert.AreEqual(1344, s.sum4Squares(123));
            Assert.AreEqual(12160, s.sum4Squares(999));
        }
    }
}