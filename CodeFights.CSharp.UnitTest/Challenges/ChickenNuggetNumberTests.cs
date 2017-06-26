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
    public class ChickenNuggetNumberTests
    {
        [TestMethod()]
        public void chickenNuggetNumberTest()
        {
            var c = new ChickenNuggetNumber();
            Assert.AreEqual(11, c.chickenNuggetNumber(new[] { 4, 6, 9 }));
            Assert.AreEqual(43, c.chickenNuggetNumber(new[] { 6, 9, 20 }));
            Assert.AreEqual(1, c.chickenNuggetNumber(new[] { 2, 3, 4 }));
            Assert.AreEqual(2, c.chickenNuggetNumber(new[] { 3, 4, 5 }));
            Assert.AreEqual(9, c.chickenNuggetNumber(new[] { 5, 6, 7 }));
            Assert.AreEqual(38, c.chickenNuggetNumber(new[] { 7, 11, 15 }));
            Assert.AreEqual(496505, c.chickenNuggetNumber(new[] { 997, 998, 999 }));
        }
    }
}