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
    public class ImagineTests
    {
        [TestMethod()]
        public void imagineTest()
        {
            var i = new Imagine();
            Assert.IsTrue(new[] { 0, 2 }.SequenceEqual(i.imagine(1, 1, 1, 1)));
            Assert.IsTrue(new[] { 1, 0 }.SequenceEqual(i.imagine(1, 0, 1, 0)));
            Assert.IsTrue(new[] { -1, 1 }.SequenceEqual(i.imagine(0, 1, 1, 1)));
            Assert.IsTrue(new[] { -87, 3782 }.SequenceEqual(i.imagine(42, 43, 44, 45)));
            Assert.IsTrue(new[] { -5, 10 }.SequenceEqual(i.imagine(1, 2, 3, 4)));
            Assert.IsTrue(new[] { 5, -10 }.SequenceEqual(i.imagine(-1, -2, 3, 4)));
            Assert.IsTrue(new[] { -999, 1001 }.SequenceEqual(i.imagine(-1, -1, -1, -1000)));
            Assert.IsTrue(new[] { -1000, 100 }.SequenceEqual(i.imagine(10, 100, 0, 10)));
            Assert.IsTrue(new[] { 15, 0 }.SequenceEqual(i.imagine(5, 0, 3, 0)));
            Assert.IsTrue(new[] { -15, 0 }.SequenceEqual(i.imagine(0, 5, 0, 3)));
        }
    }
}