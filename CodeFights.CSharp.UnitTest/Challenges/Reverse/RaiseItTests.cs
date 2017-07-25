using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class RaiseItTests
    {
        [TestMethod()]
        public void raiseItTest()
        {
            var r = new RaiseIt();
            Assert.AreEqual(32, r.raiseIt(new[] { 11, 22, 33 }));
            Assert.AreEqual(8, r.raiseIt(new[] { 14, 22, 31 }));
            Assert.AreEqual(16, r.raiseIt(new[] { 42 }));
            Assert.AreEqual(5, r.raiseIt(new[] { 90, 70, 50, 30, 10 }));
            Assert.AreEqual(1, r.raiseIt(new[] { 13 }));
            Assert.AreEqual(1023, r.raiseIt(new[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 }));
            Assert.AreEqual(380083, r.raiseIt(new[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }));
        }
    }
}