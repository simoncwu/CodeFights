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
    public class MaxVassalTests
    {
        [TestMethod()]
        public void maxVassalTest()
        {
            var m = new MaxVassal();
            Assert.AreEqual(3, m.maxVassal(42));
            Assert.AreEqual(5, m.maxVassal(130));
            Assert.AreEqual(9, m.maxVassal(810));
            Assert.AreEqual(12, m.maxVassal(1732));
        }
    }
}