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
    public class TetrahedronMaxFaceChallengeTests
    {
        [TestMethod]
        public void TetrahedronMaxFaceTest()
        {
            var t = new TetrahedronMaxFaceChallenge();
            Assert.AreEqual(4038, t.TetrahedronMaxFace(new[] { 2017, 2016, 2015, 5, 4, 3 }));
            Assert.AreEqual(0, t.TetrahedronMaxFace(new[] { 2017, 2016, 2015, 5, 3, 2 }));
            Assert.AreEqual(33, t.TetrahedronMaxFace(new[] { 7, 7, 7, 13, 13, 13 }));
            Assert.AreEqual(31, t.TetrahedronMaxFace(new[] { 5, 5, 13, 13, 9, 8 }));
            Assert.AreEqual(309, t.TetrahedronMaxFace(new[] { 50, 48, 130, 131, 90, 80 }));
            Assert.AreEqual(0, t.TetrahedronMaxFace(new[] { 50, 47, 130, 131, 90, 80 }));
            Assert.AreEqual(366, t.TetrahedronMaxFace(new[] { 142, 130, 94, 87, 89, 54 }));
            Assert.AreEqual(3360, t.TetrahedronMaxFace(new[] { 1420, 1400, 884, 870, 550, 540 }));
            Assert.AreEqual(0, t.TetrahedronMaxFace(new[] { 1420, 1400, 883, 870, 550, 540 }));
            Assert.AreEqual(6048, t.TetrahedronMaxFace(new[] { 2015, 2016, 2017, 1163, 1164, 1165 }));
            Assert.AreEqual(5197, t.TetrahedronMaxFace(new[] { 2015, 2016, 2017, 1163, 1164, 1164 }));

            // hidden tests
            Assert.AreEqual(3488, t.TetrahedronMaxFace(new[] { 1409, 1409, 684, 670, 745, 740 }));
            Assert.AreEqual(382, t.TetrahedronMaxFace(new[] { 54, 62, 145, 94, 90, 183 }));
            Assert.AreEqual(6262, t.TetrahedronMaxFace(new[] { 3081, 2017, 2017, 1163, 1164, 1164 }));
            Assert.AreEqual(0, t.TetrahedronMaxFace(new[] { 3081, 2016, 2017, 1163, 1164, 1164 }));
            Assert.AreEqual(6261, t.TetrahedronMaxFace(new[] { 3080, 2016, 2017, 1163, 1164, 1164 }));
            Assert.AreEqual(336, t.TetrahedronMaxFace(new[] { 54, 55, 100, 94, 90, 142 }));
            Assert.AreEqual(336, t.TetrahedronMaxFace(new[] { 54, 55, 100, 94, 130, 142 }));
            Assert.AreEqual(8009, t.TetrahedronMaxFace(new[] { 2, 3, 4001, 4002, 4003, 4004 }));
            Assert.AreEqual(3830, t.TetrahedronMaxFace(new[] { 541, 621, 1839, 1450, 939, 901 }));
            Assert.AreEqual(0, t.TetrahedronMaxFace(new[] { 54, 62, 145, 94, 90, 184 }));
        }
    }
}