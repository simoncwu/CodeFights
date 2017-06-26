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
    public class HelpingStephanTests
    {
        [TestMethod()]
        public void helpingStephanTest()
        {
            var h = new HelpingStephan();
            Assert.IsTrue(Math.Abs(2.4 - h.helpingStephan(2.4, 4.8)) < 1e-5);
            Assert.IsTrue(Math.Abs(0.01 - h.helpingStephan(36.21, 4.19)) < 1e-5);
            Assert.IsTrue(Math.Abs(2 - h.helpingStephan(4, 6)) < 1e-5);
            Assert.IsTrue(Math.Abs(0.003 - h.helpingStephan(2.43, 4.899)) < 1e-5);
            Assert.IsTrue(Math.Abs(0.0001 - h.helpingStephan(47.804, 11.8683)) < 1e-5);
            Assert.IsTrue(Math.Abs(1.91952 - h.helpingStephan(17.27568, 49.90752)) < 1e-5);
            Assert.IsTrue(Math.Abs(11.07364 - h.helpingStephan(22.14728, 11.07364)) < 1e-5);
        }
    }
}