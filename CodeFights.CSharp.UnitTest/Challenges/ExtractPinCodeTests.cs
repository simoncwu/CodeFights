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
    public class ExtractPinCodeTests
    {
        [TestMethod]
        public void extractPinCodeTest()
        {
            var e = new ExtractPinCode();
            Assert.AreEqual("[1,5,3,8]", Util.ArrayToString(e.extractPinCode(new[] { 1.5, 1.5, 3.4, 3.5, 1.3, 5.7, 5.4, 3.8, 7.5, 1.6 })));
            Assert.AreEqual("[1,5,3,8]", Util.ArrayToString(e.extractPinCode(new[] { 101.5, 201.5, 103.4, 203.5, 101.3, 205.7, 105.4, 203.8, 107.5, 201.6 })));
            Assert.AreEqual("[1,5,3,8]", Util.ArrayToString(e.extractPinCode(new[] { -11.5, 5.5, -9.6, 7.5, -11.7, 9.7, -7.6, 7.8, -5.5, 5.6 })));
            Assert.AreEqual("[1,4,7,1]", Util.ArrayToString(e.extractPinCode(new[] { 23.82, 5.41, 25.43, 5.77, 27.55, 5.59, 23.22, 5.22, 29.57, 5.3 })));
            Assert.AreEqual("[9,3,7,1]", Util.ArrayToString(e.extractPinCode(new[] { 195, 48, 191.1, 47.9, 194.8, 44.2, 193, 46, 196.9, 48.1, 190.9, 44.1, 197, 44 })));
            Assert.AreEqual("[5,5,8,9]", Util.ArrayToString(e.extractPinCode(new[] { -3.5, 1.55, -3.4, 2.45, -0.6, 2, -1.4, 4, 0.5, 0.5 })));
            Assert.AreEqual("[9,3,7,1]", Util.ArrayToString(e.extractPinCode(new[] { 195, 48, 191.1, 47.9, 194.8, 44.2, 193, 46, 196.9, 48.1, 196.9, 48.1, 194.8, 44.2, 190.9, 44.1, 197, 44 })));
            Assert.AreEqual("[4,7,4,5]", Util.ArrayToString(e.extractPinCode(new[] { 33.78, 34.93, 33.77, 37.32, 39.61, 37.45, 37.48, 35.8, 39.42, 37.02, 39.31, 36.94, 35.28, 33.48, 37.39, 33.51, 35.41, 33.41, 35.11, 35.06, 39.65, 33.58 })));
        }
    }
}