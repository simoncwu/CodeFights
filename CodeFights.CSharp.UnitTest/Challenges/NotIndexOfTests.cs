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
    public class NotIndexOfTests
    {
        [TestMethod()]
        public void notIndexOfTest()
        {
            var n = new NotIndexOf();
            Assert.AreEqual(2, n.notIndexOf("Welcome to CodeFights!", "Back to school"));
            Assert.AreEqual(-1, n.notIndexOf("Zoo", "oo"));
            Assert.AreEqual(10, n.notIndexOf("Oh, some strange char", "0,sm tag h"));
            Assert.AreEqual(-1, n.notIndexOf("Oh, some strange char", "0,sm tag hr"));
            Assert.AreEqual(-1, n.notIndexOf("abc", "abc"));
            Assert.AreEqual(38, n.notIndexOf("The indexOf method returns the position of the first occurrence of a specified value in a string.", "Teidxfmto eun h oiino h is curneo"));
        }
    }
}