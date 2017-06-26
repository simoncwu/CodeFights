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
    public class IsValidNumberTests
    {
        [TestMethod()]
        public void isValidNumberTest()
        {
            var i = new IsValidNumber();
            Assert.IsTrue(i.isValidNumber("100.001", false, false, true));
            Assert.IsFalse(i.isValidNumber("10.000.001", true, true, true));
            Assert.IsTrue(i.isValidNumber("0", true, true, true));
            Assert.IsTrue(i.isValidNumber("123", true, true, true));
            Assert.IsTrue(i.isValidNumber("012345678901234", true, true, true));
            Assert.IsFalse(i.isValidNumber("1000E0001", true, true, true));
            Assert.IsFalse(i.isValidNumber("10.001,001", true, true, true));
            Assert.IsFalse(i.isValidNumber("10,0.001001", true, true, true));
            Assert.IsFalse(i.isValidNumber("100,00", true, true, true));
            Assert.IsFalse(i.isValidNumber(",111", true, true, true));
            Assert.IsFalse(i.isValidNumber("111,", true, true, true));
            Assert.IsFalse(i.isValidNumber("100.001", false, false, false));
            Assert.IsFalse(i.isValidNumber("100.001", false, true, false));
            Assert.IsFalse(i.isValidNumber("1,,,,,,,1", true, true, true));
            Assert.IsTrue(i.isValidNumber("-23,157,000.3", true, true, true));
            Assert.IsFalse(i.isValidNumber("-25", false, true, true));
            Assert.IsFalse(i.isValidNumber("12q334", true, true, true));
        }
    }
}