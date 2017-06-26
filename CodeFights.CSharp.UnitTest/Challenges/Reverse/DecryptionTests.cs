using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class DecryptionTests
    {
        [TestMethod()]
        public void decryptionTest()
        {
            var d = new Decryption();
            Assert.AreEqual("a", d.decryption(new[] { 97 }));
            Assert.AreEqual("aaaaaaaaaa", d.decryption(new[] { 97, 97, 0, 0, 0, 0, 0, 0, 0, 0 }));
            Assert.AreEqual("abc", d.decryption(new[] { 97, 98, 2 }));
            Assert.AreEqual("hello world", d.decryption(new[] { 104, 101, 4, 7, 3, 52, 8, 79, 123, 125, 114 }));
            Assert.AreEqual("this is a test", d.decryption(new[] { 116, 104, 117, 11, 55, 118, 83, 55, 110, 0, 19, 69, 127, 15 }));
            Assert.AreEqual("123", d.decryption(new[] { 49, 50, 2 }));
            Assert.AreEqual("I'm a charging mah LAZER!!", d.decryption(new[] { 73, 39, 36, 121, 116, 0, 2, 72, 126, 10, 6, 119, 7, 126, 50, 6, 65, 123, 63, 100, 33, 14, 4, 120, 92, 79 }));
        }
    }
}