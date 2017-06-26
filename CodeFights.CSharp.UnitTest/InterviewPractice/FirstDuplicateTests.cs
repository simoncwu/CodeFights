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
    public class FirstDuplicateTests
    {
        [TestMethod()]
        public void firstDuplicateTest()
        {
            var f = new FirstDuplicate();
            Assert.AreEqual(3, f.firstDuplicate(new[] { 2, 3, 3, 1, 5, 2 }));
            Assert.AreEqual(-1, f.firstDuplicate(new[] { 2, 4, 3, 5, 1 }));
            Assert.AreEqual(-1, f.firstDuplicate(new[] { 1 }));
            Assert.AreEqual(2, f.firstDuplicate(new[] { 2, 2 }));
            Assert.AreEqual(-1, f.firstDuplicate(new[] { 2, 1 }));
            Assert.AreEqual(-1, f.firstDuplicate(new[] { 2, 1, 3 }));
            Assert.AreEqual(3, f.firstDuplicate(new[] { 2, 3, 3 }));
            Assert.AreEqual(3, f.firstDuplicate(new[] { 3, 3, 3 }));
            Assert.AreEqual(6, f.firstDuplicate(new[] { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 }));
            Assert.AreEqual(-1, f.firstDuplicate(new[] { 10, 6, 8, 4, 9, 1, 7, 2, 5, 3 }));
        }
    }
}