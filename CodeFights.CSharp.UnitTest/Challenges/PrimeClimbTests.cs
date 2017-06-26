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
    public class PrimeClimbTests
    {
        [TestMethod()]
        public void primeClimbTest()
        {
            var p = new PrimeClimb();
            Assert.AreEqual("2235", p.primeClimb(60));
            Assert.AreEqual("225", p.primeClimb(20));
            Assert.AreEqual("2", p.primeClimb(2));
            Assert.AreEqual("237", p.primeClimb(42));
            Assert.AreEqual("97127", p.primeClimb(12319));
            Assert.AreEqual("314", p.primeClimb(4782969));
            Assert.AreEqual("314", p.primeClimb(923521));
            Assert.AreEqual("101227661", p.primeClimb(15154747));
            Assert.AreEqual("232536073803", p.primeClimb(1234567890));
            Assert.AreEqual("237111317192329", p.primeClimb(1293938646));
            Assert.AreEqual("463372", p.primeClimb(2147117569));
            Assert.AreEqual("4632746349", p.primeClimb(2147210123));
            Assert.AreEqual("2147483647", p.primeClimb(2147483647));
        }
    }
}