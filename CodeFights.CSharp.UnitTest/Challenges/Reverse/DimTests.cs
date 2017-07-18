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
    public class DimTests
    {
        [TestMethod()]
        public void dimTest()
        {
            var d = new Dim();
            Assert.AreEqual(1, d.dim(1));
            Assert.AreEqual(7, d.dim(100));
            Assert.AreEqual(16, d.dim(65535));
            Assert.AreEqual(32, d.dim(4294967295));
            Assert.AreEqual(48, d.dim(281474976710655));
            Assert.AreEqual(1, d.dim(0));
            Assert.AreEqual(50, d.dim(1000000000000000));
            Assert.AreEqual(33, d.dim(6774366024));
        }
    }
}