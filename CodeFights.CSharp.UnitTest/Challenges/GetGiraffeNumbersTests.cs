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
    public class GetGiraffeNumbersTests
    {
        [TestMethod()]
        public void getGiraffeNumbersTest()
        {
            var g = new GetGiraffeNumbers();
            Assert.AreEqual(19, g.getGiraffeNumbers("20"));
            Assert.AreEqual(55, g.getGiraffeNumbers("100"));
            Assert.AreEqual(220, g.getGiraffeNumbers("1000"));
            Assert.AreEqual(7, g.getGiraffeNumbers("7"));
            Assert.AreEqual(714, g.getGiraffeNumbers("9999"));
            Assert.AreEqual(1087370, g.getGiraffeNumbers("123456789101112"));
            Assert.AreEqual(258552150, g.getGiraffeNumbers("1234567891011121314151617181920"));
            Assert.AreEqual(12196604061069, g.getGiraffeNumbers("99999399999423423423456799999892342342234234234233429999993499999999999999999999999999999999999999999999999999999"));
            Assert.AreEqual(3784, g.getGiraffeNumbers("235709"));
            Assert.AreEqual(55, g.getGiraffeNumbers("102"));
        }
    }
}