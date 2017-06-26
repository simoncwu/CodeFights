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
    public class UsefulNumbersTests
    {
        [TestMethod()]
        public void usefulNumbersTest()
        {
            var u = new UsefulNumbers();
            Assert.AreEqual(1, u.usefulNumbers(1));
            Assert.AreEqual(4, u.usefulNumbers(10));
            Assert.AreEqual(8, u.usefulNumbers(20));
            Assert.AreEqual(16, u.usefulNumbers(36));
            Assert.AreEqual(4, u.usefulNumbers(45));
            Assert.AreEqual(16, u.usefulNumbers(69));
            Assert.AreEqual(4, u.usefulNumbers(79));
            Assert.AreEqual(8, u.usefulNumbers(99));
            Assert.AreEqual(16, u.usefulNumbers(100));
            Assert.AreEqual(8, u.usefulNumbers(1001));
        }
    }
}