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
    public class PolygonPlotOfLandTests
    {
        [TestMethod]
        public void polygonPlotOfLandTest()
        {
            var p = new PolygonPlotOfLand();
            Assert.AreEqual("95.00", p.polygonPlotOfLand(4, 5, new[] { 3, 1 }));
            Assert.AreEqual("6837.69", p.polygonPlotOfLand(6, 10, new[] { 12, 62 }));
            Assert.AreEqual("2684813.41", p.polygonPlotOfLand(20, 33, new[] { 78, 5 }));
            Assert.AreEqual("1580.17", p.polygonPlotOfLand(7, 10, new[] { 3, 7 }));
            Assert.AreEqual("3395500.05", p.polygonPlotOfLand(14, 62, new[] { 57, 41 }));
            Assert.AreEqual("767913.02", p.polygonPlotOfLand(12, 47, new[] { 30, 46 }));
            Assert.AreEqual("54183.83", p.polygonPlotOfLand(14, 6, new[] { 91, 47 }));
            Assert.AreEqual("283531.04", p.polygonPlotOfLand(19, 15, new[] { 42, 51 }));
        }
    }
}