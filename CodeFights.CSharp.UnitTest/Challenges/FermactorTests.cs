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
    public class FermactorTests
    {
        [TestMethod()]
        public void fermactorTest()
        {
            var f = new Fermactor();
            Assert.IsTrue(new[] { 4, 1 }.SequenceEqual(f.fermactor(15)));
            Assert.IsTrue(new[] { 5, 2 }.SequenceEqual(f.fermactor(21)));
            Assert.IsTrue(new[] { 8, 3 }.SequenceEqual(f.fermactor(55)));
            Assert.IsTrue(new[] { 9, 2 }.SequenceEqual(f.fermactor(77)));
            Assert.IsTrue(new[] { 9, 4 }.SequenceEqual(f.fermactor(65)));
            Assert.IsTrue(new[] { 17, 12 }.SequenceEqual(f.fermactor(145)));
            Assert.IsTrue(new[] { 12, 1 }.SequenceEqual(f.fermactor(143)));
        }
    }
}