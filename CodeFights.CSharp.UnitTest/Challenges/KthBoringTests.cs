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
    public class KthBoringTests
    {
        [TestMethod()]
        public void kthBoringTest()
        {
            var k = new KthBoring();
            Assert.AreEqual(4, k.kthBoring(1));
            Assert.AreEqual(6, k.kthBoring(2));
            Assert.AreEqual(9, k.kthBoring(3));
            Assert.AreEqual(12, k.kthBoring(5));
            Assert.AreEqual(14, k.kthBoring(6));
            Assert.AreEqual(20, k.kthBoring(10));
            Assert.AreEqual(22, k.kthBoring(11));
            Assert.AreEqual(26, k.kthBoring(14));
            Assert.AreEqual(30, k.kthBoring(17));
        }
    }
}