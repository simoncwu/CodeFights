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
    public class ShortenNameChallengeTests
    {
        [TestMethod]
        public void ShortenNameTest()
        {
            var s = new ShortenNameChallenge();
            Assert.AreEqual("Placedo, Silver V.", s.ShortenName("Placedo, Silver Van"));
            Assert.AreEqual("Aguilar, Ventura", s.ShortenName("Aguilar, Ventura"));
            Assert.AreEqual("Antonio, Rose Marie G.", s.ShortenName("Antonio, Rose Marie Ginebra"));
            Assert.AreEqual("Daenerys Stormborn of the House Targaryen, First of Her N.", s.ShortenName("Daenerys Stormborn of the House Targaryen, First of Her Name"));
            Assert.AreEqual("Alice, Mooore", s.ShortenName("Alice, Mooore"));
        }
    }
}