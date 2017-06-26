using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class PoweryTests
    {
        [TestMethod()]
        public void poweryTest()
        {
            var p = new Powery();
            Assert.AreEqual(402, p.powery(3000, 20));
            Assert.AreEqual(-2180, p.powery(3000, -3));
            Assert.AreEqual(1, p.powery(1, 2));
            Assert.AreEqual(3, p.powery(2, 2));
            Assert.AreEqual(28398245, p.powery(78955021, 73));
            Assert.AreEqual(-726, p.powery(2014, -9));
            Assert.AreEqual(-97333, p.powery(123456, -46));
            Assert.AreEqual(8651, p.powery(123456, 93));
            Assert.AreEqual(57289765, p.powery(100000000, 87));
            Assert.AreEqual(264, p.powery(256, 2));
            Assert.AreEqual(30, p.powery(27, 3));
            Assert.AreEqual(2059, p.powery(3000, 2));
            Assert.AreEqual(30, p.powery(29, 3));
            Assert.AreEqual(30, p.powery(80, 3));
            Assert.AreEqual(85, p.powery(81, 3));
        }
    }
}