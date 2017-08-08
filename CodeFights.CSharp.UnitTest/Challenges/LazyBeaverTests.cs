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
    public class LazyBeaverTests
    {
        [TestMethod()]
        public void lazyBeaverTest()
        {
            var l = new LazyBeaver();
            Func<string, int> parse = int.Parse;
            var t1 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,1], 
 [1,1,-1,1,0,-1]]", parse);
            var t2 = Util.ParseJaggedArray(@"[[0,1,1,1,1,-1], 
 [0,1,-1,1,2,0], 
 [1,1,1,-1,1,2]]", parse);
            var t3 = Util.ParseJaggedArray(@"[[1,1,1,1,1,-1], 
 [1,0,-1,1,1,2], 
 [1,1,-1,-1,2,0]]", parse);
            Assert.AreEqual(4, l.lazyBeaver(t1, t2, t3));

            t1 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,3], 
 [0,0,-1,1,2,2], 
 [1,1,-1,-1,2,0], 
 [1,0,1,-1,-1,0]]", parse);
            t2 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,3], 
 [1,0,-1,1,2,1], 
 [1,1,1,-1,0,0], 
 [1,0,1,-1,-1,2]]", parse);
            t3 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,2], 
 [1,1,1,1,2,1], 
 [1,0,1,-1,3,4], 
 [1,1,-1,-1,0,3], 
 [1,0,1,-1,-1,0]]", parse);
            Assert.AreEqual(11, l.lazyBeaver(t1, t2, t3));

            t1 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,3], 
 [1,0,-1,1,2,1], 
 [1,1,1,-1,0,0], 
 [1,0,1,-1,-1,2]]", parse);
            t2 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,3], 
 [0,0,-1,1,2,2], 
 [1,1,-1,-1,2,0], 
 [1,0,1,-1,-1,0]]", parse);
            t3 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,2], 
 [1,1,1,1,2,1], 
 [1,0,1,-1,3,4], 
 [1,1,-1,-1,0,3], 
 [1,0,1,-1,-1,0]]", parse);
            Assert.AreEqual(11, l.lazyBeaver(t1, t2, t3));

            t1 = Util.ParseJaggedArray(@"[[1,1,1,1,4,4], 
 [1,1,-1,1,2,2], 
 [0,1,-1,1,0,0], 
 [1,0,-1,-1,-1,-1], 
 [0,0,-1,-1,1,1]]", parse);
            t2 = Util.ParseJaggedArray(@"[[1,1,1,-1,1,1], 
 [1,0,-1,-1,0,2], 
 [1,1,1,-1,-1,3], 
 [1,0,1,1,3,0]]", parse);
            t3 = Util.ParseJaggedArray(@"[[1,1,1,1,4,4], 
 [1,1,-1,1,2,2], 
 [0,1,-1,1,0,0], 
 [1,0,-1,-1,-1,-1], 
 [0,0,-1,-1,1,1]]", parse);
            Assert.AreEqual(13, l.lazyBeaver(t1, t2, t3));

            t1 = Util.ParseJaggedArray(@"[[0,1,1,-1,2,1], 
 [1,1,-1,1,2,-1], 
 [1,1,-1,1,0,2]]", parse);
            t2 = Util.ParseJaggedArray(@"[[0,1,1,1,2,-1], 
 [1,1,1,-1,2,1], 
 [0,1,-1,1,1,0]]", parse);
            t3 = Util.ParseJaggedArray(@"[[1,0,-1,-1,2,-1], 
 [1,0,1,1,1,0], 
 [0,0,-1,1,1,1]]", parse);
            Assert.AreEqual(5, l.lazyBeaver(t1, t2, t3));
        }
    }
}