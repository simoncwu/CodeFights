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
    [TestClass()]
    public class ChainReaction1Tests
    {
        [TestMethod()]
        public void chainReaction1Test()
        {
            var c = new ChainReaction1();
            var moves = Util.ParseJaggedArray(@"[[0,0], 
 [0,0]]", int.Parse);
            var expected = "[[0,1,0,0],[1,0,0,0],[0,0,0,0],[0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(4, moves)));

            moves = Util.ParseJaggedArray(@"[[1,1], 
 [1,2], 
 [1,1], 
 [1,2], 
 [1,1], 
 [1,2], 
 [1,1]]", int.Parse);
            expected = "[[0,1,1,0],[1,1,0,1],[0,1,1,0],[0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(4, moves)));

            moves = Util.ParseJaggedArray(@"[[1,1],
 [1,2], 
 [2,2], 
 [1,2], 
 [2,1], 
 [0,0], 
 [0,2]]", int.Parse);
            expected = "[[1,0,1],[0,1,2],[0,1,1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(3, moves)));

            moves = Util.ParseJaggedArray(@"[[0,0], 
 [1,0], 
 [0,5], 
 [1,5], 
 [0,1], 
 [0,4], 
 [1,0], 
 [0,1], 
 [0,4], 
 [1,5], 
 [1,1], 
 [1,4], 
 [1,2], 
 [1,2], 
 [1,2], 
 [1,1], 
 [0,3], 
 [0,3], 
 [0,2], 
 [1,4], 
 [1,1], 
 [1,2]]", int.Parse);
            expected = "[[1,2,1,1,2,1],[1,2,2,3,0,1],[1,1,1,0,1,1],[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(6, moves)));

            moves = Util.ParseJaggedArray(@"[[0,0], 
 [1,0], 
 [0,5], 
 [1,5], 
 [0,1], 
 [0,4], 
 [1,0], 
 [0,1], 
 [0,4], 
 [1,5], 
 [1,1], 
 [1,4], 
 [1,2], 
 [1,2], 
 [1,2], 
 [1,1], 
 [0,3], 
 [0,3], 
 [0,2], 
 [1,4], 
 [1,1], 
 [1,1]]", int.Parse);
            expected = "[[1,2,1,1,2,1],[1,3,1,3,0,1],[1,1,1,0,1,1],[0,0,0,0,0,0],[0,0,0,0,0,0],[0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(6, moves)));

            moves = Util.ParseJaggedArray(@"[[0,0], 
 [1,1], 
 [1,1], 
 [1,1], 
 [1,1]]", int.Parse);
            expected = "[[1,1,0],[1,0,1],[0,1,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(3, moves)));

            moves = Util.ParseJaggedArray(@"[[0,0], 
 [0,1], 
 [0,2], 
 [0,3], 
 [1,0], 
 [1,1], 
 [1,2], 
 [1,3], 
 [2,0], 
 [2,1], 
 [2,2], 
 [2,3], 
 [3,0], 
 [3,1], 
 [3,2], 
 [3,3], 
 [0,1], 
 [0,2], 
 [0,3], 
 [1,0], 
 [1,1], 
 [1,2], 
 [2,0], 
 [2,1], 
 [2,2], 
 [3,0], 
 [1,1], 
 [1,2], 
 [2,1], 
 [2,2]]", int.Parse);
            expected = "[[1,2,2,2,0],[2,3,3,1,0],[2,3,3,1,0],[2,1,1,1,0],[0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.chainReaction1(5, moves)));
        }
    }
}