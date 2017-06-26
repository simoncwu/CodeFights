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
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void reverseIntegerTest()
        {
            var r = new ReverseInteger();
            Assert.AreEqual(54321, r.reverseInteger(12345));
            Assert.AreEqual(-3424, r.reverseInteger(-4243));
            Assert.AreEqual(1, r.reverseInteger(1));
            Assert.AreEqual(1, r.reverseInteger(10));
            Assert.AreEqual(-1, r.reverseInteger(-100));
            Assert.AreEqual(9, r.reverseInteger(900000));
            Assert.AreEqual(-109, r.reverseInteger(-901000));
            Assert.AreEqual(21, r.reverseInteger(120));
            Assert.AreEqual(-201, r.reverseInteger(-102));
            Assert.AreEqual(2918, r.reverseInteger(8192));
            Assert.AreEqual(-33716, r.reverseInteger(-61733));
            Assert.AreEqual(-49743, r.reverseInteger(-34794));
            Assert.AreEqual(-72898, r.reverseInteger(-89827));
            Assert.AreEqual(-5638, r.reverseInteger(-83650));
            Assert.AreEqual(-11517, r.reverseInteger(-71511));
            Assert.AreEqual(24802, r.reverseInteger(20842));
            Assert.AreEqual(98834, r.reverseInteger(43889));
            Assert.AreEqual(321, r.reverseInteger(123));
        }
    }
}