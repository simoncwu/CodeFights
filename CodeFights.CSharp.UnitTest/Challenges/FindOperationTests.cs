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
    public class FindOperationTests
    {
        [TestMethod]
        public void FindOperation()
        {
            var f = new FindOperation();
            Assert.AreEqual("0 + 8 - 1 + 90 - 45", f.findOperation(new[] { 0, 8, 1, 90, 45 }, 52));
        }
    }
}