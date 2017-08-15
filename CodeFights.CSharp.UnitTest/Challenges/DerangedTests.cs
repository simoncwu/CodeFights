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
    public class DerangedTests
    {
        [TestMethod()]
        public void derangedTest()
        {
            var d = new Deranged();
            Assert.AreEqual(2, d.deranged(3));
            Assert.AreEqual(0, d.deranged(1));
            Assert.AreEqual(9, d.deranged(4));
            Assert.AreEqual(133496, d.deranged(9));
            Assert.AreEqual(1334961, d.deranged(10));
            Assert.AreEqual(1, d.deranged(2));
            Assert.AreEqual(44, d.deranged(5));
            Assert.AreEqual(265, d.deranged(6));
            Assert.AreEqual(1854, d.deranged(7));
            Assert.AreEqual(14833, d.deranged(8));
        }
    }
}