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
    public class SortItTests
    {
        [TestMethod]
        public void sortItTest()
        {
            var s = new SortIt();
            Assert.AreEqual("aabhiVv", s.sortIt("Vaibhav"));
            Assert.AreEqual("CEilmoPr", s.sortIt("ComPilEr"));
            Assert.AreEqual("AAaaaBbCcDEe", s.sortIt("AbCcBAaaDaEe"));
            Assert.AreEqual("Z", s.sortIt("Z"));
        }
    }
}