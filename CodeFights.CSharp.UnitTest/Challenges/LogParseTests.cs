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
    public class LogParseTests
    {
        [TestMethod()]
        public void logParseTest()
        {
            var l = new LogParse();
            var logs = "2017-08-11T17:07:46,2017-08-11T17:07:47,10,100 2017-08-12T17:07:46,2017-08-13T17:07:46,1004,23000".Split();
            var expected = new[] { 1502557666, 1502644066 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2017-08-11T17:07:46,2017-08-11T17:08:00,10,10 2017-08-12T17:07:00,2017-08-12T17:07:46,1004,23000".Split();
            expected = new[] { 1502471266, 1502471280 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2018-08-11T17:07:46,2018-08-11T17:07:52,1,10 2018-08-11T17:07:50,2018-08-11T17:07:52,1,10".Split();
            expected = new[] { 1534007266, 1534007272 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2017-08-11T17:07:46,2017-08-11T17:07:47,43,89 2017-08-12T17:07:46,2017-08-13T18:07:47,32,122 2017-08-14T17:07:46,2017-08-16T17:07:47,1000,1 2017-09-11T17:07:46,2017-10-11T17:00:32,1,1989 2017-11-10T08:11:46,2017-11-11T10:23:08,102,108890 2017-12-11T00:00:22,2017-12-11T17:07:59,12,129948 2017-12-11T17:23:55,2022-08-23T17:21:21,33445566,23092".Split();
            expected = new[] { 1513013035, 1661275281 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2017-08-11T17:07:46,2017-08-11T17:07:47,43,89 2017-08-12T17:07:46,2017-08-13T17:07:47,43,89 2017-09-11T17:07:46,2017-09-11T17:07:47,43,89 2017-10-11T17:07:46,2017-10-11T17:07:47,43,89".Split();
            expected = new[] { 1502557666, 1502644067 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2017-08-10T17:08:46,2017-08-11T17:08:47,10,0 2017-09-12T17:07:46,2018-09-13T17:07:47,1,1".Split();
            expected = new[] { 1502384926, 1502471327 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));

            logs = "2017-08-11T17:07:46,2017-08-11T17:07:47,43,89 2017-09-11T17:08:22,2017-09-11T17:08:23,43,88 2017-10-11T17:07:46,2017-10-11T17:07:47,43,89".Split();
            expected = new[] { 1505149702, 1505149703 };
            Assert.IsTrue(expected.SequenceEqual(l.logParse(logs)));
        }
    }
}