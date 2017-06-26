using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class SquaresUnderQueenAttackTests
    {
        [TestMethod()]
        public void squaresUnderQueenAttackTest()
        {
            var s = new SquaresUnderQueenAttack();
            Func<string, int> parse = int.Parse;
            var queens = Util.ParseJaggedArray("[[1,1],[3,2]]", parse);
            var queries = Util.ParseJaggedArray("[[1,1],[0,3],[0,4],[3,4],[2,0],[4,3],[4,0]]", parse);
            var expected = new[] { true, false, false, true, true, true, false };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(5, queens, queries)));

            queens = new int[0][];
            queries = Util.ParseJaggedArray("[[0,0]]", parse);
            expected = new[] { false };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(1, queens, queries)));

            queens = Util.ParseJaggedArray("[[0,0]]", parse);
            queries = Util.ParseJaggedArray("[[0,0]]", parse);
            expected = new[] { true };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(1, queens, queries)));

            queens = Util.ParseJaggedArray("[[1,0]]", parse);
            queries = Util.ParseJaggedArray("[[0,0],[0,1],[1,0],[1,1]]", parse);
            expected = new[] { true, true, true, true };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(2, queens, queries)));

            queens = Util.ParseJaggedArray("[[1,0],[1,1]]", parse);
            queries = Util.ParseJaggedArray("[[0,0],[0,1],[0,2],[0,3],[1,0],[1,1],[1,2],[1,3],[2,0],[2,1],[2,2],[2,3],[3,0],[3,1],[3,2],[3,3]]", parse);
            expected = new[] { true, true, true, false, true, true, true, true, true, true, true, false, true, true, true, true };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(4, queens, queries)));

            queens = new int[0][];
            queries = Util.ParseJaggedArray("[[0,0],[0,1],[0,2],[1,0],[1,1],[1,2],[2,0],[2,1],[2,2]]", parse);
            expected = new[] { false, false, false, false, false, false, false, false, false };
            Assert.IsTrue(expected.SequenceEqual(s.squaresUnderQueenAttack(3, queens, queries)));
        }
    }
}