using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "codefightsTournament": 
    /// https://codefights.com/challenge/Cggjkhts4TmHLPHQr
    /// 
    /// Given the final position and score in a tournament, return the number of coins and XP they will get, where:
    /// coins = 2000 * (1 / 2^(position - 1)) rounded down to the nearest integer;
    /// XP = 2 * score if position == 1; otherwise, score.
    /// </summary>
    public class CodefightsTournament
    {
        /// <summary>
        /// Returns the number of coins and XP to be awarded to based on an entrant's final position and score.
        /// </summary>
        /// <param name="position">The entrant's final placed position in the tournament.</param>
        /// <param name="score">The entrant's score.</param>
        /// <returns>An array in the format [number of coins, XP].</returns>
        public int[] codefightsTournament(int position, int score)
        {
            return new[] { 4000 >> position, score << 1 / position };
        }

    }
}
