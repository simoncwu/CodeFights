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
    public class RemoveDigitsTests
    {
        [TestMethod()]
        public void removeDigitsTest()
        {
            var r = new RemoveDigits();
            Assert.IsTrue(new long[] { 15, 52 }.SequenceEqual(r.removeDigits(15243, 2)));
            Assert.IsTrue(new long[] { 1, 3 }.SequenceEqual(r.removeDigits(123, 1)));
            Assert.IsTrue(new long[] { 9, 9 }.SequenceEqual(r.removeDigits(99, 1)));
            Assert.IsTrue(new long[] { 0, 1 }.SequenceEqual(r.removeDigits(10, 1)));
            Assert.IsTrue(new long[] { 33, 33 }.SequenceEqual(r.removeDigits(3333, 2)));
            Assert.IsTrue(new long[] { 391, 9193 }.SequenceEqual(r.removeDigits(10391938, 4)));
            Assert.IsTrue(new long[] { 38, 103 }.SequenceEqual(r.removeDigits(1038, 3)));
        }
    }
}