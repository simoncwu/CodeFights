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
    public class Equation2ChallengeTests
    {
        [TestMethod]
        public void Equation2Test()
        {
            var e = new Equation2Challenge();
            Assert.AreEqual("-3/4, 1/3, 2", e.Equation2("12x^3-19x^2-13x+6=0"));
            Assert.AreEqual("-1, 0, 1", e.Equation2("-x^4+x^2=0"));
            Assert.AreEqual("-1024/377, -11/9, -1, -1/2, 0, 37/24, 7/3", e.Equation2("488592x^7+763866x^6-3786201x^5-5463235x^4+4751353x^3+9070489x^2+2917376x=0"));
            Assert.AreEqual("-1", e.Equation2("x^2+2x+1=0"));
            Assert.AreEqual("-1/2, 1/2", e.Equation2("4x^2-1=0"));
            Assert.AreEqual("-1/2, 1/2, 1", e.Equation2("4x^3-4x^2-x+1=0"));
            Assert.AreEqual("-1/2, 0, 1/2, 1", e.Equation2("4x^6-4x^5-x^4+x^3=0"));
            Assert.AreEqual("-5, -3/4, 1/11, 7/11, 2, 4, 11", e.Equation2("484x^8-3377x^7-34677x^6+110760x^5+488586x^4-1109193x^3-248353x^2+539570x-46200=0"));
            Assert.AreEqual("-3, -2, 2, 3", e.Equation2("x^4-13x^2+36=0"));
            Assert.AreEqual("0", e.Equation2("x^2=0"));
            Assert.AreEqual("-1, 1", e.Equation2("-x^2+1=0"));
            Assert.AreEqual("0", e.Equation2("x=0"));
        }
    }
}