using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "cards": 
    /// https://codefights.com/challenge/KPYtAdvnN7Pv27TXr
    /// 
    /// You are given a deck of cards sorted first by suit in alphabetic order: 
    /// 'C'lubs, 'D'iamonds, 'H'earts, 'S'pades; then by card value: numbers 2 
    /// to 10 (represented by '0'), 'J'ack, 'Q'ueen, 'K'ing, 'A'ce. Given a 
    /// 0-based integer n from 0 to 51, return the n-th card as a 2-character 
    /// string in the form [rank][suit].
    /// </summary>
    public class Cards
    {
        /// <summary>
        /// Returns the value of a specific card in a deck of cards sorted by suit then rank.
        /// </summary>
        /// <param name="n">The 0-based number of the card to retrieve.</param>
        /// <returns>The value of the <paramref name="n"/>-th card in the form [rank][suit].</returns>
        public string cards(int n) => "" + "234567890JQKA"[n % 13] + "CDHS"[n / 13];
    }
}
