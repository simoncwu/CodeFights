using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class CalendarTests
    {
        [TestMethod()]
        public void calendarTest()
        {
            var c = new Calendar();
            var expected = "[[0,1,2,3,4,5,6],[7,8,9,10,11,12,13],[14,15,16,17,18,19,20],[21,22,23,24,25,26,27],[28,29,30,31,0,0,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(5, 2017)));

            expected = "[[0,0,0,0,1,2,3],[4,5,6,7,8,9,10],[11,12,13,14,15,16,17],[18,19,20,21,22,23,24],[25,26,27,28,29,30,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(6, 2017)));

            expected = "[[0,0,0,0,0,0,1],[2,3,4,5,6,7,8],[9,10,11,12,13,14,15],[16,17,18,19,20,21,22],[23,24,25,26,27,28,29],[30,31,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(7, 2017)));

            expected = "[[1,2,3,4,5,6,7],[8,9,10,11,12,13,14],[15,16,17,18,19,20,21],[22,23,24,25,26,27,28],[29,30,31,0,0,0,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(10, 2017)));

            expected = "[[0,0,0,1,2,3,4],[5,6,7,8,9,10,11],[12,13,14,15,16,17,18],[19,20,21,22,23,24,25],[26,27,28,0,0,0,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(2, 2017)));

            expected = "[[0,1,2,3,4,5,6],[7,8,9,10,11,12,13],[14,15,16,17,18,19,20],[21,22,23,24,25,26,27],[28,29,0,0,0,0,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(2, 2016)));

            expected = "[[0,0,0,0,0,0,1],[2,3,4,5,6,7,8],[9,10,11,12,13,14,15],[16,17,18,19,20,21,22],[23,24,25,26,27,28,29],[30,31,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(1, 2000)));

            expected = "[[0,0,1,2,3,4,5],[6,7,8,9,10,11,12],[13,14,15,16,17,18,19],[20,21,22,23,24,25,26],[27,28,29,30,31,0,0],[0,0,0,0,0,0,0]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.calendar(12, 2020)));
        }
    }
}