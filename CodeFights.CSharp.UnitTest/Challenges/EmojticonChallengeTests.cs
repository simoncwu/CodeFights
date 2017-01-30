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
    public class EmojticonChallengeTests
    {
        [TestMethod]
        public void EmojticonTest()
        {
            var e = new EmojticonChallenge();
            var message = "I love you <3";
            var emoticons = new[] { "<3", ":)", "^_^" };
            var expected = "I love you [<3]";
            Assert.AreEqual(expected, e.Emojticon(message, emoticons));

            message = "I love you because 1<3";
            emoticons = new[] { "<3", ":)", "^_^" };
            expected = "I love you because 1<3";
            Assert.AreEqual(expected, e.Emojticon(message, emoticons));

            message = "<3   3:)  :)   :(  =))     ;)";
            emoticons = new[] { "<3", ":3", "3:)", ";)" };
            expected = "[<3]   [3:)]  :)   :(  =))     [;)]";
            Assert.AreEqual(expected, e.Emojticon(message, emoticons));

            message = "for(i = 0; i++ <3;);";
            emoticons = new[] { "<3", ";)", ":)" };
            expected = "for(i = 0; i++ <3;);";
            Assert.AreEqual(expected, e.Emojticon(message, emoticons));

            message = ":* .. kk 53 d2 li 3. :. ;) :) :):) :( <3 :* .* ... .. :? ;[ :] 8] 8} {4} {3} {3";
            emoticons = new[] { ":)", ":(", "<3", ":*", "..", ":?", ";[", ":]", "8}", "{3" };
            expected = "[:*] [..] kk 53 d2 li 3. :. ;) [:)] :):) [:(] [<3] [:*] .* ... [..] [:?] [;[] [:]] 8] [8}] {4} {3} [{3]";
            Assert.AreEqual(expected, e.Emojticon(message, emoticons));
        }
    }
}