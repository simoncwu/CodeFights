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
    public class CandyCrush2Tests
    {
        [TestMethod()]
        public void candyCrush2Test()
        {
            var c = new CandyCrush2();
            var gameboard = new[] {
                "RGGB".ToCharArray(),
                "BOGG".ToCharArray(),
                "POBP".ToCharArray(),
                "YBYO".ToCharArray()
            };
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 0, 1 }, 'D'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 1 }, 'U'));
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 2, 2 }, 'L'));
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 0, 1 }, 'L'));

            gameboard = new[]
            {
                "RYR".ToCharArray(),
                "YRY".ToCharArray(),
                "RYR".ToCharArray()
            };
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 1 }, 'U'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 1 }, 'L'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 1 }, 'R'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 1 }, 'D'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 2 }, 'L'));
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 1, 2 }, 'U'));
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 1, 2 }, 'D'));
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 1, 0 }, 'D'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 1, 0 }, 'R'));

            gameboard = new[]
            {
                "ROYOORORRG".ToCharArray()
            };
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 0, 1 }, 'L'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 0, 5 }, 'R'));
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 0, 2 }, 'L'));

            gameboard = new[]
            {
                new[] { 'R'},
                new[] { 'O'},
                new[] { 'Y'},
                new[] { 'O'},
                new[] { 'O'},
                new[] { 'R'},
                new[] { 'O'},
                new[] { 'R'},
                new[] { 'R'},
                new[] { 'G'}
            };
            Assert.IsTrue(c.candyCrush2(gameboard, new[] { 2, 0 }, 'U'));

            gameboard = new[]
            {
                "PBPBPBPB".ToCharArray(),
                "YRPRYGGB".ToCharArray(),
                "BPROGPGO".ToCharArray(),
                "ORPGYOOB".ToCharArray(),
                "RORROGOO".ToCharArray(),
                "YBYBYOYB".ToCharArray(),
                "BGYBYYOP".ToCharArray(),
                "POOGGYBO".ToCharArray()
            };
            Assert.IsFalse(c.candyCrush2(gameboard, new[] { 2, 4 }, 'R'));
        }
    }
}