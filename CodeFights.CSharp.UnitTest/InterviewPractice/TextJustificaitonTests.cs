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
    public class TextJustificaitonTests
    {
        [TestMethod()]
        public void textJustificationTest()
        {
            var t = new TextJustificaiton();
            var words = new[] { "This", "is", "an", "example", "of", "text", "justification." };
            var L = 16;
            var expected = new[] { "This    is    an", "example  of text", "justification.  " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Two", "words." };
            L = 11;
            expected = new[] { "Two words. " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Two", "words." };
            L = 10;
            expected = new[] { "Two words." };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Two", "words." };
            L = 9;
            expected = new[] { "Two      ", "words.   " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "vba", "gaff", "ye", "gs", "cthj", "hf", "vetjj", "jm", "k", "f", "cgbf", "zzz" };
            L = 8;
            expected = new[] { "vba gaff", "ye    gs", "cthj  hf", "vetjj jm", "k f cgbf", "zzz     " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Given", "an", "array", "of", "words", "and", "a", "length" };
            L = 9;
            expected = new[] { "Given  an", "array  of", "words and", "a length " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Extra", "spaces", "between", "words", "should", "be", "distributed", "as", "evenly", "as", "possible" };
            L = 20;
            expected = new[] { "Extra spaces between", "words    should   be", "distributed       as", "evenly as possible  " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "" };
            L = 2;
            expected = new[] { "  " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Two", "words." };
            L = 9;
            expected = new[] { "Two      ", "words.   " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "a" };
            L = 1;
            expected = new[] { "a" };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "a" };
            L = 2;
            expected = new[] { "a " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "a", "b", "c", "d", "e" };
            L = 1;
            expected = new[] { "a", "b", "c", "d", "e" };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "a", "b", "c", "d", "e" };
            L = 3;
            expected = new[] { "a b", "c d", "e  " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));

            words = new[] { "Listen", "to", "many,", "speak", "to", "a", "few." };
            L = 6;
            expected = new[] { "Listen", "to    ", "many, ", "speak ", "to   a", "few.  " };
            Assert.IsTrue(t.textJustification(words, L).SequenceEqual(expected));
        }
    }
}