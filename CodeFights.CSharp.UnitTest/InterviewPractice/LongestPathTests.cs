using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class LongestPathTests
    {
        [TestMethod()]
        public void longestPathTest()
        {
            var l = new LongestPath();
            Assert.AreEqual(24, l.longestPath("user\r\tpictures\r\tdocuments\r\t\tnotes.txt"));
            Assert.AreEqual(33, l.longestPath("user\r\tpictures\r\t\tphoto.png\r\t\tcamera\r\tdocuments\r\t\tlectures\r\t\t\tnotes.txt"));
            Assert.AreEqual(0, l.longestPath("a"));
            Assert.AreEqual(5, l.longestPath("a.txt"));
            Assert.AreEqual(8, l.longestPath("a.tar.gz"));
            Assert.AreEqual(10, l.longestPath("ReadME.TXT"));
            Assert.AreEqual(25, l.longestPath("file name with  space.txt"));
            Assert.AreEqual(0, l.longestPath("a\r\tb\r\t\tc"));
            Assert.AreEqual(9, l.longestPath("a\r\tb\r\t\tc.txt"));
            Assert.AreEqual(12, l.longestPath("dir\r    file.txt"));
            Assert.AreEqual(16, l.longestPath("dir\r\t\tfile.txt"));
            Assert.AreEqual(20, l.longestPath("dir\r\t\t\tfile.txt\r\tfile2.txt"));
            Assert.AreEqual(14, l.longestPath("a\r\tb1\r\t\tf1.txt\r\taaaaa\r\t\tf2.txt"));
        }
    }
}