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
    public class HeavenlyBlissRecipeChallengeTests
    {
        [TestMethod]
        public void HeavenlyBlissReceipeTest()
        {
            var h = new HeavenlyBlissRecipeChallenge();
            Func<string, int> parse = int.Parse;
            var inscriptions = Util.ParseJaggedArray("[[1,2,1],[3,2,1],[1,1,2]]", parse);
            var ratio = new[] { 1, 1, 1 };
            var expected = "[1,1,2]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,2,3],[2,3,1],[3,1,2]]", parse);
            ratio = new[] { 1, 1, 1 };
            expected = "[1,1,1]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,0,0],[0,1,0],[0,0,1]]", parse);
            ratio = new[] { 5, 2, 3 };
            expected = "[5,2,3]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,2,3],[3,4,1],[5,1,1]]", parse);
            ratio = new[] { 0, 2, 3 };
            expected = "[0,0,0]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[7,13,22],[9,2,1],[8,7,6]]", parse);
            ratio = new[] { 170, 144, 193 };
            expected = "[7,9,5]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[2,5,4],[1,3,2],[2,10,9]]", parse);
            ratio = new[] { 178, 881, 791 };
            expected = "[1,2,87]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[2,12,9],[256,5,729],[121,110,132]]", parse);
            ratio = new[] { 3, 1, 8 };
            expected = "[36267,7249,2459]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,10,9],[10,1,3],[57,75,79]]", parse);
            ratio = new[] { 13513, 15331, 16540 };
            expected = "[63,2261,2210]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,10,9],[10,1,3],[57,75,79]]", parse);
            ratio = new[] { 13515, 15322, 65382 };
            expected = "[0,0,0]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,10,9],[10,1,3],[58,74,78]]", parse);
            ratio = new[] { 2065, 20243, 18228 };
            expected = "[0,0,0]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));

            inscriptions = Util.ParseJaggedArray("[[1,10,9],[10,1,3],[58,74,78]]", parse);
            ratio = new[] { 328, 365, 393 };
            expected = "[6,9,4]";
            Assert.AreEqual(expected, Util.ArrayToString(h.HeavenlyBlissReceipe(inscriptions, ratio)));
        }
    }
}