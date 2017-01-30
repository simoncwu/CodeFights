using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class AwardedPrizesTests
    {
        [TestMethod]
        public void awardedPrizesTest()
        {
            var a = new AwardedPrizes();
            Func<string, int> parse = int.Parse;
            var prizes = Util.ParseJaggedArray("[[1, 1, 100], [2,2,50], [3,3,25]]", parse);
            var guesses = new[] { 70, 60, 80, 72, 72, 72 };
            var answer = 70;
            var expected = "[100,50,0,8.34,8.34,8.34]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[1,1,100], [2, 2, 50], [3, 3, 25]]", parse);
            guesses = new[] { 70, 80 };
            answer = 70;
            expected = "[100,50]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[1,1,100], [2, 2, 50], [3, 4, 25]]", parse);
            guesses = new[] { 65, 70, 78, 65, 72 };
            answer = 70;
            expected = "[37.5,100,0,37.5,25]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[1,1,100], [2, 2, 50]]", parse);
            guesses = new[] { 59, 50, 71, 45, 61 };
            answer = 60;
            expected = "[100,50,0,0,0]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[2,2,50], [3, 3, 25], [1, 1, 100]]", parse);
            guesses = new[] { 81, 64, 75, 55 };
            answer = 75;
            expected = "[0,50,100,25]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[1,1,100], [2, 2, 50], [3, 3, 25]]", parse);
            guesses = new[] { 36, 42, 25, 36, 30 };
            answer = 42;
            expected = "[37.5,100,0,37.5,0]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));

            prizes = Util.ParseJaggedArray("[[1,1,100]]", parse);
            guesses = new[] { 75, 90, 73, 82 };
            answer = 71;
            expected = "[0,0,100,0]";
            Assert.AreEqual(expected, Util.ArrayToString(a.awardedPrizes(prizes, guesses, answer)));
        }
    }
}