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
    public class Base32Tests
    {
        [TestMethod()]
        public void base32Test()
        {
            var b = new Base32();
            Assert.AreEqual("2", b.base32(0));
            Assert.AreEqual("3", b.base32(1));
            Assert.AreEqual("A", b.base32(8));
            Assert.AreEqual("BB", b.base32(297));
            Assert.AreEqual("ZA", b.base32(1000));
            Assert.AreEqual("322", b.base32(1024));
            Assert.AreEqual("BSJ", b.base32(10000));
            Assert.AreEqual("5SL2", b.base32(123456));
            Assert.AreEqual("BK7MZ", b.base32(9999999));
            Assert.AreEqual("RSAS", b.base32(778520));
            Assert.AreEqual("PUNCH", b.base32(22892879));
        }
    }
}