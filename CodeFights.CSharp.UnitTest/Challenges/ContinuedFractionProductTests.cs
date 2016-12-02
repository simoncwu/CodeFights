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
    public class ContinuedFractionProductTests
    {
        [TestMethod]
        public void CFPTest()
        {
            Assert.AreEqual(36, new ContinuedFractionProduct().CFP(new[] { 2, 4 }));
            Assert.AreEqual(137903, new ContinuedFractionProduct().CFP(new[] { 2, 2, 2, 2, 2, 2, 3 }));
            Assert.AreEqual(528601, new ContinuedFractionProduct().CFP(new[] { 1, 1, 1, 1, 2, 1, 1, 1, 1, 11 }));
            Assert.AreEqual(14921, new ContinuedFractionProduct().CFP(new[] { 8, 14, 3 }));
            Assert.AreEqual(807791, new ContinuedFractionProduct().CFP(new[] { 0, 1, 9, 13, 2, 3 }));
        }
    }
}