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
    public class SwitchDemSignsTests
    {
        [TestMethod]
        public void switchDemSignsTest()
        {
            var s = new SwitchDemSigns();
            Assert.AreEqual("- a - b + (c + d - {e})", s.switchDemSigns("a + b - (c + d - {e})"));
            Assert.AreEqual("- a - (b + c - (p - q) + (z - x - {r})) - f", s.switchDemSigns("a + (b + c - (p - q) + (z - x - {r})) + f"));
            Assert.AreEqual("- a - a - a + a - (a) + (a + {a + [a] + (a) + a}) + a", s.switchDemSigns("a + a + a - a + (a) - (a + {a + [a] + (a) + a}) - a"));
            Assert.AreEqual("+ a + b - (c + d - {e})", s.switchDemSigns("- a - b + (c + d - {e})"));
            Assert.AreEqual("- {varA - varB} - [varC - varD]", s.switchDemSigns("{varA - varB} + [varC - varD]"));
        }
    }
}