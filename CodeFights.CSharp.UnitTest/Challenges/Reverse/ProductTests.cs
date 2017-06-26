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
    public class ProductTests
    {
        [TestMethod()]
        public void productTest()
        {
            var p = new Product();
            Assert.AreEqual(0, p.product("g"));
            Assert.AreEqual(0, p.product("k"));
            Assert.AreEqual(1, p.product("pq"));
            Assert.AreEqual(1, p.product("lol"));
            Assert.AreEqual(4, p.product("test"));
            Assert.AreEqual(9, p.product("abcdef"));
            Assert.AreEqual(36, p.product("abcmmmmmmmmm"));
            Assert.AreEqual(81, p.product("abccfghjnmkjtdefty"));
            Assert.AreEqual(1, p.product("gwn"));
            Assert.AreEqual(25, p.product("ndxbvkrykoo"));
        }
    }
}