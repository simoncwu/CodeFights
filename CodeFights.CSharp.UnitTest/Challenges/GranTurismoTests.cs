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
    public class GranTurismoTests
    {
        [TestMethod]
        public void granTurismoTest()
        {
            var g = new GranTurismo();
            Assert.AreEqual("00:10.000", g.granTurismo(10, 100, 100, 240));
            Assert.AreEqual("00:08.500", g.granTurismo(5.6, 160, 92, 400));
            Assert.AreEqual("00:21.000", g.granTurismo(5.3, 180, 62, 1000));
            Assert.AreEqual("00:04.500", g.granTurismo(2.8, 360, 40, 200));
            Assert.AreEqual("00:03.000", g.granTurismo(2, 360, 55, 200));
            Assert.AreEqual("00:08.500", g.granTurismo(5, 140, 112, 420));
            Assert.AreEqual("00:18.000", g.granTurismo(12, 360, 100, 600));
            Assert.AreEqual("01:00.000", g.granTurismo(8.8, 121, 103, 1986));
        }
    }
}