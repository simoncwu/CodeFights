using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass]
    public class Alpha3Tests
    {
        [TestMethod]
        public void Alpha3()
        {
            var a = new Alpha3();
            Assert.AreEqual("123", a.alpha3("abc"));
            Assert.AreEqual("124", a.alpha3("abd"));
            Assert.AreEqual("432", a.alpha3("bcd"));
            Assert.AreEqual("345", a.alpha3("cde"));
            Assert.AreEqual("98", a.alpha3("hij"));
            Assert.AreEqual("866", a.alpha3("zfr"));
            Assert.AreEqual("0", a.alpha3("jtj"));
            Assert.AreEqual("7777498096857450", a.alpha3("Longer string!!!"));
        }
    }
}