using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class StringsRearrangementTests
    {
        [TestMethod]
        public void stringsRearrangementTest()
        {
            var s = new StringsRearrangement();
            var inputArray = new[] { "aba", "bbb", "bab" };
            Assert.IsFalse(s.stringsRearrangement(inputArray));

            inputArray = new[] { "ab", "bb", "aa" };
            Assert.IsTrue(s.stringsRearrangement(inputArray));

            inputArray = new[] { "q", "q" };
            Assert.IsFalse(s.stringsRearrangement(inputArray));

            inputArray = new[] { "zzzzab", "zzzzbb", "zzzzaa" };
            Assert.IsTrue(s.stringsRearrangement(inputArray));

            inputArray = new[] { "ab", "ad", "ef", "eg" };
            Assert.IsFalse(s.stringsRearrangement(inputArray));

            inputArray = new[] { "abc", "abx", "axx", "abc" };
            Assert.IsFalse(s.stringsRearrangement(inputArray));

            inputArray = new[] { "abc", "abx", "axx", "abx", "abc" };
            Assert.IsTrue(s.stringsRearrangement(inputArray));

            inputArray = new[] { "f", "g", "a", "h" };
            Assert.IsTrue(s.stringsRearrangement(inputArray));
        }
    }
}