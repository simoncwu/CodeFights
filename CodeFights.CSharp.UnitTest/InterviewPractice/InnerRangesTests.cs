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
    public class InnerRangesTests
    {
        [TestMethod()]
        public void innerRangesTest()
        {
            var i = new InnerRanges();
            Assert.IsTrue(new[] { "-4->9", "11", "14->49", "51->88" }.SequenceEqual(i.innerRanges(new[] { -5, 10, 12, 13, 50 }, -5, 88)));
            Assert.IsTrue(new[] { "1" }.SequenceEqual(i.innerRanges(new int[0], 1, 1)));
            Assert.IsTrue(new string[0].SequenceEqual(i.innerRanges(new[] { -1 }, -1, -1)));
            Assert.IsTrue(new[] { "2", "4->49", "51->74", "76->99" }.SequenceEqual(i.innerRanges(new[] { 0, 1, 3, 50, 75 }, 0, 99)));
            Assert.IsTrue(new[] { "-2" }.SequenceEqual(i.innerRanges(new[] { -1 }, -2, -1)));
            Assert.IsTrue(new[] { "-2", "0" }.SequenceEqual(i.innerRanges(new[] { -1, -1 }, -2, 0)));
            Assert.IsTrue(new[] { "0->9" }.SequenceEqual(i.innerRanges(new int[0], 0, 9)));
            Assert.IsTrue(new[] { "0", "2->9" }.SequenceEqual(i.innerRanges(new[] { 1 }, 0, 9)));
            Assert.IsTrue(new[] { "0->1", "3->9" }.SequenceEqual(i.innerRanges(new[] { 2 }, 0, 9)));
            Assert.IsTrue(new[] { "0->6", "8->9" }.SequenceEqual(i.innerRanges(new[] { 7 }, 0, 9)));
            Assert.IsTrue(new[] { "0->7", "9" }.SequenceEqual(i.innerRanges(new[] { 8 }, 0, 9)));
            Assert.IsTrue(new[] { "0->8" }.SequenceEqual(i.innerRanges(new[] { 9 }, 0, 9)));
            Assert.IsTrue(new string[0].SequenceEqual(i.innerRanges(new[] { 0, 1 }, 0, 1)));
            Assert.IsTrue(new[] { "2->9" }.SequenceEqual(i.innerRanges(new[] { 0, 1 }, 0, 9)));
            Assert.IsTrue(new[] { "0", "3->9" }.SequenceEqual(i.innerRanges(new[] { 1, 2 }, 0, 9)));
            Assert.IsTrue(new[] { "0", "2", "4->9" }.SequenceEqual(i.innerRanges(new[] { 1, 3 }, 0, 9)));
            Assert.IsTrue(new[] { "0->7" }.SequenceEqual(i.innerRanges(new[] { 8, 9 }, 0, 9)));
            Assert.IsTrue(new[] { "0->4", "6->7", "9" }.SequenceEqual(i.innerRanges(new[] { 5, 8 }, 0, 9)));
            Assert.IsTrue(new[] { "1->4", "6->8" }.SequenceEqual(i.innerRanges(new[] { 0, 5, 9 }, 0, 9)));
            Assert.IsTrue(new[] { "-2147483648->2147483646" }.SequenceEqual(i.innerRanges(new[] { 2147483647 }, -2147483648, 2147483647)));
            Assert.IsTrue(new[] { "-2147483647->2147483647" }.SequenceEqual(i.innerRanges(new[] { -2147483648 }, -2147483648, 2147483647)));
            Assert.IsTrue(new[] { "-2147483648->2147483647" }.SequenceEqual(i.innerRanges(new int[0], -2147483648, 2147483647)));
        }
    }
}