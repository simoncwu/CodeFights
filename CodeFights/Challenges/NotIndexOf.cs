using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "notIndexOf": 
    /// https://codefights.com/challenge/cvieRLS9ghHamb44t
    /// 
    /// Given two strings, find the first position in the first string such 
    /// that no subsequent characters match the characters at each respective 
    /// position of the second string. If no such position exists, return a 
    /// -1 instead.
    /// </summary>
    public class NotIndexOf
    {
        /// <summary>
        /// Returns the index of the first position in a string where no subsequent characters match the characters of another string by position.
        /// </summary>
        /// <param name="givenString">A string to search within.</param>
        /// <param name="value">A string to mismatch.</param>
        /// <returns>The index of the first non-matching position if found; otherwise, <c>-1</c>.</returns>
        public int notIndexOf(string givenString, string value)
        {
            int i = 0, j = i;

            // continue searching at each position while any characters of value match
            while (value.Any(_ => j < givenString.Length && _ == givenString[j++]))
            {
                j = ++i;
            }

            // if j is past the end of givenString, then a match occurred at all positions, so no non-matching position was found
            return j < givenString.Length ? i : -1;
        }
    }
}
