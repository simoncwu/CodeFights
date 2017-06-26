using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class ToBeContinuedTests
    {
        [TestMethod()]
        public void toBeContinuedTest()
        {
            var t = new ToBeContinued();
            Assert.AreEqual("[1]", Util.ArrayToString(t.toBeContinued(new[] { 1, 1 })));
            Assert.AreEqual("[2]", Util.ArrayToString(t.toBeContinued(new[] { 2, 1 })));
            Assert.AreEqual("[]", Util.ArrayToString(t.toBeContinued(new[] { 0, 0 })));
            Assert.AreEqual("[]", Util.ArrayToString(t.toBeContinued(new[] { 1, 0 })));
            Assert.AreEqual("[0]", Util.ArrayToString(t.toBeContinued(new[] { 0, 1 })));
            Assert.AreEqual("[1,2]", Util.ArrayToString(t.toBeContinued(new[] { 3, 2 })));
            Assert.AreEqual("[2,2]", Util.ArrayToString(t.toBeContinued(new[] { 5, 2 })));
            Assert.AreEqual("[0]", Util.ArrayToString(t.toBeContinued(new[] { 0, 5 })));
            Assert.AreEqual("[]", Util.ArrayToString(t.toBeContinued(new[] { 5, 0 })));
            Assert.AreEqual("[1,1,1,1,1,2]", Util.ArrayToString(t.toBeContinued(new[] { 21, 13 })));
            Assert.AreEqual("[3,1,1,2]", Util.ArrayToString(t.toBeContinued(new[] { 18, 5 })));
            Assert.AreEqual("[0,1,1,32,31]", Util.ArrayToString(t.toBeContinued(new[] { 1024, 2017 })));
            Assert.AreEqual("[0,1,1,1,1,1,1,1,1,2]", Util.ArrayToString(t.toBeContinued(new[] { 55, 89 })));
            Assert.AreEqual("[1,2,1,1,2,5,1,2,1,253,5,2]", Util.ArrayToString(t.toBeContinued(new[] { 1234567, 891011 })));
            Assert.AreEqual("[83,2,3,1,2]", Util.ArrayToString(t.toBeContinued(new[] { 2086, 25 })));
        }
    }
}