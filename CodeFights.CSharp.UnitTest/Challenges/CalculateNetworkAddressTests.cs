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
    public class CalculateNetworkAddressTests
    {
        [TestMethod()]
        public void calculateNetworkAddressTest()
        {
            var c = new CalculateNetworkAddress();
            Assert.AreEqual("128.42.0.0", c.calculateNetworkAddress("128.42.5.4/21"));
            Assert.AreEqual("205.16.37.32", c.calculateNetworkAddress("205.16.37.39/28"));
            Assert.AreEqual("172.16.5.0", c.calculateNetworkAddress("172.16.5.34/26"));
            Assert.AreEqual("192.168.1.0", c.calculateNetworkAddress("192.168.1.15/24"));
            Assert.AreEqual("189.107.0.0", c.calculateNetworkAddress("189.107.51.62/18"));
            Assert.AreEqual("27.192.0.0", c.calculateNetworkAddress("27.244.51.191/10"));
            Assert.AreEqual("128.0.0.0", c.calculateNetworkAddress("157.218.232.254/3"));
            Assert.AreEqual("123.104.0.0", c.calculateNetworkAddress("123.106.202.116/13"));
        }
    }
}