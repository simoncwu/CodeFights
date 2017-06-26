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
    public class IsGoodMatrixTests
    {
        [TestMethod]
        public void isGoodMatrixTest()
        {
            var i = new IsGoodMatrix();
            Func<string, int> parse = int.Parse;
            var matrix = Util.ParseJaggedArray("[[7,3,5,1],[5,7,3,5],[1,5,7,3],[2,1,5,7]]", parse);
            Assert.IsTrue(i.isGoodMatrix(matrix));

            matrix = Util.ParseJaggedArray("[[1,2,3,4],[0,1,4,3],[4,0,2,2],[4,2,0,1]]", parse);
            Assert.IsFalse(i.isGoodMatrix(matrix));

            matrix = Util.ParseJaggedArray("[[1,1,0],[1,1,1],[0,1,1]]", parse);
            Assert.IsTrue(i.isGoodMatrix(matrix));

            matrix = Util.ParseJaggedArray("[-100]]", parse);
            Assert.IsTrue(i.isGoodMatrix(matrix));

            matrix = Util.ParseJaggedArray("[[1,1],[1,2]]", parse);
            Assert.IsFalse(i.isGoodMatrix(matrix));
        }
    }
}