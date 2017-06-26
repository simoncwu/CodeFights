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
    public class WorthyDiceSetTests
    {
        [TestMethod()]
        public void worthyDiceSetTest()
        {
            var w = new WorthyDiceSet();
            Assert.AreEqual(4, w.worthyDiceSet(2, 5));
            Assert.AreEqual(9, w.worthyDiceSet(2, 2));
            Assert.AreEqual(6, w.worthyDiceSet(1, 2));
            Assert.AreEqual(6, w.worthyDiceSet(1, 4));
            Assert.AreEqual(135, w.worthyDiceSet(3, 2));
            Assert.AreEqual(5, w.worthyDiceSet(2, 4));
            Assert.AreEqual(1, w.worthyDiceSet(2, 36));
            Assert.AreEqual(8, w.worthyDiceSet(2, 3));
            Assert.AreEqual(2, w.worthyDiceSet(2, 6));
            Assert.AreEqual(5, w.worthyDiceSet(2, 7));
            Assert.AreEqual(3, w.worthyDiceSet(2, 8));
            Assert.AreEqual(3, w.worthyDiceSet(2, 9));
            Assert.AreEqual(1, w.worthyDiceSet(2, 10));
            Assert.AreEqual(3377, w.worthyDiceSet(6, 17));
            Assert.AreEqual(43, w.worthyDiceSet(3, 5));
            Assert.AreEqual(12, w.worthyDiceSet(3, 36));
            Assert.AreEqual(12, w.worthyDiceSet(4, 211));
        }
    }
}