using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class BuildSumTests
    {
        [TestMethod()]
        public void buildSumTest()
        {
            var b = new BuildSum();
            Assert.AreEqual(1, b.buildSum(0));
            Assert.AreEqual(2, b.buildSum(1));
            Assert.AreEqual(33, b.buildSum(3));
            Assert.AreEqual(6, b.buildSum(2));
            Assert.AreEqual(405071318, b.buildSum(9));
        }
    }
}