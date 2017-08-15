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
    public class ArrayMaxConsecutiveSum2Tests
    {
        [TestMethod()]
        public void arrayMaxConsecutiveSum2Test()
        {
            var a = new ArrayMaxConsecutiveSum2();
            Assert.AreEqual(7, a.arrayMaxConsecutiveSum2(new[] { -2, 2, 5, -11, 6 }));
            Assert.AreEqual(-1, a.arrayMaxConsecutiveSum2(new[] { -3, -2, -1, -4 }));
            Assert.AreEqual(3, a.arrayMaxConsecutiveSum2(new[] { -3, 2, 1, -4 }));
            Assert.AreEqual(8, a.arrayMaxConsecutiveSum2(new[] { 1, -2, 3, -4, 5, -3, 2, 2, 2 }));
            Assert.AreEqual(14, a.arrayMaxConsecutiveSum2(new[] { 11, -2, 1, -4, 5, -3, 2, 2, 2 }));
            Assert.AreEqual(1069, a.arrayMaxConsecutiveSum2(new[] { 89, 96, 60, 10, 24, 30, 72, 40, 74, 49, 38, 87, 55, 46, 44, 14, 49, 88, 93, 11 }));
        }
    }
}