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
    public class GoldTests
    {
        [TestMethod()]
        public void goldTest()
        {
            var g = new Gold();
            Assert.AreEqual(1, g.gold(8));
            Assert.AreEqual(2, g.gold(20));
            Assert.AreEqual(6, g.gold(100));
            Assert.AreEqual(0, g.gold(101));
            Assert.AreEqual(4, g.gold(42));
            Assert.AreEqual(1, g.gold(655));
            Assert.AreEqual(385, g.gold(56344));
            Assert.AreEqual(0, g.gold(2));
        }
    }
}