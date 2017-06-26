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
    public class TriangularityTests
    {
        [TestMethod()]
        public void triangularityTest()
        {
            var t = new Triangularity();
            Assert.IsTrue(t.triangularity(new[] { 1, 2, 3, 4 }));
            Assert.IsFalse(t.triangularity(new[] { 1, 2, 3}));
            Assert.IsFalse(t.triangularity(new[] { 388, 143, 238, 28, 4361, 87, 18, 2693, 1660, 50, 630, 1023 }));
            Assert.IsTrue(t.triangularity(new[] { 1, 20, 30, 40 }));
            Assert.IsFalse(t.triangularity(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 100 }));
            Assert.IsFalse(t.triangularity(new[] { 2741414, 94414, 762, 5258, 470, 30, 1694283, 2004, 1236, 7177122, 4435702, 177, 3247, 67, 247189, 152766, 22281, 58347, 399964, 36061, 8508, 287, 1047123, 13772, 102, 647158 }));
            Assert.IsTrue(t.triangularity(new[] { 137, 986319018, 1170007, 1893113, 15387, 723103, 1382, 24898, 331, 232838336, 446900, 2242, 5872, 1595897704, 12975632, 42, 376740339, 33970652, 609578676, 40287, 3063128, 524, 8019376, 88936324, 170695, 143902002, 4956246, 105491, 20995014, 3628, 276195, 94, 65194, 857, 9507, 189, 54965668 }));
            Assert.IsFalse(t.triangularity(new[] { 3, 18195, 6948, 29440, 1640, 7, 32, 625, 47638, 11244, 386, 89, 4294, 146, 1012, 11, 238, 54, 2653, 19, 1 }));
            Assert.IsTrue(t.triangularity(new[] { 36902, 61542, 4240, 2159, 19700, 93716, 88346, 94003, 50237, 1249, 46789, 11782, 45556, 43761, 25065, 65921, 19528, 61044, 53343, 19727 }));
            Assert.IsTrue(t.triangularity(new[] { 21480, 96870, 5327, 87609, 30505, 83868, 27402, 451, 33897, 46529, 21130, 28102, 89338, 38560, 19931, 63641, 15150, 52206, 75827, 78285 }));
        }
    }
}