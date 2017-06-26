using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class LongestConsecutiveTests
    {
        [TestMethod()]
        public void longestConsecutiveTest()
        {
            var l = new LongestConsecutive();
            Assert.AreEqual(2, l.longestConsecutive(new[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(0, l.longestConsecutive(new[] { 1 }));
            Assert.AreEqual(2, l.longestConsecutive(new[] { 1, 2, 3 }));
            Assert.AreEqual(0, l.longestConsecutive(new[] { 6, 5, 4, 3, 2, 1 }));
            Assert.AreEqual(3, l.longestConsecutive(new[] { 1, 2, 15, 2147483647, 3 }));
            Assert.AreEqual(2, l.longestConsecutive(new[] { 103, 15, 31, 975, 245231, 126701 }));
            Assert.AreEqual(0, l.longestConsecutive(new[] { 63, 3276, 3640, 3855, 125, 31, 63519, 233231, 115591, 1279936, 0, 1007, 31801, 32537631, 26843545, 29826150, 30059178, 30233253, 20222500, 182655426, 1429848881 }));
            Assert.AreEqual(10, l.longestConsecutive(new[] { 32537631, 130841631, 3640, 15759, 413, 127, 254367, 58255, 29063, 75712, 255, 127, 31801, 16268319, 26843545, 3728486, 30059178, 3779237, 10097188, 91331010, 357483313 }));
            Assert.AreEqual(0, l.longestConsecutive(new[] { 0, 0 }));
        }
    }
}