using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class GraphDistancesTests
    {
        [TestMethod()]
        public void graphDistancesTest()
        {
            var gd = new GraphDistances();
            var g = Util.ParseJaggedArray(@"[[-1,3,2], 
 [2,-1,0], 
 [-1,0,-1]]", int.Parse);
            var expected = new[] { 0, 2, 2 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 0)));

            g = Util.ParseJaggedArray(@"[[-1,1,2], 
 [0,-1,3], 
 [0,0,-1]]", int.Parse);
            expected = new[] { 0, 0, 2 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 1)));

            g = Util.ParseJaggedArray(@"[[-1,0,0,0], 
 [-1,-1,-1,-1], 
 [1,1,-1,1], 
 [2,2,0,-1]]", int.Parse);
            expected = new[] { 1, 1, 0, 0 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 3)));

            g = Util.ParseJaggedArray(@"[[-1,-1,2], 
 [1,-1,0], 
 [-1,1,-1]]", int.Parse);
            expected = new[] { 0, 3, 2 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 0)));

            g = Util.ParseJaggedArray(@"[[-1,1,4], 
 [1,-1,4], 
 [4,4,-1]]", int.Parse);
            expected = new[] { 0, 1, 4 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 0)));

            g = Util.ParseJaggedArray(@"[[-1,3,2,-1], 
 [3,-1,-1,1], 
 [2,-1,-1,3], 
 [-1,1,3,-1]]", int.Parse);
            expected = new[] { 4, 1, 3, 0 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 3)));

            g = Util.ParseJaggedArray(@"[[-1,5,20], 
 [21,-1,10], 
 [-1,1,-1]]", int.Parse);
            expected = new[] { 0, 5, 15 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 0)));

            g = Util.ParseJaggedArray(@"[[-1,5,2,15], 
 [2,-1,0,3], 
 [1,-1,-1,9], 
 [0,0,0,-1]]
s: 2", int.Parse);
            expected = new[] { 1, 6, 0, 9 };
            Assert.IsTrue(expected.SequenceEqual(gd.graphDistances(g, 2)));
        }
    }
}