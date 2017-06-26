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
    public class ClockRadianTests
    {
        [TestMethod()]
        public void clockRadianTest()
        {
            var c = new ClockRadian();
            Assert.AreEqual("pi/2", c.clockRadian("3:00"));
            Assert.AreEqual("pi", c.clockRadian("6:00"));
            Assert.AreEqual("5pi/18", c.clockRadian("2:20"));
            Assert.AreEqual("11pi/360", c.clockRadian("11:59"));
            Assert.AreEqual("37pi/45", c.clockRadian("10:16"));
            Assert.AreEqual("0", c.clockRadian("12:00"));
        }
    }
}