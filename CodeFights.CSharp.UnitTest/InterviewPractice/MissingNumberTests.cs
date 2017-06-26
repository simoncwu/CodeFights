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
    public class MissingNumberTests
    {
        [TestMethod()]
        public void missingNumberTest()
        {
            var m = new MissingNumber();
            Assert.AreEqual(2, m.missingNumber(new[] { 3, 1, 0 }));
            Assert.AreEqual(1, m.missingNumber(new[] { 0 }));
            Assert.AreEqual(0, m.missingNumber(new[] { 1, 2 }));
            Assert.AreEqual(2, m.missingNumber(new[] { 0, 1 }));
            Assert.AreEqual(0, m.missingNumber(new[] { 3, 1, 2 }));
            Assert.AreEqual(0, m.missingNumber(new[] { 3, 2, 1 }));
            Assert.AreEqual(4, m.missingNumber(new[] { 5, 2, 1, 6, 3, 0 }));
            Assert.AreEqual(1, m.missingNumber(new[] { 8, 6, 7, 0, 2, 5, 4, 3 }));
            Assert.AreEqual(2, m.missingNumber(new[] { 0, 3, 5, 8, 4, 6, 1, 9, 7 }));
            Assert.AreEqual(0, m.missingNumber(new[] { 2, 9, 8, 1, 3, 6, 7, 4, 5 }));
            Assert.AreEqual(8, m.missingNumber(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
            Assert.AreEqual(3, m.missingNumber(new[] { 1, 8, 4, 6, 2, 0, 9, 7, 5 }));
            Assert.AreEqual(8, m.missingNumber(new[] { 1, 2, 5, 0, 6, 7, 9, 3, 4 }));
            Assert.AreEqual(18, m.missingNumber(new[] { 45, 35, 38, 13, 12, 23, 48, 15, 44, 21, 43, 26, 6, 37, 1, 19, 22, 3, 11, 32, 4, 16, 28, 49, 29, 36, 33, 8, 9, 39, 46, 17, 41, 7, 2, 5, 27, 20, 40, 34, 30, 25, 47, 0, 31, 42, 24, 10, 14 }));
            Assert.AreEqual(33, m.missingNumber(new[] { 44, 26, 34, 25, 23, 42, 0, 43, 38, 14, 47, 19, 49, 6, 16, 41, 24, 35, 10, 4, 32, 5, 8, 15, 31, 3, 46, 22, 2, 30, 28, 37, 1, 21, 39, 45, 9, 48, 36, 17, 7, 27, 18, 29, 13, 40, 11, 20, 12 }));
        }
    }
}