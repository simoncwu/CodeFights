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
    public class SumInRangeTests
    {
        [TestMethod()]
        public void sumInRangeTest()
        {
            var s = new SumInRange();
            var nums = new[] { 3, 0, -2, 6, -3, 2 };
            Func<string, int> parse = int.Parse;
            var queries = Util.ParseJaggedArray(@"[[0,2], 
 [2,5], 
 [0,5]]", parse);
            Assert.AreEqual(10, s.sumInRange(nums, queries));

            nums = new[] { -1000 };
            queries = new[] { new[] { 0, 0 } };
            Assert.AreEqual(999999007, s.sumInRange(nums, queries));

            nums = new[] { 34, 19, 21, 5, 1, 10, 26, 46, 33, 10 };
            queries = Util.ParseJaggedArray(@"[[3,7], 
 [3,4], 
 [3,7], 
 [4,5], 
 [0,5]]", parse);
            Assert.AreEqual(283, s.sumInRange(nums, queries));

            nums = new[] { -4, -18, -22, -14, -33, -47, -29, -35, -50, -19 };
            queries = Util.ParseJaggedArray(@"[[2,9], 
 [5,6], 
 [1,2], 
 [2,2], 
 [4,5]]", parse);
            Assert.AreEqual(999999540, s.sumInRange(nums, queries));

            nums = new[] { -23, -8, -52, -58, 93, -16, -26, 75, -77, 25, 90, -50, -31, 70, 53, -68, 96, 100, 69, 13 };
            queries = Util.ParseJaggedArray(@"[[0,4], 
 [0,8], 
 [7,7], 
 [3,4], 
 [2,3], 
 [0,3], 
 [8,8], 
 [2,2], 
 [5,7], 
 [2,2]]", parse);
            Assert.AreEqual(999999578, s.sumInRange(nums, queries));

            nums = new[] { -77, 54, -59, -94, -13, -78, -81, -38, -26, 17, -73, -88, 90, -42, -63, -36, 37, 25, -22, 4, 25, -86, -44, 88, 2, -47, -29, 71, 54, -42 };
            queries = Util.ParseJaggedArray(@"[[2,2], 
 [4,7], 
 [2,4], 
 [0,2], 
 [3,6], 
 [6,6], 
 [3,3], 
 [2,7], 
 [3,4], 
 [3,3], 
 [2,9], 
 [0,1], 
 [4,4], 
 [2,3], 
 [0,6], 
 [4,4], 
 [2,3], 
 [0,5], 
 [2,5], 
 [4,5]]", parse);
            Assert.AreEqual(999996808, s.sumInRange(nums, queries));

            nums = new[] { 1000 };
            queries = new[] { new[] { 0, 0 } };
            Assert.AreEqual(1000, s.sumInRange(nums, queries));
        }
    }
}