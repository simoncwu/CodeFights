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
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void longest_increasing_subsequenceTest()
        {
            var l = new LongestIncreasingSubsequence();
            Assert.AreEqual("[12,15,19]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 24, 12, 15, 15, 19 })));
            Assert.AreEqual("[5,19,28,29,83]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 5, 19, 5, 81, 50, 28, 29, 1, 83, 23 })));
            Assert.AreEqual("[2,3,7,8,18]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 2, 15, 3, 7, 8, 6, 18 })));
            Assert.AreEqual("[84]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 84 })));
            Assert.AreEqual("[14,19,47]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 96, 25, 14, 22, 19, 88, 3, 73, 47 })));
            Assert.AreEqual("[1,2,3]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 1, 2, 3 })));
            Assert.AreEqual("[1]", Util.ArrayToString(l.longest_increasing_subsequence(new[] { 3, 2, 1 })));
        }
    }
}