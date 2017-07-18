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
    public class NewYearCodeFightsHackingChallengeTests
    {
        [TestMethod]
        public void NewYearCodeFightsHackingTest()
        {
            var n = new NewYearCodeFightsHackingChallenge();
            Assert.AreEqual(8, n.NewYearCodeFightsHacking(2, "codecode"));
            Assert.AreEqual(22, n.NewYearCodeFightsHacking(2, "happynewyear"));
            Assert.AreEqual(7, n.NewYearCodeFightsHacking(1, "pfml"));
            Assert.AreEqual(-1, n.NewYearCodeFightsHacking(1, "itisnotreal"));
            Assert.AreEqual(10, n.NewYearCodeFightsHacking(10, "uslada"));
            Assert.AreEqual(15, n.NewYearCodeFightsHacking(5, "peltorator"));
            Assert.AreEqual(23, n.NewYearCodeFightsHacking(10, "schooltwothreenine"));
            Assert.AreEqual(21, n.NewYearCodeFightsHacking(27, "isaftwentyseven"));
            Assert.AreEqual(30, n.NewYearCodeFightsHacking(20, "ohfcsfttdfiiohooidhgofdeddogti"));
            Assert.AreEqual(30, n.NewYearCodeFightsHacking(20, "hgotsdhsifeodeefooethfdhhseost"));
            Assert.AreEqual(29, n.NewYearCodeFightsHacking(20, "gicdtgcdftgicsccgoetseffgcggt"));
            Assert.AreEqual(194, n.NewYearCodeFightsHacking(10, "fsgehttdsoeistfchgegoifdcshehdgcogihifodccofgchohhhheeisstotdggcetcodicsfhteiodcogfcgotstfofesttcthh"));
            Assert.AreEqual(9, n.NewYearCodeFightsHacking(1, "eodeod"));
            Assert.AreEqual(12, n.NewYearCodeFightsHacking(1, "ddraiiv"));
            Assert.AreEqual(195, n.NewYearCodeFightsHacking(10, "estsessyeoeoscpsdpscocsdceeppdettstsoeopoesseooyysypooccoocdpyscocypeeyoydocydytyocptoydtdectcepdcco"));
            Assert.AreEqual(-1, n.NewYearCodeFightsHacking(9, "sltrdfocdclfrfttddddoltffdfdtcfotrcsclrsslcfcfosorffolcfsldfltscflrctcoscoltolcloosoccsflsc"));
        }
    }
}