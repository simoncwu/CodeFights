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
    public class RotateArrayFromIndexTests
    {
        [TestMethod()]
        public void rotateArrayFromIndexTest()
        {
            var r = new RotateArrayFromIndex();
            Assert.IsTrue(new[] { 2, 3, 1 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1, 2, 3 }, 0, 2)));
            Assert.IsTrue(new[] { 5, 1, 7, 0, 2, 2, 7, 9 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 5, 2, 1, 7, 0, 2, 7, 9 }, 1, 5)));
            Assert.IsTrue(new[] { 1 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1 }, 0, 1)));
            Assert.IsTrue(new[] { 1, 3, 2 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1, 2, 3 }, 1, 3)));
            Assert.IsTrue(new[] { 1, 2, 3 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1, 2, 3 }, 4, 2)));
            Assert.IsTrue(new[] { 2, 1, 5, 9, 2, 11, 84 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1, 5, 9, 2, 11, 84, 2 }, 19, 0)));
            Assert.IsTrue(new[] { 2, 3, 1 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 3, 1, 2 }, 2, 0)));
            Assert.IsTrue(new[] { 1, 84, 2, 1, 7, 5, 46, 3, 78, 625, 3, 74, 647, 5, 364, 687, 25, 1, 446, 85, 67, 46, 5, 8, 476543, 21, 64, 78, 6, 5, 56, 8, 65, 12, 654, 8, 654, 23, 3, 4, 8, 2, 6, 4, 856, 321, 3, 8, 3 }.SequenceEqual(r.rotateArrayFromIndex(new[] { 1, 84, 2, 1, 7, 5, 46, 3, 78, 625, 3, 74, 647, 5, 364, 687, 25, 1, 446, 85, 67, 46, 5, 321, 8, 476543, 21, 64, 78, 6, 5, 56, 8, 65, 12, 654, 8, 654, 23, 3, 4, 8, 2, 6, 4, 856, 3, 8, 3 }, 23, 45)));
        }
    }
}