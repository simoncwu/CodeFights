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
    [TestClass]
    public class NorthPoleTrafficClockTests
    {
        [TestMethod]
        public void northPoleTrafficClockTest()
        {
            var n = new NorthPoleTrafficClock();
            var countdown = new[] { "****_|", "*****|", "****_|", "***|_*", "*****|", "***|_|" };
            var expected = "[5]";
            Assert.AreEqual(expected, Util.ArrayToString(n.northPoleTrafficClock(countdown)));

            countdown = new[] { "**|**|", "**||_|", "**|**|" };
            expected = "[99,79,49,19]";
            Assert.AreEqual(expected, Util.ArrayToString(n.northPoleTrafficClock(countdown)));

            countdown = new[] { "|_|*_|", "|_|**|", "|_|*_|", "|_||_*", "|_|**|", "|_||_|", "**|**|" };
            expected = "[85]";
            Assert.AreEqual(expected, Util.ArrayToString(n.northPoleTrafficClock(countdown)));

            countdown = new[] {
                "**|**|",
                "**|*_|",
                "**||_*",
                "**|**|",
                "**||_|",
                "*_|**|",
                "*_||_|",
                "*_|**|",
                "*_||_|",
                "*_|*_|",
                "*_|**|",
                "*_|*_|",
                "*_||_*",
                "*_|**|",
                "*_||_|",
                "|_***|",
                "|_*|_|",
                "|_***|",
                "|_*|_|",
                "|_**_|",
                "|_***|",
                "|_**_|" };
            expected = "[44]";
            Assert.AreEqual(expected, Util.ArrayToString(n.northPoleTrafficClock(countdown)));

            countdown = new[] { "**||_*", "**|**|" };
            expected = "[92,72,42,12]";
            Assert.AreEqual(expected, Util.ArrayToString(n.northPoleTrafficClock(countdown)));
        }
    }
}