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
    public class CountValidSnakePathsTests
    {
        [TestMethod()]
        public void countValidSnakePathsTest()
        {
            var c = new CountValidSnakePaths();
            Func<string, int> parse = int.Parse;
            var board = new[] { 4, 3 };
            var snake = Util.ParseJaggedArray(@"[[2,2], [3,2], [3,1], [3,0], [2,0], [1,0], [0,0]]", parse);
            Assert.AreEqual(7, c.countValidSnakePaths(board, snake, 3));

            board = new[] { 2, 3 };
            snake = Util.ParseJaggedArray(@"[[0,2], [0,1], [0,0], [1,0], [1,1], [1,2]]", parse);
            Assert.AreEqual(1, c.countValidSnakePaths(board, snake, 10));

            board = new[] { 4, 3 };
            snake = Util.ParseJaggedArray(@"[[2,2], [3,2], [3,1], [2,1], [1,1], [0,1], [0,0]]", parse);
            Assert.AreEqual(3, c.countValidSnakePaths(board, snake, 5));

            board = new[] { 2, 2 };
            snake = Util.ParseJaggedArray(@"[[0,1], [1,1], [1,0]]", parse);
            Assert.AreEqual(1, c.countValidSnakePaths(board, snake, 10));

            board = new[] { 3, 4 };
            snake = Util.ParseJaggedArray(@"[[1,1], [1,2], [1,3]]", parse);
            Assert.AreEqual(6, c.countValidSnakePaths(board, snake, 2));

            board = new[] { 1, 10 };
            snake = Util.ParseJaggedArray(@"[[0,2], [0,1], [0,0]]", parse);
            Assert.AreEqual(1, c.countValidSnakePaths(board, snake, 7));

            board = new[] { 1, 10 };
            snake = Util.ParseJaggedArray(@"[[0,2], [0,1], [0,0]]", parse);
            Assert.AreEqual(0, c.countValidSnakePaths(board, snake, 8));

            board = new[] { 10, 10 };
            snake = Util.ParseJaggedArray(@"[[5,5], [5,4], [4,4], [4,5]]", parse);
            Assert.AreEqual(81, c.countValidSnakePaths(board, snake, 4));
        }
    }
}