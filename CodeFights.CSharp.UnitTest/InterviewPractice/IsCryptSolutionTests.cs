using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class IsCryptSolutionTests
    {
        [TestMethod()]
        public void isCryptSolutionTest()
        {
            var i = new IsCryptSolution();
            Assert.IsTrue(i.isCryptSolution("SEND MORE MONEY".Split(), "O0 M1 Y2 E5 N6 D7 R8 S9".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("TEN TWO ONE".Split(), "O1 T0 W9 E5 N4".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsTrue(i.isCryptSolution("ONE ONE TWO".Split(), "O2 T4 W6 E1 N3".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("ONE ONE TWO".Split(), "O0 T1 W2 E5 N6".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsTrue(i.isCryptSolution("A A A".Split(), "A0".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("A B C".Split(), "A5 B6 C1".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("AA AA AA".Split(), "A0".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("A A A".Split(), "A1".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsTrue(i.isCryptSolution("AA AA BB".Split(), "A1 B2".Split().Select(_ => _.ToArray()).ToArray()));
            Assert.IsFalse(i.isCryptSolution("BAA CAB DAB".Split(), "A0 B1 C2 D4".Split().Select(_ => _.ToArray()).ToArray()));
        }
    }
}