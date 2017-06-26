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
    public class ThatsOddTests
    {
        [TestMethod()]
        public void thatsOddTest()
        {
            var t = new ThatsOdd();
            Assert.IsTrue(t.thatsOdd("Don't cry because it's over, smile because it happened."));
            Assert.IsFalse(t.thatsOdd("that's odd"));
            Assert.IsFalse(t.thatsOdd("false?"));
            Assert.IsTrue(t.thatsOdd("that's ok"));
            Assert.IsTrue(t.thatsOdd("true?"));
            Assert.IsFalse(t.thatsOdd("it's not true"));
            Assert.IsTrue(t.thatsOdd("You can do anything, but not everything."));
            Assert.IsTrue(t.thatsOdd("So many books - so little time."));
            Assert.IsTrue(t.thatsOdd("Company Bots are sponsored CodeFights opponents trained by the sponsor's engineers."));
            Assert.IsTrue(t.thatsOdd("Cowboy coders would destroy a team and they work best by themselves and on a single project with a short life-span."));
            Assert.IsFalse(t.thatsOdd("Messy - Unreadable Code"));
            Assert.IsTrue(t.thatsOdd("We currently support Java, C++, Python, Javascript, Ruby, C#, PHP and Perl."));
            Assert.IsTrue(t.thatsOdd("Bugs - Bugs, Everywhere"));
            Assert.IsFalse(t.thatsOdd("What's more - spaghetti code is not extensible."));
            Assert.IsTrue(t.thatsOdd("The most important attribute that makes these programmers bad is arrogance."));
        }
    }
}