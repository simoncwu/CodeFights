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
    public class CodeObfuscationTests
    {
        [TestMethod()]
        public void codeObfuscationTest()
        {
            var c = new CodeObfuscation();
            Assert.IsTrue(c.codeObfuscation(new[] { 1 }, "0R"));
            Assert.IsFalse(c.codeObfuscation(new int[0], "00"));
            Assert.IsTrue(c.codeObfuscation(new[] { 1, 2, 3 }, "0RCODEFIGHTS"));
            Assert.IsFalse(c.codeObfuscation(new[] { 1, 2, 3 }, "S201030R"));
            Assert.IsTrue(c.codeObfuscation(new[] { 2 }, "0100000R"));
            Assert.IsFalse(c.codeObfuscation(new[] { 2, 2, 2, 1 }, "11011102110311040R"));
            Assert.IsFalse(c.codeObfuscation(new int[0], "G001020R"));
            Assert.IsTrue(c.codeObfuscation(new int[0], ""));
            Assert.IsTrue(c.codeObfuscation(new[] { 1, 2, 3, 4, 5, 6 }, "0100004A0000130101S2030311013F01990405G005010R"));
            Assert.IsTrue(c.codeObfuscation(new[] { 1, 2, 3, 4, 5, 6 }, "0100004A0000130101S2030311013F01990405G005010RCODEFIGHTS"));
            Assert.IsFalse(c.codeObfuscation(new int[0], "0r"));
            Assert.IsTrue(c.codeObfuscation(new int[0], "0R"));
            Assert.IsFalse(c.codeObfuscation(new[] { 1, 2, 3 }, "4A0102130203CODEFIGHTS"));
            Assert.IsFalse(c.codeObfuscation(new[] { 1, 2, 3 }, "G0A01010124asfIOFASJJA"));
            Assert.IsFalse(c.codeObfuscation(new[] { 1, 2, 3 }, "0100004a00000R"));
            Assert.IsTrue(c.codeObfuscation(new[] { 4, 2, 1, 5, 2, 3, 4, 1, 2, 3, 3, 1, 6, 2, 1, 6 }, "010A0B0R"));
        }
    }
}