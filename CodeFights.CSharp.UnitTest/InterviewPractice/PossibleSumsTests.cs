using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class PossibleSumsTests
    {
        [TestMethod()]
        public void possibleSumsTest()
        {
            var p = new PossibleSums();
            var coins = new[] { 10, 50, 100 };
            var quantity = new[] { 1, 2, 1 };
            Assert.AreEqual(9, p.possibleSums(coins, quantity));

            coins = new[] { 10, 50, 100, 500 };
            quantity = new[] { 5, 3, 2, 2 };
            Assert.AreEqual(122, p.possibleSums(coins, quantity));

            coins = new[] { 1 };
            quantity = new[] { 5 };
            Assert.AreEqual(5, p.possibleSums(coins, quantity));

            coins = new[] { 1, 1 };
            quantity = new[] { 2, 3 };
            Assert.AreEqual(5, p.possibleSums(coins, quantity));

            coins = new[] { 1, 2 };
            quantity = new[] { 50000, 2 };
            Assert.AreEqual(50004, p.possibleSums(coins, quantity));

            coins = new[] { 1, 2, 3 };
            quantity = new[] { 2, 3, 10000 };
            Assert.AreEqual(30008, p.possibleSums(coins, quantity));

            coins = new[] { 3, 1, 1 };
            quantity = new[] { 111, 84, 104 };
            Assert.AreEqual(521, p.possibleSums(coins, quantity));

            coins = new[] { 1, 1, 1, 1, 1 };
            quantity = new[] { 9, 19, 18, 12, 19 };
            Assert.AreEqual(77, p.possibleSums(coins, quantity));
        }
    }
}