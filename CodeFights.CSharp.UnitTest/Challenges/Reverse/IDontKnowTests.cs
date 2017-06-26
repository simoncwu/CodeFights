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
    public class IDontKnowTests
    {
        [TestMethod()]
        public void iDontKnowTest()
        {
            var i = new IDontKnow();
            Assert.AreEqual("2", i.iDontKnow(2));
            Assert.AreEqual("9900", i.iDontKnow(100));
            Assert.AreEqual("46440", i.iDontKnow(216));
            Assert.AreEqual("20306", i.iDontKnow(143));
            Assert.AreEqual("9999700002", i.iDontKnow(99999));
            Assert.AreEqual("152386680", i.iDontKnow(12345));
            Assert.AreEqual("999999997000000000", i.iDontKnow(999999999));
        }
    }
}