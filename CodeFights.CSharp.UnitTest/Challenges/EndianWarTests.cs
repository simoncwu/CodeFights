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
    public class EndianWarTests
    {
        [TestMethod()]
        public void endianWarTest()
        {
            var e = new EndianWar();
            Assert.IsTrue(e.endianWar("73+42=16"));
            Assert.IsFalse(e.endianWar("5+8=13"));
            Assert.IsTrue(e.endianWar("10+20=30"));
            Assert.IsTrue(e.endianWar("11+44=55"));
            Assert.IsTrue(e.endianWar("2466+7=9466"));
            Assert.IsFalse(e.endianWar("649+68072=68721"));
            Assert.IsTrue(e.endianWar("2+19=39"));
            Assert.IsTrue(e.endianWar("4+3=7"));
            Assert.IsTrue(e.endianWar("714+8=524"));
            Assert.IsFalse(e.endianWar("65+72825=72890"));
            Assert.IsTrue(e.endianWar("47+17=541"));
            Assert.IsFalse(e.endianWar("8861+81209=90070"));
            Assert.IsTrue(e.endianWar("99+54962=44072"));
            Assert.IsFalse(e.endianWar("930+70374=71304"));
            Assert.IsTrue(e.endianWar("78+04258=72358"));
            Assert.IsFalse(e.endianWar("17+27=34"));
            Assert.IsTrue(e.endianWar("17+27=341"));
        }
    }
}