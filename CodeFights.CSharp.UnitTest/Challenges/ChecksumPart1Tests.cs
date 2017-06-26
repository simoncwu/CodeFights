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
    public class ChecksumPart1Tests
    {
        [TestMethod()]
        public void checksum_part1Test()
        {
            var c = new ChecksumPart1();
            Assert.AreEqual(9, c.checksum_part1(29104150021));
            Assert.AreEqual(2, c.checksum_part1(3600029145));
            Assert.AreEqual(9, c.checksum_part1(7));
            Assert.AreEqual(2, c.checksum_part1(19138629021));
            Assert.AreEqual(7, c.checksum_part1(513516558));
            Assert.AreEqual(2, c.checksum_part1(5891153));
            Assert.AreEqual(5, c.checksum_part1(86274));
            Assert.AreEqual(3, c.checksum_part1(876666));
            Assert.AreEqual(5, c.checksum_part1(63));
            Assert.AreEqual(5, c.checksum_part1(5));
            Assert.AreEqual(6, c.checksum_part1(8648769));
            Assert.AreEqual(4, c.checksum_part1(471578084));
            Assert.AreEqual(0, c.checksum_part1(4499954831));
            Assert.AreEqual(3, c.checksum_part1(99999999999));
            Assert.AreEqual(0, c.checksum_part1(0));
        }
    }
}