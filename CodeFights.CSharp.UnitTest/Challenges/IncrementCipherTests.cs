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
    public class IncrementCipherTests
    {
        [TestMethod()]
        public void incrementCipherTest()
        {
            var i = new IncrementCipher();
            Assert.AreEqual("bde", i.incrementCipher("abc", new[] { 1, 2, 3 }));
            Assert.AreEqual("dpefgjhiut", i.incrementCipher("codefights", new[] { 1 }));
            Assert.AreEqual("zazbzbzbza", i.incrementCipher("zzzzzzzzzz", new[] { 2, 4, 6 }));
            Assert.AreEqual("uguvjqh", i.incrementCipher("testing", new[] { 1, 2, 3 }));
            Assert.AreEqual("htkj", i.incrementCipher("htkj", new[] { 7 }));
        }
    }
}