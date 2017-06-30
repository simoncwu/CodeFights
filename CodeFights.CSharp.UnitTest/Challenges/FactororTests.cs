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
    public class FactororTests
    {
        [TestMethod()]
        public void factororTest()
        {
            var f = new Factoror();
            Assert.IsTrue(new[] { 4 }.SequenceEqual(f.factoror(new[] { 14 })));
            Assert.IsTrue(new[] { 1, 2, 3, 4, 5 }.SequenceEqual(f.factoror(new[] { 5, 6, 9, 14, 120 })));
            Assert.IsTrue(new[] { 1, 3, 4 }.SequenceEqual(f.factoror(new[] { 4, 8, 16 })));
            Assert.IsTrue(new int[0].SequenceEqual(f.factoror(new int[0])));
            Assert.IsTrue(new[] { 1, 1, 1, 1 }.SequenceEqual(f.factoror(new[] { 2, 3, 4, 5 })));
            Assert.IsTrue(new[] { 2, 1, 3, 3, 2 }.SequenceEqual(f.factoror(new[] { 6, 7, 8, 9, 10 })));
        }
    }
}