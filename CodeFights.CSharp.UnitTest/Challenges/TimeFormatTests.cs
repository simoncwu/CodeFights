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
    public class TimeFormatTests
    {
        [TestMethod()]
        public void timeFormatTest()
        {
            var t = new TimeFormat();
            Assert.AreEqual("1s 1ms", t.timeFormat(1001, "%s %ms"));
            Assert.AreEqual("1 1", t.timeFormat(1001, "s ms"));
            Assert.AreEqual("1 1ms", t.timeFormat(1001, "s %ms"));
            Assert.AreEqual("0y 0d 0h 0m 0s 0ms", t.timeFormat(0, ""));
            Assert.AreEqual("1y 1d 1h 1m 1s 1ms", t.timeFormat(31626061001, ""));
            Assert.AreEqual("1y 1d 1h 1m 1s 1ms", t.timeFormat(31626061001, "%y %d %h %m %s %ms"));
            Assert.AreEqual("366d 1h 1m 1s 1ms", t.timeFormat(31626061001, "%d %h %m %s %ms"));
            Assert.AreEqual("8785h 1m 1s 1ms", t.timeFormat(31626061001, "%h %m %s %ms"));
            Assert.AreEqual("527101m 1s 1ms", t.timeFormat(31626061001, "%m %s %ms"));
            Assert.AreEqual("31626061s 1ms", t.timeFormat(31626061001, "%s %ms"));
            Assert.AreEqual("31626061001ms", t.timeFormat(31626061001, "%ms"));
            Assert.AreEqual("1y 25h 1m 1s 1ms", t.timeFormat(31626061001, "%y %h %m %s %ms"));
            Assert.AreEqual("1y 1d 61m 1s 1ms", t.timeFormat(31626061001, "%y %d %m %s %ms"));
            Assert.AreEqual("1y 1d 1h 61s 1ms", t.timeFormat(31626061001, "%y %d %h %s %ms"));
            Assert.AreEqual("1y 1d 1h 1m 1001ms", t.timeFormat(31626061001, "%y %d %h %m %ms"));
        }
    }
}