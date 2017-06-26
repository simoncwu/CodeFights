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
    public class ReciprocalTests
    {
        [TestMethod()]
        public void reciprocalTest()
        {
            var r = new Reciprocal();
            Assert.AreEqual(1, r.reciprocal(7, 1));
            Assert.AreEqual(0, r.reciprocal(8, 8));
            Assert.AreEqual(0, r.reciprocal(1, 1));
            Assert.AreEqual(5, r.reciprocal(2, 1));
            Assert.AreEqual(3, r.reciprocal(3, 1));
            Assert.AreEqual(3, r.reciprocal(3, 9));
            Assert.AreEqual(1, r.reciprocal(6, 1));
            Assert.AreEqual(6, r.reciprocal(6, 2));
            Assert.AreEqual(6, r.reciprocal(6, 99));
            Assert.AreEqual(7, r.reciprocal(7, 6));
            Assert.AreEqual(1, r.reciprocal(7, 7));
            Assert.AreEqual(8, r.reciprocal(7, 10));
            Assert.AreEqual(1, r.reciprocal(7, 13));
            Assert.AreEqual(1, r.reciprocal(10, 1));
            Assert.AreEqual(0, r.reciprocal(10, 2));
            Assert.AreEqual(0, r.reciprocal(15, 1));
            Assert.AreEqual(6, r.reciprocal(15, 2));
            Assert.AreEqual(6, r.reciprocal(15, 99));
            Assert.AreEqual(0, r.reciprocal(112, 2));
            Assert.AreEqual(8, r.reciprocal(112, 3));
            Assert.AreEqual(9, r.reciprocal(112, 4));
            Assert.AreEqual(2, r.reciprocal(112, 5));
            Assert.AreEqual(4, r.reciprocal(112, 10));
            Assert.AreEqual(2, r.reciprocal(112, 11));
            Assert.AreEqual(4, r.reciprocal(112, 16));
            Assert.AreEqual(5, r.reciprocal(112, 85));
            Assert.AreEqual(2, r.reciprocal(777, 1234));
            Assert.AreEqual(3, r.reciprocal(9876, 1919));
            Assert.AreEqual(7, r.reciprocal(12345, 987654321));
        }
    }
}