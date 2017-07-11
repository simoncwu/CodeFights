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
    public class OneLeftTests
    {
        [TestMethod()]
        public void oneLeftTest()
        {
            var o = new OneLeft();
            Assert.AreEqual("vvv", o.oneLeft("bbb"));
            Assert.AreEqual("ccc", o.oneLeft("vvv"));
            Assert.AreEqual("fff", o.oneLeft("ggg"));
            Assert.AreEqual("lvx", o.oneLeft("abc"));
            Assert.AreEqual("p", o.oneLeft("q"));
            Assert.AreEqual("gh", o.oneLeft("hj"));
        }
    }
}