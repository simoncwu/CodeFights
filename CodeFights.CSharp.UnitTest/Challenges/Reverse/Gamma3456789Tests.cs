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
    public class Gamma3456789Tests
    {
        [TestMethod()]
        public void gamma3456789Test()
        {
            var g = new Gamma3456789();
            Assert.AreEqual(1, g.gamma3456789(1));
            Assert.AreEqual(1, g.gamma3456789(2));
            Assert.AreEqual(2, g.gamma3456789(3));
            Assert.AreEqual(6, g.gamma3456789(4));
            Assert.AreEqual(24, g.gamma3456789(5));
            Assert.AreEqual(362880, g.gamma3456789(10));
            Assert.AreEqual(172011, g.gamma3456789(11));
            Assert.AreEqual(1892121, g.gamma3456789(12));
            Assert.AreEqual(1964718, g.gamma3456789(13));
            Assert.AreEqual(3169971, g.gamma3456789(50));
            Assert.AreEqual(1077573, g.gamma3456789(100));
            Assert.AreEqual(2935317, g.gamma3456789(500));
            Assert.AreEqual(1698858, g.gamma3456789(1000));
            Assert.AreEqual(1957557, g.gamma3456789(1234));
            Assert.AreEqual(0, g.gamma3456789(123456789));
        }
    }
}