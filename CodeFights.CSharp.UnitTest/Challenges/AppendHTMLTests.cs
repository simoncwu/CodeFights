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
    public class AppendHTMLTests
    {
        [TestMethod()]
        public void appendHTMLTest()
        {
            var a = new AppendHTML();
            var htmlDoc = "<div></div>";
            var target = "div";
            var htmlString = "<p>9+ codefriends online</p>";
            var expected = "<div><p>9+ codefriends online</p></div>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<div id=\"codefight\"></div>";
            target = "#codefight";
            htmlString = "<span>New comment on my feed item</span>";
            expected = "<div id=\"codefight\"><span>New comment on my feed item</span></div>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<div class=\"challenges codefight\"><h3>FAQ</h3></div><div class=\"codefight\"></div>";
            target = ".codefight";
            htmlString = "<h4>Is it valid HTML5 to use a single tag for a div?</h4>";
            expected = "<div class=\"challenges codefight\"><h3>FAQ</h3><h4>Is it valid HTML5 to use a single tag for a div?</h4></div><div class=\"codefight\"><h4>Is it valid HTML5 to use a single tag for a div?</h4></div>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<p>Examples in Every Chapter.</p>";
            target = ".div";
            htmlString = "Address.";
            expected = "<p>Examples in Every Chapter.</p>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<p class=\".div\">Use of SRI is recommended as a best-practice.</p>";
            target = ".div";
            htmlString = "Some text to insert into.";
            expected = "<p class=\".div\">Use of SRI is recommended as a best-practice.</p>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "";
            target = "p";
            htmlString = "nothing";
            expected = "";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<p data-hint=\"Anything can be here\"><img src=\"/sample.jpg\" alt=\"\" /></p>";
            target = "p";
            htmlString = "<strong>Some content</strong>";
            expected = "<p data-hint=\"Anything can be here\"><img src=\"/sample.jpg\" alt=\"\" /><strong>Some content</strong></p>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<div><div></div><div><div></div></div></div>";
            target = "div";
            htmlString = "string";
            expected = "<div><div>string</div><div><div>string</div>string</div>string</div>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));

            htmlDoc = "<div><div></div><div><div></div><div><div></div><div></div></div></div></div>";
            target = "div";
            htmlString = "<div>text</div>";
            expected = "<div><div><div>text</div></div><div><div><div>text</div></div><div><div><div>text</div></div><div><div>text</div></div><div>text</div></div><div>text</div></div><div>text</div></div>";
            Assert.AreEqual(expected, a.appendHTML(htmlDoc, target, htmlString));
        }
    }
}