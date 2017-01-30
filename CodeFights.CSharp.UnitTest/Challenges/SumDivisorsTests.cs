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
    public class SumDivisorsTests
    {
        [TestMethod]
        public void sumDivisorsTest()
        {
            var s = new SumDivisors();
            Assert.AreEqual(13, s.sumDivisors(8));
            Assert.AreEqual(10, s.sumDivisors(9));
            Assert.AreEqual(55, s.sumDivisors(24));
            Assert.AreEqual(6540, s.sumDivisors(2016));
            Assert.AreEqual(1, s.sumDivisors(1979));
            Assert.AreEqual(1, s.sumDivisors(2017));
            Assert.AreEqual(24902273, s.sumDivisors(10000000));
            Assert.AreEqual(2015329770, s.sumDivisors(int.MaxValue / 2));
        }
    }
}