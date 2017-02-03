using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "sortIt": 
    /// https://codefights.com/challenge/KBmHkh6b7q68QBiHd
    /// 
    /// Given a string, rearrange its letters in alphabetical order, with the 
    /// uppercase form of a letter preceding its lowercase 
    /// </summary>
    public class SortIt
    {
        /// <summary>
        /// Rearranges the letters in a string in alphabetical order.
        /// </summary>
        /// <param name="str">The string to sort.</param>
        /// <returns>The sorted version of <paramref name="str"/>.</returns>
        public string sortIt(string str)
        {
            // group upper and lower case letters together by augmenting its ordinal alphabet position with enough of a gap between each position to stuff a copy of itself
            return string.Concat(str.OrderBy(_ => _ % 32 * 128 + _));
        }
    }
}
