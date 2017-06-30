using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class ContainsCloseNumsTests
    {
        [TestMethod()]
        public void containsCloseNumsTest()
        {
            var c = new ContainsCloseNums();
            Assert.IsTrue(c.containsCloseNums(new[] { 0, 1, 2, 3, 5, 2 }, 3));
            Assert.IsFalse(c.containsCloseNums(new[] { 0, 1, 2, 3, 5, 2 }, 2));
            Assert.IsFalse(c.containsCloseNums(new int[0], 0));
            Assert.IsTrue(c.containsCloseNums(new[] { 99, 99 }, 2));
            Assert.IsTrue(c.containsCloseNums(new[] { 2, 2 }, 3));
            Assert.IsFalse(c.containsCloseNums(new[] { 1, 2 }, 2));
            Assert.IsTrue(c.containsCloseNums(new[] { 1, 2, 1 }, 2));
            Assert.IsTrue(c.containsCloseNums(new[] { 1, 0, 1, 1 }, 1));
            Assert.IsFalse(c.containsCloseNums(new[] { 1, 2, 1 }, 0));
            Assert.IsFalse(c.containsCloseNums(new[] { 1, 2, 1 }, 1));
            Assert.IsFalse(c.containsCloseNums(new[] { 1 }, 1));
            Assert.IsTrue(c.containsCloseNums(new[] { -1, -1 }, 1));
        }
    }
}