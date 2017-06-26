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
    public class ReverseChallengeTests
    {
        [TestMethod()]
        public void reverseChallengeTest()
        {
            var r = new ReverseChallenge();
            Assert.AreEqual("hgstruvwlx", r.reverseChallenge("codefights"));
            Assert.AreEqual("ghvg zh r hrsg", r.reverseChallenge("this is a test"));
            Assert.AreEqual("viv sgbvs", r.reverseChallenge("hey there"));
            Assert.AreEqual("hrsg sgrd vnrg wllt vezs", r.reverseChallenge("have good time with this"));
            Assert.AreEqual("", r.reverseChallenge(""));
            Assert.AreEqual(" vtmvoozsx ", r.reverseChallenge(" challenge "));
            Assert.AreEqual("loovs", r.reverseChallenge("hello"));
            Assert.AreEqual("vnlhvdz", r.reverseChallenge("awesome"));
            Assert.AreEqual("zz zz       z    zz  ", r.reverseChallenge("aa aa       a    aa  "));
         }
    }
}