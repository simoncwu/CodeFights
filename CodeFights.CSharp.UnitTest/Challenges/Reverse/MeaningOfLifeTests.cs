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
    public class MeaningOfLifeTests
    {
        [TestMethod()]
        public void meaningOfLifeTest()
        {
            var m = new MeaningOfLife();
            Assert.AreEqual(1, m.meaningOfLife("1"));
            Assert.AreEqual(12, m.meaningOfLife("C"));
            Assert.AreEqual(38, m.meaningOfLife("c"));
            Assert.AreEqual(52, m.meaningOfLife("1A"));
            Assert.AreEqual(1764, m.meaningOfLife("100"));
            Assert.AreEqual(41, m.meaningOfLife("f"));
            Assert.AreEqual(42, m.meaningOfLife("10"));
            Assert.AreEqual(18114, m.meaningOfLife("ABC"));
            Assert.AreEqual(65096, m.meaningOfLife("abc"));
            Assert.AreEqual(111487939, m.meaningOfLife("ZYXWV"));
        }
    }
}