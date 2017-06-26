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
    public class Alpha2Tests
    {
        [TestMethod()]
        public void alpha2Test()
        {
            var a = new Alpha2();
            Assert.AreEqual(0, a.alpha2("a"));
            Assert.AreEqual(1, a.alpha2("b"));
            Assert.AreEqual(2, a.alpha2("abc"));
            Assert.AreEqual(2, a.alpha2("bc"));
            Assert.AreEqual(6, a.alpha2("qwerty"));
            Assert.AreEqual(166, a.alpha2("codefights"));
            Assert.AreEqual(2, a.alpha2("google"));
            Assert.AreEqual(0, a.alpha2(""));
        }
    }
}