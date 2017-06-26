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
    public class Random1Tests
    {
        [TestMethod()]
        public void random1Test()
        {
            var r = new Random1();
            Assert.AreEqual(333139, r.random1(675248, 2));
            Assert.AreEqual(15, r.random1(34, 1));
            Assert.AreEqual(64, r.random1(9592, 1));
            Assert.AreEqual(575365, r.random1(881231, 23));
            Assert.AreEqual(6250000, r.random1(1934341, 1827));
            Assert.AreEqual(564496, r.random1(123891, 15));
            Assert.AreEqual(4100, r.random1(1093, 81));
            Assert.AreEqual(0, r.random1(10000000, 100000));
        }
    }
}