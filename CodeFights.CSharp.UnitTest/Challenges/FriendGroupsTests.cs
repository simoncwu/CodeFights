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
    public class FriendGroupsTests
    {
        [TestMethod]
        public void friendGroupsTest()
        {
            var f = new FriendGroups();
            Assert.AreEqual(2, f.friendGroups(3, Util.ParseJaggedArray("[[0,1]]", int.Parse)));
            Assert.AreEqual(3, f.friendGroups(4, Util.ParseJaggedArray("[[0,1]]", int.Parse)));
            Assert.AreEqual(2, f.friendGroups(4, Util.ParseJaggedArray(" [[0,1],[1,2]]", int.Parse)));
            Assert.AreEqual(2, f.friendGroups(4, Util.ParseJaggedArray("[[0,1],[2,3]]", int.Parse)));
            Assert.AreEqual(3, f.friendGroups(5, Util.ParseJaggedArray("[[2,3],[4,3],[2,4]]", int.Parse)));
            Assert.AreEqual(2, f.friendGroups(2, new int[][] { }));
            Assert.AreEqual(4, f.friendGroups(10, Util.ParseJaggedArray("[[0,9],[3,7],[7,9],[5,6],[1,5],[4,2]]", int.Parse)));
        }
    }
}