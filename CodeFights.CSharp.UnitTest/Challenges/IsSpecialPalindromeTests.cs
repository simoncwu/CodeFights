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
    public class IsSpecialPalindromeTests
    {
        [TestMethod()]
        public void isSpecialPalindromeTest()
        {
            var i = new IsSpecialPalindrome();
            Assert.IsTrue(i.isSpecialPalindrome(5));
            Assert.IsFalse(i.isSpecialPalindrome(0));
            Assert.IsFalse(i.isSpecialPalindrome(7));
            Assert.IsTrue(i.isSpecialPalindrome(536854527));
            Assert.IsFalse(i.isSpecialPalindrome(9));
            Assert.IsFalse(i.isSpecialPalindrome(15));
            Assert.IsFalse(i.isSpecialPalindrome(21));
            Assert.IsTrue(i.isSpecialPalindrome(27));
            Assert.IsFalse(i.isSpecialPalindrome(31));
            Assert.IsFalse(i.isSpecialPalindrome(85));
            Assert.IsTrue(i.isSpecialPalindrome(119));
            Assert.IsTrue(i.isSpecialPalindrome(495));
            Assert.IsTrue(i.isSpecialPalindrome(523775));
            Assert.IsTrue(i.isSpecialPalindrome(2096127));
            Assert.IsFalse(i.isSpecialPalindrome(23));
            Assert.IsFalse(i.isSpecialPalindrome(71));
            Assert.IsFalse(i.isSpecialPalindrome(51));
            Assert.IsFalse(i.isSpecialPalindrome(103));
            Assert.IsFalse(i.isSpecialPalindrome(87));
        }
    }
}