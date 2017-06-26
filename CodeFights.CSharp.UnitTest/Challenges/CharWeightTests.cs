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
    public class CharWeightTests
    {
        [TestMethod()]
        public void charWeightTest()
        {
            var c = new CharWeight();
            Assert.AreEqual("c{1}d{1}e{1}f{1}g{1}h{1}i{1}o{1}s{1}t{1}", c.charWeight("codefights"));
            Assert.AreEqual("g{2}o{2}e{1}l{1}", c.charWeight("google"));
            Assert.AreEqual("a{1}", c.charWeight("a"));
            Assert.AreEqual("o{2}a{1}h{1}y{1}", c.charWeight("yahoo"));
            Assert.AreEqual("c{3}a{2}b{2}", c.charWeight("bbaaccc"));
            Assert.AreEqual("1{4}a{4}z{4}", c.charWeight("1aa1zz1aa1zz"));
            Assert.AreEqual("1{3}a{3}d{2}0{1}2{1}4{1}6{1}7{1}8{1}9{1}b{1}c{1}e{1}f{1}s{1}", c.charWeight("1abc10DefA7892164aSd"));
            Assert.AreEqual("e{13}r{7}o{5}t{5}a{4}b{3}n{3}p{3}u{3}h{2}l{2}s{2}w{2}y{2}c{1}d{1}i{1}j{1}k{1}m{1}v{1}", c.charWeight("TheobjectwhoseenumerableownpropertykeyValuepairsAretobereturned"));
        }
    }
}