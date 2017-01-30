using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class Isbn13Tests
    {
        [TestMethod]
        public void ISBN13Test()
        {
            var i = new Isbn13();
            var expected = "[ISBN-10: 0-306-40615-2,ISBN-13: 978-0-306-40615-7]";
            Assert.AreEqual(expected, Util.ArrayToString(i.ISBN13("0-306-40615")));

            expected = "[ISBN-10: 0-307-94730-0,ISBN-13: 978-0-307-94730-7]";
            Assert.AreEqual(expected, Util.ArrayToString(i.ISBN13("0307947300")));

            expected = "[ISBN-10: 1-501-14353-0,ISBN-13: 978-1-501-14353-3]";
            Assert.AreEqual(expected, Util.ArrayToString(i.ISBN13("1-501-14353")));

            expected = "[ISBN-10: 0-307-74365-9,ISBN-13: 978-0-307-74365-7]";
            Assert.AreEqual(expected, Util.ArrayToString(i.ISBN13("03-077-43657")));

            expected = "[ISBN-10: 1-501-14206-2,ISBN-13: 978-1-501-14206-2]";
            Assert.AreEqual(expected, Util.ArrayToString(i.ISBN13("150-114-206")));
        }
    }
}