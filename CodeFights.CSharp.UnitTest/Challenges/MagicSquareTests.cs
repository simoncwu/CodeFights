using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class MagicSquareTests
    {
        [TestMethod]
        public void magicSquareTest()
        {
            var m = new MagicSquare();
            Assert.AreEqual("[[2,7,6],[9,5,1],[4,3,8]]", Util.JaggedArrayToString(m.magicSquare(1, 1, 3)));
            Assert.AreEqual("[[2017,2024,2115,2122],[2094,2108,2031,2045],[2101,2059,2080,2038],[2066,2087,2052,2073]]", Util.JaggedArrayToString(m.magicSquare(2017, 7, 4)));
            Assert.AreEqual("[[-2017]]", Util.JaggedArrayToString(m.magicSquare(-2017, 7, 1)));
            Assert.AreEqual("[]", Util.JaggedArrayToString(m.magicSquare(4, 3, 2)));
        }
    }
}