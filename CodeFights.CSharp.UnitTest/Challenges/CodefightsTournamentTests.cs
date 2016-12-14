using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class CodefightsTournamentTests
    {
        [TestMethod]
        public void codefightsTournamentTest()
        {
            var c = new CodefightsTournament();
            Assert.AreEqual("[2000,1000]", Util.ArrayToString(c.codefightsTournament(1, 500)));
            Assert.AreEqual("[1000,400]", Util.ArrayToString(c.codefightsTournament(2, 400)));
            Assert.AreEqual("[62,100]", Util.ArrayToString(c.codefightsTournament(6, 100)));
            Assert.AreEqual("[250,400]", Util.ArrayToString(c.codefightsTournament(4, 400)));
            Assert.AreEqual("[62,0]", Util.ArrayToString(c.codefightsTournament(6, 0)));
            Assert.AreEqual("[2000,400]", Util.ArrayToString(c.codefightsTournament(1, 200)));
        }
    }
}