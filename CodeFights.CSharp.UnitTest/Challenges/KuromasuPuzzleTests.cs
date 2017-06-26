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
    [TestClass()]
    public class KuromasuPuzzleTests
    {
        [TestMethod()]
        public void kuromasuPuzzleTest()
        {
            var k = new KuromasuPuzzle();
            Func<string, char> parse = char.Parse;
            var board = Util.ParseJaggedArray(@"[[*,.,#,.,.,*,.,.,#,.,.],
[.,*,.,.,*,.,*,.,#,.,.],
[.,.,.,.,#,.,.,.,.,.,#],
[#,.,.,.,.,.,.,*,.,*,.],
[*,#,.,.,*,.,.,.,*,.,.],
[.,.,#,.,#,.,#,*,#,.,.],
[.,.,*,.,.,.,.,.,*,#,*],
[.,.,.,.,*,.,*,.,.,*,#],
[#,.,*,.,.,*,#,.,*,.,.],
[.,.,#,.,.,.,*,.,.,.,.],
[.,*,#,*,.,*,.,.,#,.,*]]", parse);
            var expected = "[[-1,-1,9,-1,-1,-1,-1,-1,8,-1,-1],[-1,-1,-1,-1,-1,-1,-1,-1,7,-1,-1],[-1,-1,-1,-1,12,-1,-1,-1,-1,-1,16],[9,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1],[-1,10,-1,-1,-1,-1,-1,-1,-1,-1,-1],[-1,-1,12,-1,8,-1,11,-1,3,-1,-1],[-1,-1,-1,-1,-1,-1,-1,-1,-1,3,-1],[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,3],[7,-1,-1,-1,-1,-1,2,-1,-1,-1,-1],[-1,-1,7,-1,-1,-1,-1,-1,-1,-1,-1],[-1,-1,2,-1,-1,-1,-1,-1,5,-1,-1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));

            board = Util.ParseJaggedArray(@"[[#]]", parse);
            expected = "[[1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));

            board = Util.ParseJaggedArray(@"[[*]]", parse);
            expected = "[[-1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));

            board = Util.ParseJaggedArray(@"[[.]]", parse);
            expected = "[[-1]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));

            board = Util.ParseJaggedArray(@"[[*,.,*],[.,#,#]]", parse);
            expected = "[[-1,-1,-1],[-1,4,3]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));

            board = Util.ParseJaggedArray(@"[[#,.,*,#,.],[.,*,#,*,.],[#,#,.,.,#]]", parse);
            expected = "[[4,-1,-1,2,-1],[-1,-1,2,-1,-1],[7,5,-1,-1,7]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(k.kuromasuPuzzle(board)));
        }
    }
}