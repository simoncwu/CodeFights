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
    public class MatrixElementsInSpiralOrderTests
    {
        [TestMethod()]
        public void matrixElementsInSpiralOrderTest()
        {
            var m = new MatrixElementsInSpiralOrder();
            Func<string, int> parse = int.Parse;
            var matrix = Util.ParseJaggedArray(@"[[1,2,3], 
 [8,9,4], 
 [7,6,5]]", parse);
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[]", parse);
            expected = new int[0];
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[1]]", parse);
            expected = new[] { 1 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[0,3], 
 [5,5]]", parse);
            expected = new[] { 0, 3, 5, 5 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[33,29,-15,-20,-41,-1,34,20,-41,44], 
 [14,-11,-27,-35,29,-14,34,-41,49,19], 
 [-12,-44,44,-43,-13,-6,40,-24,-6,8], 
 [-40,4,27,2,2,15,38,4,-13,15], 
 [-42,3,5,10,15,34,-18,-22,9,38]]", parse);
            expected = new[] { 33, 29, -15, -20, -41, -1, 34, 20, -41, 44, 19, 8, 15, 38, 9, -22, -18, 34, 15, 10, 5, 3, -42, -40, -12, 14, -11, -27, -35, 29, -14, 34, -41, 49, -6, -13, 4, 38, 15, 2, 2, 27, 4, -44, 44, -43, -13, -6, 40, -24 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[19,-17,23,44,12,-23,-37,26,-38,-36], 
 [38,26,7,-3,-48,40,36,-20,22,-50], 
 [39,50,-29,48,44,-31,-17,32,-42,-27], 
 [-44,-47,47,43,31,11,-14,-22,-46,-18], 
 [-38,31,0,-14,-6,48,30,-41,31,-24], 
 [21,39,-39,-4,45,22,-23,-40,24,-16], 
 [33,-1,46,-36,26,-36,4,29,16,-12], 
 [7,-3,46,36,-4,-22,17,12,-13,-28], 
 [-33,-1,30,27,-44,-7,6,-37,31,48], 
 [50,23,43,36,-29,5,-45,33,-24,41]]", parse);
            expected = new[] { 19, -17, 23, 44, 12, -23, -37, 26, -38, -36, -50, -27, -18, -24, -16, -12, -28, 48, 41, -24, 33, -45, 5, -29, 36, 43, 23, 50, -33, 7, 33, 21, -38, -44, 39, 38, 26, 7, -3, -48, 40, 36, -20, 22, -42, -46, 31, 24, 16, -13, 31, -37, 6, -7, -44, 27, 30, -1, -3, -1, 39, 31, -47, 50, -29, 48, 44, -31, -17, 32, -22, -41, -40, 29, 12, 17, -22, -4, 36, 46, 46, -39, 0, 47, 43, 31, 11, -14, 30, -23, 4, -36, 26, -36, -4, -14, -6, 48, 22, 45 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[9]]", parse);
            expected = new[] { 9 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));

            matrix = Util.ParseJaggedArray(@"[[11],[28],[1980],[11],[15]]", parse);
            expected = new[] { 11, 28, 1980, 11, 15 };
            Assert.IsTrue(expected.SequenceEqual(m.matrixElementsInSpiralOrder(matrix)));
        }
    }
}