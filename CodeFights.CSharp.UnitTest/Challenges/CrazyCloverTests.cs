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
    public class CrazyCloverTests
    {
        [TestMethod()]
        public void crazyCloverTest()
        {
            var c = new CrazyClover();
            Assert.IsFalse(c.crazyClover("2075134854075614008885732002623615"));
            Assert.IsTrue(c.crazyClover("32565527543186766526240463003010854254680"));
            Assert.IsFalse(c.crazyClover("401832156234145108764838856820514082736247538"));
            Assert.IsFalse(c.crazyClover("342127100836312007166676508351877542003"));
            Assert.IsTrue(c.crazyClover("234612805261785725074711387427183280224"));
            Assert.IsFalse(c.crazyClover("10"));
            Assert.IsFalse(c.crazyClover("473720144341612328121"));
            Assert.IsTrue(c.crazyClover("5633082822646212802584300238526144484"));
            Assert.IsTrue(c.crazyClover("5633082822646212802584300238526144484"));
            Assert.IsFalse(c.crazyClover("2"));
            Assert.IsFalse(c.crazyClover("207260632267345853470771241607526106472355134854075614008885732002623615"));
        }
    }
}