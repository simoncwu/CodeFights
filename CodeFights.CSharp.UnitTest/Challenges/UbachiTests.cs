using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class UbachiTests
    {
        [TestMethod]
        public void UbachiTest()
        {
            var u = new UbachiChallenge();
            Assert.AreEqual("target acquired. Successful extermination ", u.Ubachi("cufintxo r esritqdeucltnagecse.ue raaiS mt", "pancake"));
            Assert.AreEqual("fleet located  ", u.Ubachi("oet lfal ee tdc", "zebra"));
            Assert.AreEqual("the cake is a lie!", u.Ubachi(" ki!aise chee lat ", "portal"));
            Assert.AreEqual("may the force be with you   ", u.Ubachi("eyih fuc bawth or  m  teyo e", "yoda"));
            Assert.AreEqual("our preciousss    ", u.Ubachi("o us srrp   eocisu", "gollum"));
        }
    }
}