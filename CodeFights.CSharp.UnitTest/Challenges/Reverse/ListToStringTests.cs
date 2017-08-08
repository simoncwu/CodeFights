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
    public class ListToStringTests
    {
        [TestMethod()]
        public void listToStringTest()
        {
            var l = new ListToString();
            Assert.AreEqual("24 1010 14", l.listToString(new[] { 20, 10, 20 }));
            Assert.AreEqual("1 10 3", l.listToString(new[] { 1, 2, 3 }));
            Assert.AreEqual("66 1000000 7c", l.listToString(new[] { 54, 64, 124 }));
            Assert.AreEqual("0 0 0", l.listToString(new[] { 0, 0, 0 }));
            Assert.AreEqual("12 1100100 3e8", l.listToString(new[] { 10, 100, 1000 }));
            Assert.AreEqual("764 101101000 f0", l.listToString(new[] { 500, 360, 240 }));
            Assert.AreEqual("13 1011-b", l.listToString(new[] { 11, 11, -11 }));
        }
    }
}