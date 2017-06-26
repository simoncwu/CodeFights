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
    public class CodeGolfReducedScoreTests
    {
        [TestMethod()]
        public void codeGolfReducedScoreTest()
        {
            var c = new CodeGolfReducedScore();
            Assert.AreEqual(29, c.codeGolfReducedScore("var text = \"This is JavaScript text\";"));
            Assert.AreEqual(9, c.codeGolfReducedScore("let date = Date.now();"));
            Assert.AreEqual(32, c.codeGolfReducedScore("var test = '';\rfor (var index = 0; index < 10; index++)\rtest += index;\ralert(test);"));
            Assert.AreEqual(7, c.codeGolfReducedScore("var pi = Math.PI;"));
            Assert.AreEqual(6, c.codeGolfReducedScore("var answer = 42;"));
            Assert.AreEqual(9, c.codeGolfReducedScore("var lambda = function() {};"));
            Assert.AreEqual(9, c.codeGolfReducedScore("var lolwat = '\r\\t';"));
            Assert.AreEqual(16, c.codeGolfReducedScore("\tvar Test = 'New to ES6';\r"));
            Assert.AreEqual(91, c.codeGolfReducedScore("i = k = r = []\rextractPinCode = c => \rc.map(x => \r    ++i % 2 ? y = x - b + 7 >> 1 : (o = x - a + 3 + 6 * y >> 1) > 11 ? --k : r[k++] = o % 11, \r    b = c.pop(a = c.pop())\r) && r"));
            Assert.AreEqual(4, c.codeGolfReducedScore("somevar = 20"));
            Assert.AreEqual(20, c.codeGolfReducedScore("a2 = 'test 40';b2d42=\"nope\""));
            Assert.AreEqual(8, c.codeGolfReducedScore("Test1 = 23;\rtest2 = Test1"));
        }
    }
}