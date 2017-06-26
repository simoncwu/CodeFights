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
    public class ModuloHarshadTests
    {
        [TestMethod()]
        public void moduloHarshadTest()
        {
            var m = new ModuloHarshad();
            Assert.AreEqual(6, m.moduloHarshad(12, 20));
            Assert.AreEqual(0, m.moduloHarshad(1, 5));
            Assert.AreEqual(158, m.moduloHarshad(100, 200));
            Assert.AreEqual(270, m.moduloHarshad(1979, 2017));
            Assert.AreEqual(0, m.moduloHarshad(2, 2017));
            Assert.AreEqual(12432, m.moduloHarshad(2017, 1985));
        }
    }
}