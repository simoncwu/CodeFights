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
    public class Alpha5Tests
    {
        [TestMethod]
        public void alpha5Test()
        {
            var a = new Alpha5();
            Assert.AreEqual('A', a.alpha5("aaaaa"));
            Assert.AreEqual('C', a.alpha5("caaaa"));
            Assert.AreEqual('C', a.alpha5("ababa"));
            Assert.AreEqual('K', a.alpha5("abcde"));
            Assert.AreEqual('A', a.alpha5("baaaz"));
            Assert.AreEqual('C', a.alpha5("codef"));
            Assert.AreEqual('C', a.alpha5("about"));
            Assert.AreEqual('B', a.alpha5("phone"));
            Assert.AreEqual('I', a.alpha5("music"));
            Assert.AreEqual('Z', a.alpha5("demos"));
            Assert.AreEqual('H', a.alpha5("yahoo"));
        }
    }
}