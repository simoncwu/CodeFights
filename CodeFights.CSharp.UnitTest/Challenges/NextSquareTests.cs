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
    public class NextSquareTests
    {
        [TestMethod()]
        public void nextSquareTest()
        {
            var n = new NextSquare();
            Assert.AreEqual(9, n.nextSquare(5));
            Assert.AreEqual(36, n.nextSquare(35));
            Assert.AreEqual(10000, n.nextSquare(9802));
            Assert.AreEqual(16, n.nextSquare(9));
            Assert.AreEqual(900, n.nextSquare(847));
            Assert.AreEqual(81, n.nextSquare(77));
            Assert.AreEqual(729, n.nextSquare(687));
            Assert.AreEqual(81, n.nextSquare(75));
            Assert.AreEqual(484, n.nextSquare(448));
            Assert.AreEqual(256, n.nextSquare(227));
        }
    }
}