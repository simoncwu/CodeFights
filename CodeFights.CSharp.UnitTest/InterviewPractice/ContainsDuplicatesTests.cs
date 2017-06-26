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
    public class ContainsDuplicatesTests
    {
        [TestMethod()]
        public void containsDuplicatesTest()
        {
            var c = new ContainsDuplicates();
            Assert.IsTrue(c.containsDuplicates(new[] { 1, 2, 3, 1 }));
            Assert.IsFalse(c.containsDuplicates(new[] { 3, 1 }));
            Assert.IsTrue(c.containsDuplicates(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
            Assert.IsFalse(c.containsDuplicates(new int[0]));
            Assert.IsFalse(c.containsDuplicates(new[] { 1 }));
            Assert.IsTrue(c.containsDuplicates(new[] { -1200000005, -1200000005 }));
            Assert.IsTrue(c.containsDuplicates(new[] { 0, 4, 5, 0, 3, 6 }));
            Assert.IsFalse(c.containsDuplicates(new[] { 1, 2, 3, 4 }));
            Assert.IsTrue(c.containsDuplicates(new[] { 0, 1, 0, -1 }));
            Assert.IsFalse(c.containsDuplicates(new[] { 2 }));
        }
    }
}