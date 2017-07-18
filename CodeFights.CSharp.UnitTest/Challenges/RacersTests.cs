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
    public class RacersTests
    {
        [TestMethod()]
        public void racersTest()
        {
            var r = new Racers();
            var expected = new[] { 1, 0 };
            Assert.IsTrue(expected.SequenceEqual(r.racers(10, new[] { 2, 2 }, new[] { 2, 4 })));

            expected = new[] { 0, 1 };
            Assert.IsTrue(expected.SequenceEqual(r.racers(10, new[] { 2, 2 }, new[] { 2, 2 })));

            expected = new[] { 1, 0 };
            Assert.IsTrue(expected.SequenceEqual(r.racers(10, new[] { 2, 4 }, new[] { 2, 2 })));

            expected = new[] { 2, 1, 0 };
            Assert.IsTrue(expected.SequenceEqual(r.racers(1, new[] { 5, 10, 15 }, new[] { 20, 10, 5 })));

            expected = new[] { 3, 4, 5, 1, 0, 2 };
            Assert.IsTrue(expected.SequenceEqual(r.racers(27, new[] { 3, 2, 2, 18, 14, 9 }, new[] { 151, 236, 152, 15, 163, 275 })));
        }
    }
}