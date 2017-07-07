using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "convertString": 
    /// https://codefights.com/challenge/DF6j9AcQSCGtLonyM
    /// 
    /// Determine if it is possible to change one string to another solely by 
    /// removing characters from the source string (no reordering or inserts).
    /// </summary>
    public class ConvertString
    {
        /// <summary>
        /// Indicates whether or not it is possible to convert one string to another only via removal of characters from the first string.
        /// </summary>
        /// <param name="s">A string to convert from.</param>
        /// <param name="t">A string to convert to.</param>
        /// <returns><c>true</c> if is possible to convert <paramref name="s"/> to <paramref name="t"/> only by removing characters from <paramref name="s"/>; otherwise, <c>false</c>.</returns>
        public bool convertString(string s, string t)
        {
            // for tracking the next position to start searching from
            int nextSearchStartIndex = 0;
            // At each character of t, look in s for next instance of the character from previous search result position and set search index tracker to next position.
            // If and only if any character is not found will the result (and thus the minimum) be 0 (-1 (not found) + 1 (next position) = 0).
            return t.Min(_ => nextSearchStartIndex = s.IndexOf(_, nextSearchStartIndex) + 1) > 0;
        }
    }
}
