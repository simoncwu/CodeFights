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
    public class ReverseVowelsOfStringTests
    {
        [TestMethod()]
        public void reverseVowelsOfStringTest()
        {
            var r = new ReverseVowelsOfString();
            Assert.AreEqual("hollo, werld", r.reverseVowelsOfString("hello, world"));
            Assert.AreEqual("cidefoghts", r.reverseVowelsOfString("codefights"));
            Assert.AreEqual("UOaIye", r.reverseVowelsOfString("eIaOyU"));
            Assert.AreEqual("", r.reverseVowelsOfString(""));
            Assert.AreEqual(" ", r.reverseVowelsOfString(" "));
            Assert.AreEqual(".a", r.reverseVowelsOfString(".a"));
            Assert.AreEqual("ia", r.reverseVowelsOfString("ai"));
            Assert.AreEqual("Aa", r.reverseVowelsOfString("aA"));
            Assert.AreEqual(".,", r.reverseVowelsOfString(".,"));
            Assert.AreEqual("ab", r.reverseVowelsOfString("ab"));
            Assert.AreEqual("0P", r.reverseVowelsOfString("0P"));
            Assert.AreEqual("!!!", r.reverseVowelsOfString("!!!"));
            Assert.AreEqual("a a", r.reverseVowelsOfString("a a"));
            Assert.AreEqual("abb", r.reverseVowelsOfString("abb"));
            Assert.AreEqual("1b1", r.reverseVowelsOfString("1b1"));
            Assert.AreEqual("abba", r.reverseVowelsOfString("abba"));
            Assert.AreEqual("c#dc", r.reverseVowelsOfString("c#dc"));
            Assert.AreEqual("......a.....", r.reverseVowelsOfString("......a....."));
            Assert.AreEqual("raca e car", r.reverseVowelsOfString("race a car"));
            Assert.AreEqual("ablE was I ere I saw elbA.", r.reverseVowelsOfString("Able was I ere I saw Elba."));
            Assert.AreEqual("a man, a plan, a canal -- PanamA", r.reverseVowelsOfString("A man, a plan, a canal -- Panama"));
            Assert.AreEqual("Doc, note: i dIssent. a fast never prevents a fAtness. i dIet on cod", r.reverseVowelsOfString("Doc, note: I dissent. A fast never prevents a fatness. I diet on cod"));
        }
    }
}