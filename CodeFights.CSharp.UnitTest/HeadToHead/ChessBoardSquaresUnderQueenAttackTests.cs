using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.HeadToHead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.HeadToHead.Tests
{
    [TestClass()]
    public class ChessBoardSquaresUnderQueenAttackTests
    {
        [TestMethod()]
        public void chessBoardSquaresUnderQueenAttackTest()
        {
            var c = new ChessBoardSquaresUnderQueenAttack();
            Assert.AreEqual(26, c.chessBoardSquaresUnderQueenAttack(2, 3));
            Assert.AreEqual(12, c.chessBoardSquaresUnderQueenAttack(2, 2));
            Assert.AreEqual(1456, c.chessBoardSquaresUnderQueenAttack(8, 8));
            Assert.AreEqual(680, c.chessBoardSquaresUnderQueenAttack(5, 8));
            Assert.AreEqual(680, c.chessBoardSquaresUnderQueenAttack(8, 5));
            Assert.AreEqual(0, c.chessBoardSquaresUnderQueenAttack(1, 1));
            Assert.AreEqual(90, c.chessBoardSquaresUnderQueenAttack(1, 10));
        }
    }
}