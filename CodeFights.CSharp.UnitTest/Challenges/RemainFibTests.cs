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
    public class RemainFibTests
    {
        [TestMethod]
        public void remainFibTest()
        {
            var r = new RemainFib();
            Assert.AreEqual("4", r.remainFib("1"));
            Assert.AreEqual("6", r.remainFib("2"));
            Assert.AreEqual("58", r.remainFib("49"));
            Assert.AreEqual("78", r.remainFib("69"));
            Assert.AreEqual("48", r.remainFib("40"));
            Assert.AreEqual("1995", r.remainFib("1979"));
            Assert.AreEqual("2032", r.remainFib("2016"));
            Assert.AreEqual("65", r.remainFib("56"));
            Assert.AreEqual("7", r.remainFib("3"));
        }
    }
}