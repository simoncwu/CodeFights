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
    public class FindTheFormulaTests
    {
        [TestMethod()]
        public void findTheFormulaTest()
        {
            var f = new FindTheFormula();
            Assert.AreEqual("n+1", f.findTheFormula(new[] { 7, 8, 9 }));
            Assert.AreEqual("14n", f.findTheFormula(new[] { 14, 196, 2744 }));
            Assert.AreEqual("-n", f.findTheFormula(new[] { 15, -15, 15 }));
            Assert.AreEqual("2n-3", f.findTheFormula(new[] { 1, -1, -5 }));
            Assert.AreEqual("100n-1", f.findTheFormula(new[] { 99, 9899, 989899 }));
            Assert.AreEqual("-3n", f.findTheFormula(new[] { 3, -9, 27 }));
            Assert.AreEqual("4n+3", f.findTheFormula(new[] { 2, 11, 47 }));
        }
    }
}