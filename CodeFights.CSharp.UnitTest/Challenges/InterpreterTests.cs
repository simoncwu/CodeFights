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
    public class InterpreterTests
    {
        [TestMethod()]
        public void interpreterTest()
        {
            var i = new Interpreter();
            Assert.AreEqual("Cf", i.interpreter("++++++++++++++[>+++++>-----------<<-]>---.>."));
            Assert.AreEqual("!", i.interpreter("+++++++++++++++++++++++++++++++++."));
            Assert.AreEqual("", i.interpreter("+"));
            Assert.AreEqual("X", i.interpreter("-[+[+<]>>+]<."));
            Assert.AreEqual("Hello, World!", i.interpreter(">>>>--<-<<+[+[<+>--->->->-<<<]>]<<--.<++++++.<<-..<<.<+.>>.>>.<<<.+++.>>.>>-.<<<+."));
            Assert.AreEqual("!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~", i.interpreter(">-->+[+[+<]>>+]<>>++++++++[-<++++>]<<[->+.<]"));
        }
    }
}