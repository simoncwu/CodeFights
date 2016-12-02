using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "alpha3": 
    /// https://codefights.com/challenge/3BEisz8mXqYRpSupn
    /// </summary>
    public class Alpha3
    {
        /// <summary>
        /// Encodes a string based on the ASCII values of its individual characters.
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <returns>The encoded value of <paramref name="s"/>.</returns>
        public string alpha3(string s)
        {
            var sb = new StringBuilder();
            var reverse = s[0] % 2 == 0; // reverse if first character has an even ASCII value
            for (int i = 0, j = s.Length - 1; i <= j; i++)
            {
                sb.Append((s[reverse ? j - i : i] + 4) % 10); // encoding is last digit of (ASCII value + 4)
            }
            return string.IsNullOrEmpty(s = sb.ToString().TrimStart('0')) ? "0" : s;
        }
    }
}