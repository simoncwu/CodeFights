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
    public class CardsTests
    {
        [TestMethod()]
        public void cardsTest()
        {
            var c = new Cards();
            Assert.AreEqual("2C", c.cards(0));
            Assert.AreEqual("0H", c.cards(34));
            Assert.AreEqual("9H", c.cards(33));
            Assert.AreEqual("AS", c.cards(51));
            Assert.AreEqual("QD", c.cards(23));
            Assert.AreEqual("6D", c.cards(17));
            Assert.AreEqual("JC", c.cards(9));
            Assert.AreEqual("3H", c.cards(27));
            Assert.AreEqual("JS", c.cards(48));
            Assert.AreEqual("7S", c.cards(44));
        }
    }
}