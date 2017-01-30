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
    public class HelpingBobTests
    {
        [TestMethod()]
        public void helpingBobTest()
        {
            var h = new HelpingBob();
            Assert.AreEqual("VHHVV", h.helpingBob(2, 3, 4));
            Assert.AreEqual("HVVH", h.helpingBob(2, 2, 2));
            Assert.AreEqual("VHHVH", h.helpingBob(3, 2, 7));
            Assert.AreEqual("VHHVV", h.helpingBob(2, 3, 4));
            Assert.AreEqual("VVVVVVV", h.helpingBob(0, 7, 0));
            Assert.AreEqual("HVHHHVH", h.helpingBob(5, 2, 11));
            Assert.AreEqual("HVHHVVH", h.helpingBob(4, 3, 12));
            Assert.AreEqual("VVVHVV", h.helpingBob(1, 5, 3));
            Assert.AreEqual("VHHVVHHHV", h.helpingBob(5, 4, 86));
            Assert.AreEqual("VVVVVVVVVVHHHHHHHHHH", h.helpingBob(10, 10, 184755));
            Assert.AreEqual("HHHHHHHHHHVVVVVVVVVV", h.helpingBob(10, 10, 0));
        }
    }
}