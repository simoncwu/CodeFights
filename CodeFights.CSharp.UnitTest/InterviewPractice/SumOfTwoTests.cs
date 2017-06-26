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
    public class SumOfTwoTests
    {
        [TestMethod()]
        public void sumOfTwoTest()
        {
            var s = new SumOfTwo();
            int[] a = { 1, 2, 3 }, b = { 10, 20, 30, 40 };
            var v = 42;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 1, 2, 3 };
            b = new[] { 10, 20, 30, 40 };
            v = 50;
            Assert.IsFalse(s.sumOfTwo(a, b, v));

            a = new int[0];
            b = new[] { 1, 2, 3, 4 };
            v = 4;
            Assert.IsFalse(s.sumOfTwo(a, b, v));

            a = new[] { 10, 1, 5, 3, 8 };
            b = new[] { 100, 6, 3, 1, 5 };
            v = 4;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 1, 4, 3, 6, 10, 1, 0, 1, 6, 5 };
            b = new[] { 9, 5, 6, 9, 0, 1, 2, 1, 6, 10 };
            v = 8;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 3, 2, 3, 7, 5, 0, 3, 0, 4, 2 };
            b = new[] { 6, 8, 2, 9, 7, 10, 3, 8, 6, 0 };
            v = 2;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 4, 6, 4, 2, 9, 6, 6, 2, 9, 2 };
            b = new[] { 3, 4, 5, 1, 4, 10, 9, 9, 6, 4 };
            v = 5;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 6, 10, 25, 13, 20, 21, 11, 10, 18, 21 };
            b = new[] { 21, 10, 6, 0, 29, 25, 1, 17, 19, 25 };
            v = 37;
            Assert.IsTrue(s.sumOfTwo(a, b, v));

            a = new[] { 22, 26, 6, 22, 17, 11, 9, 22, 7, 12 };
            b = new[] { 14, 25, 22, 27, 22, 30, 6, 26, 30, 27 };
            v = 56;
            Assert.IsTrue(s.sumOfTwo(a, b, v));
        }
    }
}