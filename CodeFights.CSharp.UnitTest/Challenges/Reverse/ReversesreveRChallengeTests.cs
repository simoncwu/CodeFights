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
    public class ReversesreveRChallengeTests
    {
        [TestMethod()]
        public void ReversesreveRTest()
        {
            var r = new ReversesreveRChallenge();
            Assert.AreEqual(43, r.ReversesreveR("23+11"));
            Assert.AreEqual(100, r.ReversesreveR("90+19"));
            Assert.AreEqual(2, r.ReversesreveR("1+1"));
            Assert.AreEqual(4096, r.ReversesreveR("80^40"));
            Assert.AreEqual(47, r.ReversesreveR("16-41"));
            Assert.AreEqual(10, r.ReversesreveR("9+10"));
            Assert.AreEqual(35, r.ReversesreveR("513/90"));
            Assert.AreEqual(60, r.ReversesreveR("5*21"));
            Assert.AreEqual(2, r.ReversesreveR("21%5"));
            Assert.AreEqual(144, r.ReversesreveR("21^2"));
            Assert.AreEqual(169, r.ReversesreveR("31^2"));
        }
    }
}