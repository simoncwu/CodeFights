using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void triangle_Test()
        {
            var t = new Triangle();
            Assert.IsTrue(t.triangle_(.6, .5, .6));
            Assert.IsTrue(t.triangle_(5, 2.5, 4));
            Assert.IsFalse(t.triangle_(8, 4, 2));
            Assert.IsFalse(t.triangle_(5.65, 3.3, 2.35));
            Assert.IsTrue(t.triangle_(7521, 4444, 8012.1));
        }
    }
}