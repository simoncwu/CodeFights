using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class ConvertIPv4Tests
    {
        [TestMethod]
        public void convertIPv4Test()
        {
            var c = new ConvertIPv4();
            Assert.AreEqual("[3627730958,0:0:0:0:0:ffff:d83a:c80e]", Util.ArrayToString(c.convertIPv4("216.58.200.14")));
            Assert.AreEqual("[]", Util.ArrayToString(c.convertIPv4("2.2.2")));
            Assert.AreEqual("[621453440,0:0:0:0:0:ffff:250a:a080]", Util.ArrayToString(c.convertIPv4("37.10.160.128")));
            Assert.AreEqual("[2955510652,0:0:0:0:0:ffff:b029:837c]", Util.ArrayToString(c.convertIPv4("176.41.131.124")));
            Assert.AreEqual("[3370500886,0:0:0:0:0:ffff:c8e5:c316]", Util.ArrayToString(c.convertIPv4("200.229.195.22")));
            Assert.AreEqual("[]", Util.ArrayToString(c.convertIPv4("not an ip address")));
            Assert.AreEqual("[1746642203,0:0:0:0:0:ffff:681b:a51b]", Util.ArrayToString(c.convertIPv4("104.27.165.27")));
            Assert.AreEqual("[3149830550,0:0:0:0:0:ffff:bbbe:9996]", Util.ArrayToString(c.convertIPv4("187.190.153.150")));
            Assert.AreEqual("[2631102496,0:0:0:0:0:ffff:9cd3:7020]", Util.ArrayToString(c.convertIPv4("156.211.112.32")));
            Assert.AreEqual("[2769315952,0:0:0:0:0:ffff:a510:6870]", Util.ArrayToString(c.convertIPv4("165.16.104.112")));
        }
    }
}