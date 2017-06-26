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
    public class IsSuperPalindromeTests
    {
        [TestMethod()]
        public void isSuperPalindromeTest()
        {
            var i = new IsSuperPalindrome();
            Assert.IsTrue(i.isSuperPalindrome("10011001", 2));
            Assert.IsTrue(i.isSuperPalindrome("www", 1));
            Assert.IsFalse(i.isSuperPalindrome("654neveroddoreven456", 5));
            Assert.IsTrue(i.isSuperPalindrome("25iwwi52", 4));
            Assert.IsFalse(i.isSuperPalindrome("25iwiw52", 4));
            Assert.IsTrue(i.isSuperPalindrome("wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww", 2));
            Assert.IsFalse(i.isSuperPalindrome("qz99qzzq99qzzq99qzzq99qz", 3));
            Assert.IsTrue(i.isSuperPalindrome("3zdd1zbbz1ddz33zdd1zbbz1ddz3", 7));
            Assert.IsFalse(i.isSuperPalindrome("0fbfb00bffb0", 3));
            Assert.IsTrue(i.isSuperPalindrome("ttgt2pmmp2tgttttgt2pmmp2tgtt", 7));
        }
    }
}