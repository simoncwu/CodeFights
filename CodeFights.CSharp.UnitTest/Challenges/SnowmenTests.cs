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
    public class SnowmenTests
    {
        [TestMethod]
        public void snowmenTest()
        {
            var s = new Snowmen();
            Assert.AreEqual(71.20943348136865, s.snowmen(new[] { 1, 1, 2, 2, 2, 3 }));
            Assert.AreEqual(71.20943348136865, s.snowmen(new[] { 2, 1, 2, 3, 1, 2 }));
            Assert.AreEqual(12.566370614359172, s.snowmen(new[] { 1, 1, 1 }));
            Assert.AreEqual(0, s.snowmen(new[] { 1, 1, 1, 2, 3, 4, 5, 6, 7 }));
            Assert.AreEqual(1813.7461586725074, s.snowmen(new[] { 1, 4, 6, 3, 6, 6 }));
            Assert.AreEqual(268.082573106329, s.snowmen(new[] { 5, 4, 4, 4, 5, 3, 3, 2, 4, 2 }));
            Assert.AreEqual(16.755160819145562, s.snowmen(new[] { 3, 1, 3, 1, 1, 1, 2, 1, 5, 2 }));
            Assert.AreEqual(12.566370614359172, s.snowmen(new[] { 1, 1, 1, 2, 3, 5 }));
            Assert.AreEqual(37.69911184307752, s.snowmen(new[] { 1, 15, 12, 17, 20, 20, 13, 2 }));
            Assert.AreEqual(343.480796792484, s.snowmen(new[] { 3, 3, 3, 2, 3, 4, 5, 3, 1, 5 }));
            Assert.AreEqual(113.09733552923255, s.snowmen(new[] { 7, 25, 20, 13, 3, 17, 21, 22, 23, 27 }));
        }
    }
}