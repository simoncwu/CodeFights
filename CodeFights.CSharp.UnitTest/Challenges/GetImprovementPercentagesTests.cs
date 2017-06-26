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
    public class GetImprovementPercentagesTests
    {
        [TestMethod]
        public void getImprovementPercentagesTest()
        {
            var g = new GetImprovementPercentages();
            Assert.AreEqual("29%", g.getImprovementPercentages("month1: 60.5 month2: 60.24 month3: 60.25 month4: -10.542 month5: -1 month6: 120 month7: 120"));
            Assert.AreEqual("invalid", g.getImprovementPercentages("M1 M2 M3 M4 M5"));
            Assert.AreEqual("33%", g.getImprovementPercentages("3monthSummary : month1: 60.5 month2: 60.24 month3: 60.25"));
            Assert.AreEqual("90%", g.getImprovementPercentages("0|1|2|3|4|5|6|7|8|9"));
            Assert.AreEqual("40%", g.getImprovementPercentages("M : -25.2  M : -10.333  M: -1.4   M : 0  M : 15"));
            Assert.AreEqual("17%", g.getImprovementPercentages("m1=5 m2=5 m3=5 m4=5 m5=5 m6=6"));
            Assert.AreEqual("invalid", g.getImprovementPercentages(" "));
            Assert.AreEqual("40%", g.getImprovementPercentages("150.45:120.45:130:-10.45::90.455"));
            Assert.AreEqual("invalid", g.getImprovementPercentages("120"));
        }
    }
}