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
    public class TableTennisGameTests
    {
        [TestMethod()]
        public void tableTennisGameTest()
        {
            var t = new TableTennisGame();
            Assert.AreEqual(1, t.tableTennisGame(11, 11, 5));
            Assert.AreEqual(0, t.tableTennisGame(11, 2, 3));
            Assert.AreEqual(14, t.tableTennisGame(1, 5, 9));
            Assert.AreEqual(2, t.tableTennisGame(1, 1, 1));
            Assert.AreEqual(3, t.tableTennisGame(27, 13, 91));
            Assert.AreEqual(2, t.tableTennisGame(5, 9, 9));
        }
    }
}