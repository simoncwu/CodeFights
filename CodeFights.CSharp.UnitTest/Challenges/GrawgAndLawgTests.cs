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
    public class GrawgAndLawgTests
    {
        [TestMethod()]
        public void grawgAndLawgTest()
        {
            var g = new GrawgAndLawg();
            Assert.IsTrue(new[] {
                "~o>== ------£",
                "Ǝ--------------- ==<o~"
            }.SequenceEqual(g.grawgAndLawg(new[] {
                "TFS6",
                "T3TFB15NFCFFFCNMGLLGFLTTMGTSTT"
            })));
            Assert.IsTrue(new[] {
                "≡≡≡≡E"
            }.SequenceEqual(g.grawgAndLawg(new[] {
                "4GN"
            })));
            Assert.IsTrue(new[] {
                "≡≡≡≡≡≡E",
                "----£"
            }.SequenceEqual(g.grawgAndLawg(new[] {
               "FSN4G6",
                "NG4FS"
            })));
            Assert.IsTrue(new[] {
                "~o>== ≡≡≡≡≡F",
                "≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡≡E",
                "Ǝ===== ==<o~"
            }.SequenceEqual(g.grawgAndLawg(new[] {
               "NLFCTTSMGTMMSMSMGTTTTTTT234T5C",
                "CFFFCFLCNGGGMMSSG34",
                "TTTTTTTTTTTTTT4LLLLLLL5MT"
            })));
        }
    }
}