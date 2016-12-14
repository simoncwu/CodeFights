using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class MajorIndexTests
    {
        [TestMethod]
        public void majorIndexTest()
        {
            var m = new MajorIndex();
            Assert.AreEqual(0, m.majorIndex("0"));
            Assert.AreEqual(7, m.majorIndex("83"));
            Assert.AreEqual(3, m.majorIndex("100"));
            Assert.AreEqual(9, m.majorIndex("85"));
            Assert.AreEqual(32, m.majorIndex("1000000"));
            Assert.AreEqual(8, m.majorIndex("1979"));
            Assert.AreEqual(1, m.majorIndex("5"));
            Assert.AreEqual(0, m.majorIndex("2016"));
        }
    }
}