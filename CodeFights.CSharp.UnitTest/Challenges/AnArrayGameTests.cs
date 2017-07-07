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
    public class AnArrayGameTests
    {
        [TestMethod()]
        public void anArrayGameTest()
        {
            var a = new AnArrayGame();
            Assert.AreEqual("Aydeen: 1", a.anArrayGame(new[] { -1, -2, -3, -4, -5 }));
            Assert.AreEqual("Yara: 1", a.anArrayGame(new[] { -5, -4, -3, -2, -1 }));
            Assert.AreEqual("Draw", a.anArrayGame(new[] { -5, -5 }));
            Assert.AreEqual("Aydeen: 3", a.anArrayGame(new[] { 1, 2, 3 }));
            Assert.AreEqual("Aydeen: 1000", a.anArrayGame(new[] { -10, -124, -230, -1, -100, 67, -1000, -1000, 1000 }));
            Assert.AreEqual("Aydeen: 96", a.anArrayGame(new[] { 1, 2, 3, 100, 5, 6, 7, 96 }));
            Assert.AreEqual("Aydeen: 296", a.anArrayGame(new[] { 10, 210, 30, -48, 53, -1, -2, 23, -411, 531, -1011, 221, 31, -48, -5, -1, -203, 321, -400, 50, 10, 20, -30, -23, -5 }));
            Assert.AreEqual("Aydeen: 909998767", a.anArrayGame(new[] { 1000000000, 100000000, -10000000, -10000, 10000000, 42, 1233 }));
            Assert.AreEqual("Aydeen: 1291", a.anArrayGame(new[] { 1414, 1414, 2414, 1411, -14, -14, -12, 424, -122, 12, 124, -12 }));
            Assert.AreEqual("Aydeen: 100000006", a.anArrayGame(new[] { 100, 200, 200, -1000, 5, 6, -100000000 }));
            Assert.AreEqual("Aydeen: 999999000", a.anArrayGame(new[] { 3000, 4000, 50000, 1000, 1000, -1000, -1000000000 }));
        }
    }
}