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
    public class TellTimeTests
    {
        [TestMethod()]
        public void tellTimeTest()
        {
            var t = new TellTime();
            Assert.AreEqual("It's twelve o'clock", t.tellTime("12:00"));
            Assert.AreEqual("It's twenty to nine", t.tellTime("08:42"));
            Assert.AreEqual("It's eleven o'clock", t.tellTime("11:02"));
            Assert.AreEqual("It's quarter to nine", t.tellTime("08:43"));
            Assert.AreEqual("It's half past nine", t.tellTime("09:28"));
            Assert.AreEqual("It's quarter to seven", t.tellTime("06:45"));
            Assert.AreEqual("It's twenty five past seven", t.tellTime("07:27"));
            Assert.AreEqual("It's quarter past twelve", t.tellTime("12:16"));
            Assert.AreEqual("It's five to one", t.tellTime("12:53"));
            Assert.AreEqual("It's quarter to one", t.tellTime("12:47"));
            Assert.AreEqual("It's twenty past one", t.tellTime("01:22"));
        }
    }
}