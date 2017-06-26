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
    public class FirstNotRepeatingCharacterTests
    {
        [TestMethod()]
        public void firstNotRepeatingCharacterTest()
        {
            var f = new FirstNotRepeatingCharacter();
            Assert.AreEqual('c', f.firstNotRepeatingCharacter("abacabad"));
            Assert.AreEqual('_', f.firstNotRepeatingCharacter("abacabaabacaba"));
            Assert.AreEqual('z', f.firstNotRepeatingCharacter("z"));
            Assert.AreEqual('c', f.firstNotRepeatingCharacter("bcb"));
            Assert.AreEqual('_', f.firstNotRepeatingCharacter("bcccccccb"));
            Assert.AreEqual('d', f.firstNotRepeatingCharacter("abcdefghijklmnopqrstuvwxyziflskecznslkjfabe"));
            Assert.AreEqual('_', f.firstNotRepeatingCharacter("zzz"));
            Assert.AreEqual('y', f.firstNotRepeatingCharacter("bcccccccccccccyb"));
            Assert.AreEqual('d', f.firstNotRepeatingCharacter("xdnxxlvupzuwgigeqjggosgljuhliybkjpibyatofcjbfxwtalc"));
            Assert.AreEqual('g', f.firstNotRepeatingCharacter("ngrhhqbhnsipkcoqjyviikvxbxyphsnjpdxkhtadltsuxbfbrkof"));
        }
    }
}