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
    public class PasswordStrengthTests
    {
        [TestMethod()]
        public void passwordStrengthTest()
        {
            var p = new PasswordStrength();
            Assert.AreEqual(36.58319925463717, p.passwordStrength("abcc73?"));
            Assert.AreEqual(8.101319154423278, p.passwordStrength("aaa"));
            Assert.AreEqual(24.303957463269832, p.passwordStrength("aaaaaaaaa"));
            Assert.AreEqual(41.29049610144165, p.passwordStrength("abcdefghi"));
            Assert.AreEqual(72.2186525635304, p.passwordStrength("H0ley$Mol3y_"));
            Assert.AreEqual(97.21582985307933, p.passwordStrength("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.AreEqual(146.8422482902136, p.passwordStrength("aaaaaaaaaaaaaaaaaaaaAaaaaaaaaaaaaaaa"));
        }
    }
}