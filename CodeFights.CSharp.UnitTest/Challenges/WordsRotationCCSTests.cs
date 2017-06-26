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
    public class WordsRotationCCSTests
    {
        [TestMethod()]
        public void wordsRotationCcTest()
        {
            var w = new WordsRotationCCS();
            var expected = new[] { "ersk", "lekn", "pgni", "pnot", "aams" };
            var words = new[] { "apple", "anger", "monks", "stink" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "bdf", "ace" };
            words = new[] { "ab", "cd", "ef" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "ssgy", "egnl", "lnig", "zaln", "zbzi", "uzzl", "fzuz", "mimz", "uheu", "bwbp" };
            words = new[] { "bumfuzzles", "whizzbangs", "bemuzzling", "puzzlingly" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "o", "l", "l", "e", "h" };
            words = new[] { "hello" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "codefights" };
            words = new[] { "c", "o", "d", "e", "f", "i", "g", "h", "t", "s" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "etesteeisa", "attsooeeei", "saaarrrrrr" };
            words = new[] { "sae", "att", "ate", "ass", "rot", "roe", "ree", "rei", "res", "ria" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));

            expected = new[] { "zzzozdesrkyyydee", "zzabzeleeizlzell", "aazzazzzzjzzzzzz", "zzzzzzzzzzizuzzz", "aiiaeaiaauhicuuu", "pppjbjzjjmwmsfpm" };
            words = new[] { "pazazz", "pizazz", "pizzaz", "jazzbo", "bezazz", "jazzed", "zizzle", "jazzes", "jazzer", "muzjik", "whizzy", "mizzly", "scuzzy", "fuzzed", "puzzle", "muzzle" };
            Assert.IsTrue(expected.SequenceEqual(w.wordsRotationCc(words)));
        }
    }
}