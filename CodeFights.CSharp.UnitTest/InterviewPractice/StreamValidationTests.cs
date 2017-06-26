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
    public class StreamValidationTests
    {
        [TestMethod()]
        public void streamValidationTest()
        {
            var s = new StreamValidation();
            Assert.IsTrue(s.streamValidation(new[] { 197, 130, 1 }));
            Assert.IsFalse(s.streamValidation(new[] { 235, 140, 4 }));
            Assert.IsTrue(s.streamValidation(new[] { 10 }));
            Assert.IsTrue(s.streamValidation(new[] { 230, 136, 145 }));
            Assert.IsTrue(s.streamValidation(new[] { 240, 162, 138, 147 }));
            Assert.IsFalse(s.streamValidation(new[] { 255 }));
            Assert.IsTrue(s.streamValidation(new[] { 240, 162, 138, 147, 17 }));
            Assert.IsFalse(s.streamValidation(new[] { 237 }));
            Assert.IsFalse(s.streamValidation(new[] { 145 }));
            Assert.IsTrue(s.streamValidation(new[] { 228, 189, 160, 229, 165, 189, 13, 10 }));
            Assert.IsFalse(s.streamValidation(new[] { 240, 162, 138, 147, 145 }));
            Assert.IsTrue(s.streamValidation(new[] { 115, 100, 102, 231, 154, 132, 13, 10 }));
            Assert.IsTrue(s.streamValidation(new[] { 231, 154, 132, 230, 136, 145, 13, 10 }));
            Assert.IsFalse(s.streamValidation(new[] { 39, 89, 227, 83, 132, 95, 10, 0 }));
        }
    }
}