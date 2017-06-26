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
    public class StringReformattingTests
    {
        [TestMethod()]
        public void stringReformattingTest()
        {
            var s = new StringReformatting();
            Assert.AreEqual("24a0-r74k", s.stringReformatting("2-4a0r7-4k", 4));
            Assert.AreEqual("24-a0r-74k", s.stringReformatting("2-4a0r7-4k", 3));
            Assert.AreEqual("", s.stringReformatting("-", 1));
            Assert.AreEqual("a-b-c-x-y-z", s.stringReformatting("abc-xyz", 1));
            Assert.AreEqual("$-!5GR", s.stringReformatting("-$!5G-R-", 4));
            Assert.AreEqual("9-$$4-g55-6ja", s.stringReformatting("9$-$-4g-55-6ja", 3));
            Assert.AreEqual("$?-!V-30-0%-%$", s.stringReformatting("$?!V-30-0-%-%$", 2));
            Assert.AreEqual("IBd-#01IL646j$@82$TBU", s.stringReformatting("IBd#0-1-IL646-j$@8-2$-TBU", 17));
            Assert.AreEqual("@d8zKxhSj-aRrF#{mWF4-3ef88#%Y?A", s.stringReformatting("@d8zKxhS-jaRrF#{mWF43ef88#%Y?A", 10));
            Assert.AreEqual("E$RJ0n[Z%3Wh0pp-RdKg3?5H{733@[#y961$xB", s.stringReformatting("E$RJ0n[Z%3Wh0ppRdKg3?5H{733@[#-y9-61$x-B", 22));
            Assert.AreEqual("?CC?-[yiq2bg-Ie9?z!e-2X1i*k4-8ZMjllM-VEX2v%*", s.stringReformatting("?CC?-[yiq2bg-Ie9?z!e-2X1i*k4-8ZMjllM-VEX2v%*", 7));
        }
    }
}