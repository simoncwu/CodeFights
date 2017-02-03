using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "betaExor": 
    /// https://codefights.com/challenge/M8cR5yNub3PrwXkkp
    /// </summary>
    public class BetaExor
    {
        /// <summary>
        /// Returns the cumulative XOR value of the characters in a string.
        /// </summary>
        /// <param name="s">The string to evaluate.</param>
        /// <returns>The cumulative XOR of the characters in <paramref name="s"/>.</returns>
        public int betaExor(string s)
        {
            int b = 0;
            foreach (var c in s)
            {
                b ^= c;
            }
            return b;
        }
    }
}
