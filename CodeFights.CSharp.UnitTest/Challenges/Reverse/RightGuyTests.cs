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
    public class RightGuyTests
    {
        [TestMethod()]
        public void rightGuyTest()
        {
            var r = new RightGuy();
            Assert.AreEqual(1, r.rightGuy(1));
            Assert.AreEqual(2, r.rightGuy(2));
            Assert.AreEqual(1, r.rightGuy(23));
            Assert.AreEqual(3, r.rightGuy(100));
            Assert.AreEqual(2, r.rightGuy(234));
            Assert.AreEqual(31, r.rightGuy(1073741824));
            Assert.AreEqual(0, r.rightGuy(0));
        }
    }
}