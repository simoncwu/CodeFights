using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class CountPathsThroughCellTests
    {
        [TestMethod]
        public void countPathsThroughCellTest()
        {
            var c = new CountPathsThroughCell();
            Assert.AreEqual(4, c.countPathsThroughCell(3, 3, 1, 1));
            Assert.AreEqual(1, c.countPathsThroughCell(1, 10, 0, 9));
            Assert.AreEqual(3, c.countPathsThroughCell(5, 2, 2, 0));
        }
    }
}