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
    public class Minesweeper1Tests
    {
        [TestMethod()]
        public void minesweeper1Test()
        {
            var m = new Minesweeper1();
            var gameboard = Util.ParseJaggedArray(@"[[0,0,0,0,0], 
 [0,1,1,1,0], 
 [0,1,9,1,0], 
 [0,1,1,1,0], 
 [0,0,0,0,0]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,0], 
 [0,0,0], 
 [0,0,0]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,1,9,1], 
 [0,1,1,1], 
 [0,0,0,0]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,9,9], 
 [9,9,9], 
 [9,9,9]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[1,1,1], 
 [1,1,1], 
 [1,1,1]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,1,2], 
 [3,4,5], 
 [6,7,8]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,2,9], 
 [2,4,2], 
 [9,2,9]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,2,9], 
 [2,9,2], 
 [9,2,9]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,3,9], 
 [3,9,3], 
 [9,3,9]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,9,9], 
 [9,8,9], 
 [9,9,9]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,0,1,1], 
 [0,0,0,1,9], 
 [0,0,0,2,1], 
 [0,0,0,1,9], 
 [0,0,0,1,1]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[9,1,1,9], 
 [1,1,1,1], 
 [1,1,1,1], 
 [9,1,1,9]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,0,0,0,0,0,0,0,0], 
 [0,0,0,0,0,1,1,1,0,0], 
 [0,0,0,0,0,1,9,1,0,0], 
 [0,0,0,0,0,1,2,1,0,0], 
 [1,1,0,0,0,0,0,1,1,1], 
 [9,1,0,0,0,0,0,1,9,1]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,1,9], 
 [1,0,1,1], 
 [1,0,0,0], 
 [0,0,0,0]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,1,9], 
 [1,0,1,1], 
 [0,0,0,0], 
 [0,0,0,0]]", int.Parse);
            Assert.IsFalse(m.minesweeper1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[0,0,1,9], 
 [0,0,1,1], 
 [0,0,0,0], 
 [0,0,0,0]]", int.Parse);
            Assert.IsTrue(m.minesweeper1(gameboard));
        }
    }
}