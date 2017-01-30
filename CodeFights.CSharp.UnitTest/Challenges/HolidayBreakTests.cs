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
    public class HolidayBreakTests
    {
        [TestMethod]
        public void holidayBreakTest()
        {
            var h = new HolidayBreak();
            Assert.AreEqual(11, h.holidayBreak(2016));
            Assert.AreEqual(10, h.holidayBreak(2017));
            Assert.AreEqual(11, h.holidayBreak(2018));
            Assert.AreEqual(16, h.holidayBreak(2019));
            Assert.AreEqual(16, h.holidayBreak(2020));
            Assert.AreEqual(11, h.holidayBreak(2021));
            Assert.AreEqual(11, h.holidayBreak(2022));
            Assert.AreEqual(10, h.holidayBreak(2023));
            Assert.AreEqual(16, h.holidayBreak(2024));
            Assert.AreEqual(16, h.holidayBreak(2025));
            Assert.AreEqual(16, h.holidayBreak(2026));
            Assert.AreEqual(11, h.holidayBreak(2027));
            Assert.AreEqual(10, h.holidayBreak(2028));
            Assert.AreEqual(11, h.holidayBreak(2029));
            Assert.AreEqual(16, h.holidayBreak(2030));
            Assert.AreEqual(16, h.holidayBreak(2031));
            Assert.AreEqual(11, h.holidayBreak(2032));
            Assert.AreEqual(11, h.holidayBreak(2033));
            Assert.AreEqual(10, h.holidayBreak(2034));
            Assert.AreEqual(11, h.holidayBreak(2035));
        }
    }
}