using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "firstNotRepeatingCharacter": 
    /// https://codefights.com/interview-practice/task/uX5iLwhc6L5ckSyNC
    /// Asked By: Amazon
    /// 
    /// Given a string, find and return the first instance of a non-repeating 
    /// character in it. If there is no such character, return '_'.
    /// 
    /// The solution should iterate over the string only once and use O(1) 
    /// additional memory.
    /// </summary>
    public class FirstNotRepeatingCharacter
    {
        /// <summary>
        /// Returns the first instance of a non-repeating character in a string.
        /// </summary>
        /// <param name="s">A string containing lowercase English letters.</param>
        /// <returns>The first non-repeating character in <paramref name="s"/>, if one exists; otherwise, <c>_</c>.</returns>
        public char firstNotRepeatingCharacter(string s)
        {
            // track the 1-based index of non-repeating characters in O(1) constant additional memory
            // 0 represents not yet encountered
            // -1 represents duplicate
            // 1 or greater represents 1-based index
            var indices = new int[128];

            // single loop over s, without use of any "IndexOf" methods
            for (int i = 0; i < s.Length; i++)
            {
                var letter = s[i];
                // if letter index exists, then it is a repeat, otherwise, record index of first (and hopefully only) instance
                indices[letter] = indices[letter] == 0 ? i + 1 : -1;
            }

            int minIndex = s.Length; // not found "minimum" index would be outside bounds of string
            // check the index state of each possible ASCII character
            for (int i = 0; i < indices.Length; i++)
            {
                // only positive indices represent non-repeating characters that were encountered. 
                if (indices[i] > 0)
                    // auto-decrement the index to revert it back to 0-based and choose the minimum
                    minIndex = Math.Min(minIndex, --indices[i]);
            }

            return minIndex < s.Length ? s[minIndex] : '_';
        }
    }
}
