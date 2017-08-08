using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "FaroShuffles": 
    /// https://codefights.com/challenge/px4JqDBvDPWPAYfdc
    /// 
    /// A faro shuffle is a method of shuffling playing cards whereby a deck of 
    /// cards is split into two equal-sized halves (upper and lower) and then 
    /// interwoven perfectly, one card from each half at a time. For any deck 
    /// of 8 or more cards, the original card order will eventually be restored 
    /// after enough faro shuffles, assuming that the interweaving begins with 
    /// the lower half every time.
    /// 
    /// Given a deck size of 8 or more, determine the number of faro shuffles 
    /// that can be performed before it is restored to its original order.
    /// </summary>
    public class FaroShufflesChallenge
    {
        /// <summary>
        /// Returns the number of faro shuffles that can be performed on a deck of cards before it is restored to its original order.
        /// </summary>
        /// <param name="n">The number of cards in the deck.</param>
        /// <returns>The number of faro shuffles that can be performed on a deck of size <paramref name="n"/> before it is restored to its original order.</returns>
        public int FaroShuffles(int n)
        {
            int i = 1, s = 0; // i is index of the second card in the deck
            do
            {
                s++; // perform a shuffle
                i = 2 * i % ~-n; // update card index
            } while (i != 1); // until second card returns to original position
            return s;
        }
    }
}
