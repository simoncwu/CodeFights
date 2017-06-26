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
    public class ReverseInverseTests
    {
        [TestMethod()]
        public void reverseInverseTest()
        {
            var r = new ReverseInverse();
            Assert.AreEqual("oS, TAHW SI sTHGiFEDOC?", r.reverseInverse("So, what is CodeFights?"));
            Assert.AreEqual("yEH, tAHW'S pU!", r.reverseInverse("Hey, What's Up!"));
            Assert.AreEqual("tSRIF NOITSEUQ: wOH OD sTOBeDOC KROW?", r.reverseInverse("First question: How do CodeBots work?"));
            Assert.AreEqual("sLEVEL DNA px YALP A YEK ELOR NI sTHGiFEDOC DNA YEHT HTOB ERA YLTHGIT DETALERROC. eREH'S WOH TI LLA SKROW:", r.reverseInverse("Levels and XP play a key role in CodeFights and they both are tightly correlated. Here's how it all works:"));
            Assert.AreEqual("gNINRAE eCNEIREPXE sTNIOP (px) SI TAHW SEVIRD RUOY LEVEL PU.", r.reverseInverse("Earning Experience Points (XP) is what drives your level up."));
            Assert.AreEqual("3 SYAD OT OG. tEG RUOY 001 SEGAMI ROF $001.", r.reverseInverse("3 days to go. Get your 100 images for $100."));
        }
    }
}