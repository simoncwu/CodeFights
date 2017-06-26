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
    public class AngleTests
    {
        [TestMethod()]
        public void angleTest()
        {
            var a = new Angle();
            Assert.AreEqual(1, a.angle(1));
            Assert.AreEqual(1, a.angle(2));
            Assert.AreEqual(6, a.angle(4));
            Assert.AreEqual(7, a.angle(49));
            Assert.AreEqual(3, a.angle(15));
            Assert.AreEqual(14, a.angle(19548012));
            Assert.AreEqual(11, a.angle(123124));
            Assert.AreEqual(14, a.angle(13124156));
            Assert.AreEqual(0, a.angle(0));
            Assert.AreEqual(1, a.angle(6));
            Assert.AreEqual(2, a.angle(8));
            Assert.AreEqual(1, a.angle(9));
            Assert.AreEqual(3, a.angle(111));
            Assert.AreEqual(4, a.angle(1111));
            Assert.AreEqual(4, a.angle(6767));
            Assert.AreEqual(4, a.angle(6776));
        }
    }
}