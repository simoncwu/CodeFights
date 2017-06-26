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
    public class RobotFunctionTests
    {
        [TestMethod]
        public void robotFunctionTest()
        {
            var r = new RobotFunction();
            Assert.AreEqual(8, r.robotFunction(3, 5));
            Assert.AreEqual(12, r.robotFunction(9, 10));
            Assert.AreEqual(13, r.robotFunction(6, 8));
            Assert.AreEqual(1593, r.robotFunction(1, 100));
            Assert.AreEqual(2801, r.robotFunction(100, 200));
            Assert.AreEqual(3601, r.robotFunction(239, 344));
            Assert.AreEqual(178377796, r.robotFunction(1, 1000000));
            Assert.AreEqual(189792020, r.robotFunction(30, 1048575));
            Assert.AreEqual(189459234, r.robotFunction(1016, 1047552));
            Assert.AreEqual(189789966, r.robotFunction(126, 1048575));
            Assert.AreEqual(189789966, r.robotFunction(1, 10000000000000));
        }
    }
}