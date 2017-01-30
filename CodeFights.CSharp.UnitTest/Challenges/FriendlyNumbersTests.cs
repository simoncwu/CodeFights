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
    public class FriendlyNumbersTests
    {
        [TestMethod]
        public void friendly_numbersTest()
        {
            var f = new FriendlyNumbers();
            Assert.AreEqual("Yes", f.friendly_numbers(220, 284));
            Assert.AreEqual("Yes", f.friendly_numbers(66928, 66992));
            Assert.AreEqual("No", f.friendly_numbers(6, 6));
            Assert.AreEqual("No", f.friendly_numbers(33337, 45875));
            Assert.AreEqual("Yes", f.friendly_numbers(88730, 79750));
            Assert.AreEqual("No", f.friendly_numbers(25359, 88516));
            Assert.AreEqual("Yes", f.friendly_numbers(76084, 63020));
        }
    }
}