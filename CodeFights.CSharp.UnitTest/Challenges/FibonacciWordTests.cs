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
    public class FibonacciWordTests
    {
        [TestMethod()]
        public void fibonacciWordTest()
        {
            var f = new FibonacciWord();
            Assert.AreEqual(5, f.fibonacciWord(6, "10"));
            Assert.AreEqual(0, f.fibonacciWord(1, "0"));
            Assert.AreEqual(8, f.fibonacciWord(7, "10"));
            Assert.AreEqual(4, f.fibonacciWord(6, "01"));
            Assert.AreEqual(4, f.fibonacciWord(6, "101"));
            Assert.AreEqual(12, f.fibonacciWord(10, "110101101"));
            Assert.AreEqual(4181, f.fibonacciWord(20, "10"));
            Assert.AreEqual(63245986, f.fibonacciWord(40, "0"));
            Assert.AreEqual(0, f.fibonacciWord(40, "00"));
        }
    }
}