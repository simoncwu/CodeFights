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
    public class Minesweeper2Tests
    {
        [TestMethod()]
        public void minesweeper2Test()
        {
            var m = new Minesweeper2();
            var gameboard = Util.ParseJaggedArray(@"[[0,1,9,1], 
 [0,1,2,2], 
 [0,0,1,9], 
 [0,0,1,1]]", int.Parse);
            var opening = Util.ParseJaggedArray(@"[[false,false,false,false], 
 [false,false,false,false], 
 [false,false,false,false], 
 [false,false,false,false]]", bool.Parse);
            var moves = Util.ParseJaggedArray(@"[[3,0]]", int.Parse);
            var expected = "[[true,true,false,false],[true,true,true,false],[true,true,true,false],[true,true,true,false]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[0,1,9,1,0], 
 [0,2,2,2,0], 
 [0,1,9,2,1], 
 [0,1,2,9,1], 
 [0,0,1,2,2], 
 [0,0,0,1,9]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false,false,false], 
 [false,false,false,false,false], 
 [false,false,false,false,false], 
 [false,false,false,false,false], 
 [false,false,false,false,false], 
 [false,false,false,false,false]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[0,4], 
 [4,0]]", int.Parse);
            expected = "[[true,true,false,true,true],[true,true,false,true,true],[true,true,false,true,true],[true,true,true,false,false],[true,true,true,true,false],[true,true,true,true,false]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[9,2,1], 
 [1,2,9], 
 [0,1,1]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false], 
 [false,false,false], 
 [false,false,false]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[0,0]]", int.Parse);
            expected = "[]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[0,0,0], 
 [0,0,0], 
 [0,0,0]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false], 
 [false,false,false], 
 [false,false,false]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[1,2]]", int.Parse);
            expected = "[[true,true,true],[true,true,true],[true,true,true]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[9,1,0], 
 [1,1,0], 
 [0,0,0]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false], 
 [false,false,false], 
 [false,false,false]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[2,2]]", int.Parse);
            expected = "[[false,true,true],[true,true,true],[true,true,true]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[9,2,9], 
 [2,4,2], 
 [9,2,9]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false], 
 [false,false,false], 
 [false,false,false]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[1,1]]", int.Parse);
            expected = "[[false,false,false],[false,true,false],[false,false,false]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());

            gameboard = Util.ParseJaggedArray(@"[[9,1,1,9], 
 [1,2,2,2], 
 [0,1,9,1], 
 [0,1,1,1]]", int.Parse);
            opening = Util.ParseJaggedArray(@"[[false,false,false,false], 
 [false,false,false,false], 
 [false,false,false,false], 
 [false,false,false,true]]", bool.Parse);
            moves = Util.ParseJaggedArray(@"[[1,2], 
 [2,1], 
 [3,0]]", int.Parse);
            expected = "[[false,false,false,false],[true,true,true,false],[true,true,false,false],[true,true,false,true]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(m.minesweeper2(gameboard, opening, moves)).ToLower());
        }
    }
}