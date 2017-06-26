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
    public class PairSumOrTests
    {
        [TestMethod()]
        public void pairSumOrTest()
        {
            var p = new PairSumOr();
            Assert.AreEqual(9, p.pairSumOr(new[] { 1, 2, 3 }));
            Assert.AreEqual(51, p.pairSumOr(new[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(1, p.pairSumOr(new[] { 1, 1 }));
            Assert.AreEqual(51, p.pairSumOr(new[] { 5, 4, 3, 2, 1 }));
            Assert.AreEqual(11058, p.pairSumOr(new[] { 68, 92, 1, 3, 8, 14, 100, 9, 82, 7, 79, 0, 73, 61, 37, 6, 26, 47, 4 }));
            Assert.AreEqual(23665130, p.pairSumOr(new[] { 1, 0, 3, 45, 21, 8, 98, 1501, 2456, 45213, 1472435, 4565, 78, 321462 }));
            Assert.AreEqual(1812086, p.pairSumOr(new[] { 21, 4748, 3647, 1, 35, 77, 98243, 45722, 544, 6421, 12486, 11 }));
            Assert.AreEqual(21474836798, p.pairSumOr(new[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7, 2147483647 }));
            Assert.AreEqual(1495408, p.pairSumOr(new[] { 1979, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017 }));
            Assert.AreEqual(394311, p.pairSumOr(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 }));
        }
    }
}