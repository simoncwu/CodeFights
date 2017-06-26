using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class AFMNumbersTests
    {
        [TestMethod()]
        public void AFM_numbersTest()
        {
            var a = new AFMNumbers();
            Assert.IsTrue(new[] { 0, 1 }.SequenceEqual(a.AFM_numbers(1)));
            Assert.IsTrue(new[] { 1, 2 }.SequenceEqual(a.AFM_numbers(2)));
            Assert.IsTrue(new[] { 2, 5 }.SequenceEqual(a.AFM_numbers(3)));
            Assert.IsTrue(new[] { 5, 10 }.SequenceEqual(a.AFM_numbers(4)));
            Assert.IsTrue(new[] { 10, 21 }.SequenceEqual(a.AFM_numbers(5)));
            Assert.IsTrue(new[] { 21, 42 }.SequenceEqual(a.AFM_numbers(6)));
            Assert.IsTrue(new[] { 42, 85 }.SequenceEqual(a.AFM_numbers(7)));
            Assert.IsTrue(new[] { 85, 170 }.SequenceEqual(a.AFM_numbers(8)));
            Assert.IsTrue(new[] { 170, 341 }.SequenceEqual(a.AFM_numbers(9)));
            Assert.IsTrue(new[] { 5461, 10922 }.SequenceEqual(a.AFM_numbers(14)));
        }
    }
}