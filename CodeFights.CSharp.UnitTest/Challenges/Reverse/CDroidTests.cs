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
    public class CDroidTests
    {
        [TestMethod()]
        public void cDroidTest()
        {
            var c = new CDroid();
            Assert.AreEqual("1.0000", c.cDroid(new[] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 0 } }));
            Assert.AreEqual("1.4142", c.cDroid(new[] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 1 } }));
            Assert.AreEqual("1.0000", c.cDroid(new[] { new[] { 0, -1 }, new[] { -1, 0 }, new[] { -1, 0 } }));
            Assert.AreEqual("1.4142", c.cDroid(new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }));
            Assert.AreEqual("0.0000", c.cDroid(new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }));
            Assert.AreEqual("64.4981", c.cDroid(new[] { new[] { 47, 40 }, new[] { 56, 35 }, new[] { 65, 20 } }));
            Assert.AreEqual("6.7082", c.cDroid(new[] { new[] { -7, -2 }, new[] { -4, -2 }, new[] { -8, -6 } }));
            Assert.AreEqual("31.9061", c.cDroid(new[] { new[] { 27, 17 }, new[] { 27, 17 }, new[] { 27, 17 } }));
        }
    }
}