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
    public class EquationChallengeTests
    {
        [TestMethod]
        public void EquationTest()
        {
            var e = new EquationChallenge();
            var roots = "1/3, 2, -3/4";
            var expected = "12x^3-19x^2-13x+6=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-1, -1/2, 7/3, 37/24, -11/9, 0, -1024/377";
            expected = "488592x^7+763866x^6-3786201x^5-5463235x^4+4751353x^3+9070489x^2+2917376x=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "0";
            expected = "x=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-1/2";
            expected = "2x+1=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-1/2,1/2";
            expected = "4x^2-1=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-1/2, 1/2, 1";
            expected = "4x^3-4x^2-x+1=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-3/4, -5, 7/11, 1/11, 11, 2, 4";
            expected = "484x^7-5797x^6-5692x^5+139220x^4-207514x^3-71623x^2+109762x-9240=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "3, -3, -2, 2";
            expected = "x^4-13x^2+36=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "-1/2, 1/2, 1, 0";
            expected = "4x^4-4x^3-x^2+x=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "1/3, 2/3, 1, 4/3, 5/3, 2, 7/3, 8/3, 3, 10/3, 4, -1/3, -2/3, -1, -4/3, -5/3, -2, -7/3, -8/3, -3, -4";
            expected = "1594323x^21-5314410x^20-75996063x^19+253320210x^18+1456266438x^17-4854221460x^16-14748240078x^15+49160800260x^14+86715196623x^13-289050655410x^12-304976884563x^11+1016589615210x^10+636065933448x^9-2120219778160x^8-752538531888x^7+2508461772960x^6+460125946368x^5-1533753154560x^4-120695697408x^3+402318991360x^2+8670412800x-28901376000=0";
            Assert.AreEqual(expected, e.Equation(roots));

            roots = "7/3, 3/7, -5/4, 4/5, 1, 0";
            expected = "420x^6-1391x^5+449x^4+1871x^3-1769x^2+420x=0";
            Assert.AreEqual(expected, e.Equation(roots));
        }
    }
}