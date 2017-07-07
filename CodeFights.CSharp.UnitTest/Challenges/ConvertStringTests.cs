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
    public class ConvertStringTests
    {
        [TestMethod()]
        public void convertStringTest()
        {
            var c = new ConvertString();
            Assert.IsTrue(c.convertString("ceoydefthf5iyg5h5yts", "codefights"));
            Assert.IsFalse(c.convertString("addbyca", "abcd"));
            Assert.IsTrue(c.convertString("abc", "abc"));
            Assert.IsFalse(c.convertString("a", "abc"));
            Assert.IsTrue(c.convertString("gooddaywithcoffee17righteh", "gowithcoffe1e"));
            Assert.IsTrue(c.convertString("aaaAaaaAbbBbcCcc", "aBc"));
            Assert.IsFalse(c.convertString("spjrtytmeed", "spotme"));
        }
    }
}