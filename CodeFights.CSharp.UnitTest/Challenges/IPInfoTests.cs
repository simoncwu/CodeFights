﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class IPInfoTests
    {
        [TestMethod()]
        public void ipinfoTest()
        {
            var i = new IPInfo();
            Assert.IsTrue(new[] {
                "01101100.10111111.10011000.11100000 108.191.152.224",
                "11100000.00000000.00000000.00000000 224.0.0.0",
                "01100000.00000000.00000000.00000000 96.0.0.0",
                "01100000.00000000.00000000.00000001 96.0.0.1",
                "01111111.11111111.11111111.11111110 127.255.255.254",
                "01111111.11111111.11111111.11111111 127.255.255.255"
            }.SequenceEqual(i.ipinfo("108.191.152.224/3")));
            Assert.IsTrue(new[] {
                "10110000.11001010.01110011.10111001 176.202.115.185",
                "11111111.11111111.10000000.00000000 255.255.128.0",
                "10110000.11001010.00000000.00000000 176.202.0.0",
                "10110000.11001010.00000000.00000001 176.202.0.1",
                "10110000.11001010.01111111.11111110 176.202.127.254",
                "10110000.11001010.01111111.11111111 176.202.127.255"
            }.SequenceEqual(i.ipinfo("176.202.115.185/17")));
            Assert.IsTrue(new[] {
                "01001100.10110010.01000100.00000000 76.178.68.0",
                "11111100.00000000.00000000.00000000 252.0.0.0",
                "01001100.00000000.00000000.00000000 76.0.0.0",
                "01001100.00000000.00000000.00000001 76.0.0.1",
                "01001111.11111111.11111111.11111110 79.255.255.254",
                "01001111.11111111.11111111.11111111 79.255.255.255"
            }.SequenceEqual(i.ipinfo("76.178.68.0/6")));
            Assert.IsTrue(new[] {
                "11101101.00100001.11011101.00110001 237.33.221.49",
                "11100000.00000000.00000000.00000000 224.0.0.0",
                "11100000.00000000.00000000.00000000 224.0.0.0",
                "11100000.00000000.00000000.00000001 224.0.0.1",
                "11111111.11111111.11111111.11111110 255.255.255.254",
                "11111111.11111111.11111111.11111111 255.255.255.255"
            }.SequenceEqual(i.ipinfo("237.33.221.49/3")));
            Assert.IsTrue(new[] {
                "01110001.10100101.11010111.01010111 113.165.215.87",
                "11111000.00000000.00000000.00000000 248.0.0.0",
                "01110000.00000000.00000000.00000000 112.0.0.0",
                "01110000.00000000.00000000.00000001 112.0.0.1",
                "01110111.11111111.11111111.11111110 119.255.255.254",
                "01110111.11111111.11111111.11111111 119.255.255.255"
            }.SequenceEqual(i.ipinfo("113.165.215.87/5")));
        }
    }
}