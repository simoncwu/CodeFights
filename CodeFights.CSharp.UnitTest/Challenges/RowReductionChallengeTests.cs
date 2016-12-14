using CodeFights.CSharp.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFights.CSharp.UnitTest.Util;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class RowReductionChallengeTests
    {
        [TestMethod]
        public void RowReductionTest()
        {
            var r = new RowReductionChallenge();
            Func<string, int> parse = int.Parse;
            var matrix = Util.ParseJaggedArray("[[1,5,6],[2,8,-2]]", parse);
            var expected = "[[1,0,-29],[0,1,7]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[1,6,2],[2,2,4]]", parse);
            expected = "[[1,0,2],[0,1,0]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[1,3,-1],[0,1,7]]", parse);
            expected = "[[1,0,-22],[0,1,7]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[3,54,20],[3,54,82],[5,90,8]]", parse);
            expected = "[[1,18,0],[0,0,1],[0,0,0]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[32,14,30,36],[44,19,42,52],[76,57,90,28]]", parse);
            expected = "[[1,0,0,1],[0,1,0,-4],[0,0,1,2]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[57,79,41,92],[13,21,54,18],[36,41,26,67]]", parse);
            expected = "[[1,0,0,3],[0,1,0,-1],[0,0,1,0]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[66,58,31,3],[91,43,85,20],[30,44,5,27]]", parse);
            expected = "[[1,0,0,-4],[0,1,0,3],[0,0,1,3]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[52,28,31,70],[17,46,4,72],[25,50,30,40]]", parse);
            expected = "[[1,0,0,2],[0,1,0,1],[0,0,1,-2]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));

            matrix = Util.ParseJaggedArray("[[48,66,18],[23,67,44],[25,32,7]]", parse);
            expected = "[[1,0,-1],[0,1,1],[0,0,0]]";
            Assert.AreEqual(expected, JaggedArrayToString(r.RowReduction(matrix)));
        }
    }
}