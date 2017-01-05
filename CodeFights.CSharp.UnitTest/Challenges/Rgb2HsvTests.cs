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
    public class Rgb2HsvTests
    {
        private Rgb2Hsv _r;
        private Func<string, int> _parse;

        public Rgb2HsvTests()
        {
            _r = new Rgb2Hsv();
            _parse = int.Parse;
        }

        [TestMethod]
        public void Rgb2HsvTest()
        {
            var rgb = Util.ParseArray("[200, 125, 100]", _parse);
            var expected = new[] { "15", "50.0", "78.4" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[25, 25, 25]", _parse);
            expected = new[] { "0", "0.0", "9.8" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[125, 100, 200]", _parse);
            expected = new[] { "255", "50.0", "78.4" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[1, 2, 3]", _parse);
            expected = new[] { "210", "66.7", "1.2" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[240, 250, 235]", _parse);
            expected = new[] { "100", "6.0", "98.0" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[255, 255, 255]", _parse);
            expected = new[] { "0", "0.0", "100.0" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[149, 23, 200]", _parse);
            expected = new[] { "283", "88.5", "78.4" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[209, 198, 23]", _parse);
            expected = new[] { "56", "89.0", "82.0" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[111, 168, 116]", _parse);
            expected = new[] { "125", "33.9", "65.9" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[24, 251, 63]", _parse);
            expected = new[] { "130", "90.4", "98.4" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));

            rgb = Util.ParseArray("[255, 0, 255]", _parse);
            expected = new[] { "300", "100.0", "100.0" };
            Assert.AreEqual(Util.ArrayToString(expected), Util.ArrayToString(_r.rgb2hsv(rgb)));
        }
    }
}