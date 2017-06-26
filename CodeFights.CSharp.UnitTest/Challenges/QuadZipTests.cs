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
    public class QuadZipTests
    {
        [TestMethod()]
        public void quadZipTest()
        {
            var q = new QuadZip();
            Assert.AreEqual("ottfnwhoeoruere", q.quadZip("one", "two", "three", "four"));
            Assert.AreEqual("abcdabcdabcd", q.quadZip("aaa", "bbb", "ccc", "ddd"));
            Assert.AreEqual("aaaabbbbcccc", q.quadZip("abc", "abc", "abc", "abc"));
            Assert.AreEqual("abcdabcdabcdbcdbcbcbcbccccc", q.quadZip("aaa", "bbbbbbbb", "cccccccccccc", "dddd"));
            Assert.AreEqual("HWGHeheelatylt ,o'i  sthW  ooudwrpo l!nad?er! en oywo!u?", q.quadZip("Hello World!", "What's up!?", "Get it done now!", "Hey, how are you?"));
            Assert.AreEqual("aaa9osssszdaig88rf66eofef tfza7toi  az97isa9se68zfw6ri3wgzf3og9ffa7waow8is66zi3fsu8grzt g  9 ofoog98fi7auzggaassiserzgofge 9srf8o u7 fztrig fz wzg3o80g78a6rs 6uwtr8 z79e67gfgfg(o /ao%us  uRs6/zg)oo%eegff u6aszes8ofe6ggf  ou8z6g osweeff", q.quadZip("aosirefzoaiszrgofaizsrg ofuaizgso rfzogasurzegfoau szoegfuazsoegf uzgowef", "aszgfo aizsefizgaosiuz ogizasger fizg876 w876fg osu6goef 6se8f6g o86 sef", "asd86ft7 9a6w3f97w638t f97gseo fuzg ", "9sa86eft 7986w3fw86fg 9o8agsrf987t w308r6t 97g(/% R/)%"));
        }
    }
}