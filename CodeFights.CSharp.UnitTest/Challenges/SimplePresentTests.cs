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
    public class SimplePresentTests
    {
        [TestMethod()]
        public void simplePresentTest()
        {
            var s = new SimplePresent();
            Assert.AreEqual("I like this", s.simplePresent(new[] { "I", "like", "this" }));
            Assert.AreEqual("It is awesome", s.simplePresent(new[] { "It", "be", "awesome" }));
            Assert.AreEqual("We love coding", s.simplePresent(new[] { "We", "love", "coding" }));
            Assert.AreEqual("I am a CodeFighter", s.simplePresent(new[] { "I", "be", "a CodeFighter" }));
            Assert.AreEqual("Julia is a mathematician", s.simplePresent(new[] { "Julia", "be", "a mathematician" }));
            Assert.AreEqual("Tests are examples", s.simplePresent(new[] { "Tests", "be", "examples" }));
            Assert.AreEqual("He and I share the name", s.simplePresent(new[] { "He and I", "share", "the name" }));
            Assert.AreEqual("Things go well", s.simplePresent(new[] { "Things", "go", "well" }));
            Assert.AreEqual("Macho loves Pokemon", s.simplePresent(new[] { "Macho", "love", "Pokemon" }));
            Assert.AreEqual("This pen and that book are from the same store", s.simplePresent(new[] { "This pen and that book", "be", "from the same store" }));
            Assert.AreEqual("Mike is better", s.simplePresent(new[] { "Mike", "be", "better" }));
        }
    }
}