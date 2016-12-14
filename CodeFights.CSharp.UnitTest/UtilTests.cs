using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFights.CSharp.UnitTest.Util;

namespace CodeFights.CSharp.UnitTest
{
    [TestClass]
    public class UtilTests
    {
        [TestMethod]
        public void ParseArrayTest()
        {
            Func<string, int> parse = int.Parse;
            Assert.IsTrue(new[] { 2, 4, 8, 16 }.SequenceEqual(ParseArray("[2,4,8,16]", parse)));
            Assert.IsTrue(new[] { 9, 7, 5, 3 }.SequenceEqual(ParseArray("[9,7,5,3]", parse)));
            Assert.IsTrue(new[] { 8, 88, 8888 }.SequenceEqual(ParseArray("[8,88,8888]", parse)));
            Assert.IsFalse(new[] { 2, 4, 8, 32 }.SequenceEqual(ParseArray("[2,4,8,16]", parse)));
            Assert.IsFalse(new[] { 16, 8, 4, 2 }.SequenceEqual(ParseArray("[2,4,8,16]", parse)));
        }

        [TestMethod]
        public void ParseJaggedArrayTest()
        {
            Func<string, int> parse = int.Parse;
            string array = "[[66,58,31,3],[91,43,85,20],[30,44,5,27]]";
            Assert.AreEqual(array, JaggedArrayToString((ParseJaggedArray(array, parse))));
            array = "[[1,6,2],[2,2,4]]";
            Assert.AreEqual(array, JaggedArrayToString((ParseJaggedArray(array, parse))));
        }

        [TestMethod]
        public void JaggedArrayToStringTest()
        {
            Assert.AreEqual("[[646,283,52,58],[917,371,96,32],[47,30,59,3]]", JaggedArrayToString(new[] { new[] { 646, 283, 52, 58 }, new[] { 917, 371, 96, 32 }, new[] { 47, 30, 59, 3 } }));
        }

        [TestMethod]
        public void ArrayToStringTest()
        {
            Assert.AreEqual("[8,6,7,5,3,0,9]", ArrayToString(new[] { 8, 6, 7, 5, 3, 0, 9 }));
            Assert.AreEqual("[-8,-6,-7,-5,-3,0,-9]", ArrayToString(new[] { -8, -6, -7, -5, -3, 0, -9 }));
            Assert.AreEqual("[-8,6,-7,5,-3,0,-9]", ArrayToString(new[] { -8, 6, -7, 5, -3, 0, -9 }));
        }
    }
}