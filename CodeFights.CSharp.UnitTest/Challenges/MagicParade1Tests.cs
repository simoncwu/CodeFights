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
    public class MagicParade1Tests
    {
        [TestMethod()]
        public void magicParade_1Test()
        {
            var m = new MagicParade1();
            Assert.IsFalse(m.magicParade_1(1, 0, 2));
            Assert.IsTrue(m.magicParade_1(1, 0, 1));
            Assert.IsTrue(m.magicParade_1(0, 4, 2));
            Assert.IsFalse(m.magicParade_1(0, 5, 1));
            Assert.IsTrue(m.magicParade_1(1, 5, 1));
            Assert.IsFalse(m.magicParade_1(0, 0, 0));
            Assert.IsTrue(m.magicParade_1(5, 25, 4));
            Assert.IsFalse(m.magicParade_1(20, 20, 22));
            Assert.IsTrue(m.magicParade_1(100000000, 100000000, 100000000));
            Assert.IsFalse(m.magicParade_1(5, 38, 10));
            Assert.IsTrue(m.magicParade_1(3, 21, 5));
            Assert.IsTrue(m.magicParade_1(0, 0, 1));
            Assert.IsFalse(m.magicParade_1(10000000, 100000000, 10000000));
            Assert.IsFalse(m.magicParade_1(10000000, 10000000, 100000000));
            Assert.IsTrue(m.magicParade_1(10000000, 50000000, 10000000));
            Assert.IsTrue(m.magicParade_1(1, 0, 0));
            Assert.IsFalse(m.magicParade_1(1, 1, 3));
        }
    }
}