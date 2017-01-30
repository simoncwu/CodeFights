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
    public class BestCoinsExchangeTests
    {
        [TestMethod]
        public void bestCoinsExchangeTest()
        {
            var b = new BestCoinsExchange();
            var expected = "[[4,1],[2,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 2, 3, 4 }, 6)));

            expected = "[[19,1],[1,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 5, 9, 19 }, 20)));

            expected = "[[10,3],[2,1],[1,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 2, 5, 10 }, 33)));

            expected = "[[10,2]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 10, 15 }, 20)));

            expected = "[[519,8],[495,1],[353,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 17, 29, 32, 47, 63, 73, 83, 103, 104, 110, 117, 127, 136, 154, 162, 168, 172, 191, 209, 213, 216, 219, 225, 244, 254, 271, 286, 296, 315, 333, 339, 343, 353, 369, 388, 396, 403, 420, 433, 438, 444, 450, 460, 476, 478, 495, 500, 502, 519 }, 5000)));

            expected = "[[15,1],[9,2]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 9, 15 }, 33)));

            expected = "[[7,1],[5,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 1, 5, 7 }, 12)));

            expected = "[[98,6],[34,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 3, 9, 11, 17, 18, 23, 25, 26, 31, 32, 33, 34, 57, 58, 63, 65, 70, 76, 77, 79, 84, 86, 87, 88, 95, 98 }, 622)));

            expected = "[[97,5],[68,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 2, 5, 10, 14, 19, 32, 41, 45, 47, 48, 59, 60, 68, 69, 71, 72, 76, 77, 81, 86, 97 }, 553)));

            expected = "[[98,1],[67,3]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.bestCoinsExchange(new[] { 6, 7, 29, 35, 46, 47, 51, 67, 72, 98 }, 299)));
        }
    }
}