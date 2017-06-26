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
    public class CountCliffsTests
    {
        [TestMethod()]
        public void countCliffsTest()
        {
            var c = new CountCliffs();
            Func<string, int> parse = int.Parse;
            var seaMap = Util.ParseJaggedArray(@"[[0,1,1], 
 [0,1,1], 
 [0,0,0]]", parse);
            Assert.AreEqual(1, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[0,0,1], 
 [0,1,0], 
 [0,0,0]]", parse);
            Assert.AreEqual(2, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,0,1], 
 [1,1,0], 
 [0,0,0]]", parse);
            Assert.AreEqual(2, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,1,1,1], 
 [0,1,0,0], 
 [0,0,1,0]]", parse);
            Assert.AreEqual(2, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,1,1,1,0], 
 [0,1,0,0,1], 
 [0,0,1,0,1], 
 [1,1,0,0,0]]", parse);
            Assert.AreEqual(4, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,0,0,0,0,0,0], 
 [0,0,0,0,1,0,1], 
 [0,0,1,0,0,0,0], 
 [0,1,0,1,1,0,0]]", parse);
            Assert.AreEqual(6, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[0,0,0], 
 [0,0,0], 
 [0,0,0], 
 [0,0,0]]", parse);
            Assert.AreEqual(0, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,1,1,1], 
 [1,1,1,1], 
 [1,1,1,1]]", parse);
            Assert.AreEqual(1, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,0,1], 
 [0,0,0], 
 [0,1,0], 
 [0,0,0], 
 [1,0,1], 
 [1,1,0], 
 [0,0,0], 
 [0,1,0], 
 [1,1,0]]", parse);
            Assert.AreEqual(6, c.countCliffs(seaMap));

            seaMap = Util.ParseJaggedArray(@"[[1,0,0,0], 
 [0,1,0,0], 
 [0,1,0,0], 
 [0,1,0,0]]", parse);
            Assert.AreEqual(2, c.countCliffs(seaMap));
        }
    }
}