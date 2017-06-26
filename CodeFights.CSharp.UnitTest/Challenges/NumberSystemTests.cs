using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class NumberSystemTests
    {
        [TestMethod()]
        public void numberSystemTest()
        {
            var n = new NumberSystem();
            Assert.AreEqual("233", n.numberSystem(new[] { 2, 3 }, 10));
            Assert.AreEqual("3003", n.numberSystem(new[] { 0, 3 }, 10));
            Assert.AreEqual("99", n.numberSystem(new[] { 3, 6, 9 }, 12));
            Assert.AreEqual("13", n.numberSystem(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 12));
            Assert.AreEqual("47788878774888", n.numberSystem(new[] { 4, 7, 8 }, 3274653));
            Assert.AreEqual("6777773700344", n.numberSystem(new[] { 0, 3, 4, 6, 7 }, 976512538));
            Assert.AreEqual("482288408808484", n.numberSystem(new[] { 0, 2, 4, 8 }, 763247855));
            Assert.AreEqual("0", n.numberSystem(new[] { 0, 6 }, 1));
        }
    }
}