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
    public class LeftoverTests
    {
        [TestMethod()]
        public void leftoverTest()
        {
            var l = new Leftover();
            Assert.AreEqual(27, l.leftover("antidisestablishmentarianism"));
            Assert.AreEqual(5, l.leftover("supercalifragilisticexpialidocious"));
            Assert.AreEqual(4, l.leftover("appetite"));
            Assert.AreEqual(3, l.leftover("cavern"));
            Assert.AreEqual(2, l.leftover("hello"));
            Assert.AreEqual(1, l.leftover("watcher"));
            Assert.AreEqual(1, l.leftover("bc"));
            Assert.AreEqual(2, l.leftover("2017"));
            Assert.AreEqual(1, l.leftover("cb"));
        }
    }
}