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
    public class EightTailorsTests
    {
        [TestMethod()]
        public void eightTailorsTest()
        {
            var e = new EightTailors();
            Assert.AreEqual(65520, e.eightTailors(0));
            Assert.AreEqual(0, e.eightTailors(1));
            Assert.AreEqual(0, e.eightTailors(1));
            Assert.AreEqual(0, e.eightTailors(2));
            Assert.AreEqual(0, e.eightTailors(3));
            Assert.AreEqual(0, e.eightTailors(5));
            Assert.AreEqual(0, e.eightTailors(8));
            Assert.AreEqual(0, e.eightTailors(13));
            Assert.AreEqual(0, e.eightTailors(21));
            Assert.AreEqual(102284339877720, e.eightTailors(-50));
        }
    }
}