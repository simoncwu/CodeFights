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
    public class ChangeOfVowelsInCycleTests
    {
        [TestMethod()]
        public void changeOfVowelsInCycleTest()
        {
            var c = new ChangeOfVowelsInCycle();
            Assert.AreEqual("ototap", c.changeOfVowelsInCycle(1, "potato"));
            Assert.AreEqual("itetip fo sa tsot soht", c.changeOfVowelsInCycle(3, "this test is of potato"));
            Assert.AreEqual("jj ea hh gg ff ai dd cc bb ie", c.changeOfVowelsInCycle(45, "aa bb cc dd ee ff gg hh ii jj"));
            Assert.AreEqual("cba", c.changeOfVowelsInCycle(1, "abc"));
            Assert.AreEqual("knaht otatip i sa cegum airt o", c.changeOfVowelsInCycle(350, "a true magic is a potato think"));
            Assert.AreEqual("sthgiFedoC", c.changeOfVowelsInCycle(9, "CodeFights"));
            Assert.AreEqual("ahj konY yknn uieEU nslFI elOnsl fjA", c.changeOfVowelsInCycle(10, "Ojf lsnelI UFlsn Eeiuo nnky Ynak jhA"));
            Assert.AreEqual("sexif elttel eirht davol ureht Omet o nepi ecne", c.changeOfVowelsInCycle(28, "Once upon a time there lived three little foxes"));
            Assert.AreEqual("yawe rif ,rof yxalag a na aga amit gnoL", c.changeOfVowelsInCycle(264, "Long time ago in a galaxy far, far away"));
            Assert.AreEqual("rh slwv N", c.changeOfVowelsInCycle(7, "N vwls hr"));
        }
    }
}