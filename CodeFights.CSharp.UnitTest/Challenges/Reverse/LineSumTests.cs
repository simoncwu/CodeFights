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
    public class LineSumTests
    {
        [TestMethod()]
        public void lineSumTest()
        {
            var l = new LineSum();
            Assert.AreEqual(7, l.lineSum(8));
            Assert.AreEqual(6, l.lineSum(0));
            Assert.AreEqual(2, l.lineSum(1));
            Assert.AreEqual(15, l.lineSum(1344));
            Assert.AreEqual(19, l.lineSum(2001));
            Assert.AreEqual(22, l.lineSum(2002));
            Assert.AreEqual(16, l.lineSum(2017));
            Assert.AreEqual(92, l.lineSum(1000000000000000));
        }
    }
}