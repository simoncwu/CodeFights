using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class StringMazeTests
    {
        [TestMethod]
        public void stringMazeTest()
        {
            var s = new StringMaze();
            Assert.AreEqual(2, s.stringMaze("able"));
            Assert.AreEqual(-1, s.stringMaze("aced"));
            Assert.AreEqual(2, s.stringMaze("uber"));
            Assert.AreEqual(4, s.stringMaze("fffff"));
            Assert.AreEqual(3, s.stringMaze("ghghgh"));
            Assert.AreEqual(-1, s.stringMaze("ccdhdbhdc"));
            Assert.AreEqual(8, s.stringMaze("ccdhdbhcd"));
            Assert.AreEqual(10, s.stringMaze("aesvdjjfrizknthijnacdkz"));
        }
    }
}