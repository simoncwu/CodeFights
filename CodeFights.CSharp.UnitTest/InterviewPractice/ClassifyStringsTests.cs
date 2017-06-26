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
    public class ClassifyStringsTests
    {
        [TestMethod()]
        public void classifyStringsTest()
        {
            var c = new ClassifyStrings();
            Assert.AreEqual("bad", c.classifyStrings("aeu"));
            Assert.AreEqual("mixed", c.classifyStrings("a?u"));
            Assert.AreEqual("good", c.classifyStrings("aba"));
            Assert.AreEqual("bad", c.classifyStrings("qwrtl"));
            Assert.AreEqual("mixed", c.classifyStrings("qwr?l"));
            Assert.AreEqual("mixed", c.classifyStrings("???"));
            Assert.AreEqual("good", c.classifyStrings("?"));
            Assert.AreEqual("mixed", c.classifyStrings("?io"));
            Assert.AreEqual("mixed", c.classifyStrings("a?a"));
            Assert.AreEqual("mixed", c.classifyStrings("ei?"));
            Assert.AreEqual("mixed", c.classifyStrings("?ypsd"));
            Assert.AreEqual("mixed", c.classifyStrings("f?ghj"));
            Assert.AreEqual("mixed", c.classifyStrings("kl?zx"));
            Assert.AreEqual("mixed", c.classifyStrings("cvb?n"));
            Assert.AreEqual("mixed", c.classifyStrings("mqwr?"));
            Assert.AreEqual("bad", c.classifyStrings("typ?asdf?relkhfd"));
            Assert.AreEqual("bad", c.classifyStrings("lrsesknaiotmqanvt"));
            Assert.AreEqual("bad", c.classifyStrings("aa?bbbb"));
            Assert.AreEqual("bad", c.classifyStrings("aa?bbb?a?bbbb"));
            Assert.AreEqual("mixed", c.classifyStrings("aa??bbbb???bb"));
            Assert.AreEqual("mixed", c.classifyStrings("a?aa"));
        }
    }
}