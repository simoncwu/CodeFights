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
    public class IScreamTests
    {
        [TestMethod()]
        public void iScreamTest()
        {
            var i = new IScream();
            Assert.AreEqual(35, i.iScream(5, 3));
            Assert.AreEqual(10, i.iScream(3, 3));
            Assert.AreEqual(1, i.iScream(1, 1));
            Assert.AreEqual(210, i.iScream(5, 6));
            Assert.AreEqual(1, i.iScream(1, 2));
            Assert.AreEqual(11, i.iScream(2, 10));
            Assert.AreEqual(7, i.iScream(7, 1));
            Assert.AreEqual(120, i.iScream(4, 7));
            Assert.AreEqual(220, i.iScream(4, 9));
            Assert.AreEqual(1, i.iScream(4, 0));
            Assert.AreEqual(77558760, i.iScream(15, 15));
        }
    }
}