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
    public class OrezRoEnoTests
    {
        [TestMethod()]
        public void orezRoEnoTest()
        {
            var o = new OrezRoEno();
            Assert.AreEqual(1, o.orezRoEno(1));
            Assert.AreEqual(1, o.orezRoEno(2));
            Assert.AreEqual(5, o.orezRoEno(23));
            Assert.AreEqual(3, o.orezRoEno(5));
            Assert.AreEqual(2, o.orezRoEno(9));
            Assert.AreEqual(7, o.orezRoEno(749));
            Assert.AreEqual(31, o.orezRoEno(2147483647));
            Assert.AreEqual(31, o.orezRoEno(1082130431));
            Assert.AreEqual(15, o.orezRoEno(4226847));
            Assert.AreEqual(24, o.orezRoEno(16718939));
        }
    }
}