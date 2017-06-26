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
    public class HasPalindromicAnagramTests
    {
        [TestMethod]
        public void hasPalindromicAnagramTest()
        {
            var h = new HasPalindromicAnagram();
            Assert.IsTrue(h.hasPalindromicAnagram("abab"));
            Assert.IsTrue(h.hasPalindromicAnagram("heh!"));
            Assert.IsTrue(h.hasPalindromicAnagram("aA"));
            Assert.IsTrue(h.hasPalindromicAnagram("Hey! Yehoo! 111"));
            Assert.IsTrue(h.hasPalindromicAnagram("a0099A"));
            Assert.IsTrue(h.hasPalindromicAnagram("988"));
            Assert.IsTrue(h.hasPalindromicAnagram("!a!"));
            Assert.IsTrue(h.hasPalindromicAnagram("abba"));
            Assert.IsTrue(h.hasPalindromicAnagram("baaab"));
            Assert.IsFalse(h.hasPalindromicAnagram("bob"));
            Assert.IsFalse(h.hasPalindromicAnagram("aaa"));
            Assert.IsFalse(h.hasPalindromicAnagram("aabc"));
            Assert.IsFalse(h.hasPalindromicAnagram("z"));
            Assert.IsFalse(h.hasPalindromicAnagram("0Aa1"));
            Assert.IsFalse(h.hasPalindromicAnagram("898"));
            Assert.IsFalse(h.hasPalindromicAnagram("aaaa"));
        }
    }
}