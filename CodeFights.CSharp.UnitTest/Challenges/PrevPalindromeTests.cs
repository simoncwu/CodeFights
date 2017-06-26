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
    public class PrevPalindromeTests
    {
        [TestMethod()]
        public void prevPalindromeTest()
        {
            var p = new PrevPalindrome();
            Assert.AreEqual(11, p.prevPalindrome(16));
            Assert.AreEqual(9, p.prevPalindrome(11));
            Assert.AreEqual(9, p.prevPalindrome(10));
            Assert.AreEqual(6, p.prevPalindrome(7));
            Assert.AreEqual(0, p.prevPalindrome(1));
            Assert.AreEqual(111, p.prevPalindrome(121));
            Assert.AreEqual(999999999, p.prevPalindrome(1000000000));
            Assert.AreEqual(477313774, p.prevPalindrome(477318120));
            Assert.AreEqual(477292774, p.prevPalindrome(477303773));
            Assert.AreEqual(9999, p.prevPalindrome(10001));
        }
    }
}