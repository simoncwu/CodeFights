using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class GetTemperatureInfoTests
    {
        [TestMethod]
        public void getTemperatureInfoTest()
        {
            var g = new GetTemperatureInfo();
            Assert.AreEqual("[12,3,6]", Util.ArrayToString(g.getTemperatureInfo(new[] { 12, -5, 9 })));
            Assert.AreEqual("[-50]", Util.ArrayToString(g.getTemperatureInfo(new[] { -50 })));
            Assert.AreEqual("[-55,-22,23]", Util.ArrayToString(g.getTemperatureInfo(new[] { -55, 12, 110 })));
            Assert.AreEqual("[-5,-5,-4,-4,-3,-3,-2,-2,-1,-1,0]", Util.ArrayToString(g.getTemperatureInfo(new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 })));
            Assert.AreEqual("[-50,-25,-3]", Util.ArrayToString(g.getTemperatureInfo(new[] { -50, 0, 41 })));
        }
    }
}