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
    [TestClass()]
    public class CandyCrush1Tests
    {
        [TestMethod()]
        public void candyCrush1Test()
        {
            var c = new CandyCrush1();
            Func<string, char> parse = _ => _[0];
            var gameboard = Util.ParseJaggedArray(@"[[R,B,G], 
 [R,Y,B], 
 [R,O,Y]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,R,R], 
 [R,R,Y], 
 [O,G,B]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[Y,Y,Y], 
 [Y,Y,Y], 
 [Y,Y,Y]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[Y,R,Y], 
 [R,Y,R], 
 [Y,R,Y]]", parse);
            Assert.IsFalse(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,G,G,B], 
 [B,O,G,G], 
 [P,O,B,P], 
 [Y,B,Y,O]]", parse);
            Assert.IsFalse(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,G,B,Y], 
 [B,G,Y,P], 
 [P,G,B,Y], 
 [O,G,P,R]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,Y,R,Y], 
 [Y,R,Y,R], 
 [R,Y,R,Y], 
 [Y,R,Y,R]]", parse);
            Assert.IsFalse(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,B,G,G,Y,R,B,O,P,Y]]", parse);
            Assert.IsFalse(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R,B,G,G,G,R,B,O,P,Y]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@" [[R], 
 [B], 
 [G], 
 [G], 
 [Y], 
 [R], 
 [B], 
 [O], 
 [P], 
 [Y]]", parse);
            Assert.IsFalse(c.candyCrush1(gameboard));

            gameboard = Util.ParseJaggedArray(@"[[R], 
 [B], 
 [G], 
 [G], 
 [G], 
 [R], 
 [B], 
 [O], 
 [P], 
 [Y]]", parse);
            Assert.IsTrue(c.candyCrush1(gameboard));
        }
    }
}