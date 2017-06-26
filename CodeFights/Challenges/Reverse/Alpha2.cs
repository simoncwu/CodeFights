using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "alpha2": 
    /// https://codefights.com/challenge/mkwmaLLG7RMWKw2Gh
    /// </summary>
    public class Alpha2
    {
        /// <summary>
        /// Converts a string of lowercase English letters to a number using each letter's parity.
        /// </summary>
        /// <param name="s">A string consisting of up to 31 lowercase English letters.</param>
        /// <returns>A signed 32-bit integer based on the parity of the letters in <paramref name="s"/>.</returns>
        public int alpha2(string s)
        {
            int v = 0;
            foreach (var c in s)
            {
                v += v - ~c % 2;
            }
            return v;
        }
    }
}
