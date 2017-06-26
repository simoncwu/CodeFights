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
    public class SuccessivePrimesTests
    {
        [TestMethod()]
        public void successivePrimesTest()
        {
            var s = new SuccessivePrimes();
            Assert.AreEqual(5, s.successivePrimes(new[] { 11, 3, 7 }));
            Assert.AreEqual(131, s.successivePrimes(new[] { 151, 139, 149, 173, 163, 127, 137, 113, 167, 157 }));
            Assert.AreEqual(47, s.successivePrimes(new[] { 71, 67, 43, 53, 59, 61, 73 }));
            Assert.AreEqual(977, s.successivePrimes(new[] { 971, 983, 991 }));
            Assert.AreEqual(1009, s.successivePrimes(new[] { 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1013 }));
            Assert.AreEqual(1433, s.successivePrimes(new[] { 1451, 1429, 1427, 1447, 1439 }));
            Assert.AreEqual(29, s.successivePrimes(new[] { 2, 5, 7, 11, 13, 17, 19, 23, 3, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541 }));
        }
    }
}