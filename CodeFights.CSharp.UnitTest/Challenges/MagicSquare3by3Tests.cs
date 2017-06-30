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
    public class MagicSquare3by3Tests
    {
        [TestMethod()]
        public void magicSquare3by3Test()
        {
            var m = new MagicSquare3by3();
            Assert.IsTrue(m.magicSquare3by3(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.IsFalse(m.magicSquare3by3(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { 0, 3, 6, 9, 12, 15, 18, 21, 24 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { 0, 4, 8, 10, 14, 18, 20, 24, 28 }));
            Assert.IsFalse(m.magicSquare3by3(new[] { -1, -1, -1, -1, 0, 1, 1, 1, 1 }));
            Assert.IsFalse(m.magicSquare3by3(new[] { 925, 917, 924, 918, 915, 921, 916, 923, 922 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { -319, 528, 73, 486, -298, 94, 115, -340, 507 }));
            Assert.IsTrue(m.magicSquare3by3(new[] { 7, 8, 8, 9, 9, 9, 10, 10, 11 }));
        }
    }
}