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
    public class LucasTests
    {
        [TestMethod()]
        public void lucasTest()
        {
            var l = new Lucas();
            long[] expected = { 0, 2 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(0, 0, 0)));

            expected = new long[] { 1, 1 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(1, 1, 1)));

            expected = new long[] { 2, 0 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(2, 2, 2)));

            expected = new long[] { -1, -5 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(1, 2, 3)));

            expected = new long[] { 333068881, 3708898092 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(12, 5, 9)));

            expected = new long[] { 32, 32 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(4, 4, 4)));

            expected = new long[] { 81, 243 };
            Assert.IsTrue(expected.SequenceEqual(l.lucas(3, 0, 5)));
        }
    }
}