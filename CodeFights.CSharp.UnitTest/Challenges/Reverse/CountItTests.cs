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
    public class CountItTests
    {
        [TestMethod]
        public void countItTest()
        {
            var c = new CountIt();
            Assert.AreEqual(6, c.countIt(8809));
            Assert.AreEqual(0, c.countIt(7111));
            Assert.AreEqual(0, c.countIt(1234));
            Assert.AreEqual(4, c.countIt(6666));
            Assert.AreEqual(0, c.countIt(1111));
            Assert.AreEqual(5, c.countIt(8096));
            Assert.AreEqual(4, c.countIt(90485));
        }
    }
}