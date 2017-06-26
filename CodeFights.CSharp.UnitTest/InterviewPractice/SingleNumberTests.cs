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
    public class SingleNumberTests
    {
        [TestMethod()]
        public void singleNumberTest()
        {
            var s = new SingleNumber();
            Assert.AreEqual(1, s.singleNumber(new[] { 2, 2, 1 }));
            Assert.AreEqual(1, s.singleNumber(new[] { 1 }));
            Assert.AreEqual(-1, s.singleNumber(new[] { -1 }));
            Assert.AreEqual(-2, s.singleNumber(new[] { -1, -1, -2 }));
            Assert.AreEqual(0, s.singleNumber(new[] { 1, 0, 1 }));
            Assert.AreEqual(-1, s.singleNumber(new[] { 1, 3, 1, -1, 3 }));
            Assert.AreEqual(123456789, s.singleNumber(new[] { 123456789, 836133896, 65475264, 836133896, 746254373, 1000000000, 542627588, 1000000000, 444088605, 65475264, 746254373, 542627588, 444088605 }));
        }
    }
}