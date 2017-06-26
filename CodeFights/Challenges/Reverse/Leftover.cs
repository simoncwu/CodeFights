using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "leftover": 
    /// https://codefights.com/challenge/QfFQ8aFHHry5Fsbu9
    /// </summary>
    public class Leftover
    {
        /// <summary>
        /// Returns the value left over from dividing the sum of the ordinal values of the characters in a string by the length of that string.
        /// </summary>
        /// <param name="s">A string of characters.</param>
        /// <returns>The value left over from dividing the sum of the ordinal values of the characters in <paramref name="s"/> by the length of <paramref name="s"/>.</returns>
        public int leftover(string s)
        {
            return s.Sum(_ => _) % s.Length;
        }
    }
}
