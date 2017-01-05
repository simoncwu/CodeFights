using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "stringsRearrangement": 
    /// https://codefights.com/challenge/RWQS5cCEodqSWx4bR
    /// 
    /// Given an array of equal-length strings, determine if it is possible to 
    /// rearrange the strings such that each string differs from its neighbors 
    /// by exactly one character.
    /// 
    /// Constraints:
    /// 2 ≤ inputArray.length ≤ 10; 1 ≤ inputArray[i].length ≤ 15.
    /// </summary>
    public class StringsRearrangement
    {
        /// <summary>
        /// Determines whether or not it is possible to rearrange an array of strings such that each string differs from its neighbors by exactly one character.
        /// </summary>
        /// <param name="inputArray">An array of lowercase strings.</param>
        /// <returns><c>true</c> if such a rearrangment is possible; otherwise, <c>false</c>.</returns>
        public bool stringsRearrangement(string[] inputArray)
        {
            var a = inputArray.Select((_, i) => i + _);
            return a.Any(_ => stringsRearrangement(a, _));
        }

        /// <summary>
        /// Determines whether or not it is possible to rearrange a collection of strings such that each string differs from its neighbors by exactly one character.
        /// </summary>
        /// <param name="input">A collection of lowercase strings.</param>
        /// <param name="first">The first string in the proposed rearrangement.</param>
        /// <returns><c>true</c> if such a rearrangment is possible starting with <paramref name="first"/>; otherwise, <c>false</c>.</returns>
        bool stringsRearrangement(IEnumerable<string> input, string first)
        {
            input = input.Except(new[] { first });
            return !input.Any() || GetSimilar(input, first).Any(_ => stringsRearrangement(input, _));
        }

        /// <summary>
        /// Filters a collection of strings for those that differ from a given string by exactly one character.
        /// </summary>
        /// <param name="input">The collection of strings to filter.</param>
        /// <param name="s">The string to compare against.</param>
        /// <returns>A collection of strings that differ from <paramref name="s"/> by exactly one character.</returns>
        IEnumerable<string> GetSimilar(IEnumerable<string> input, string s)
        {
            return input.Where(_ => CountDifferent(_.Substring(1), s.Substring(1)) == 1);
        }

        /// <summary>
        /// Counts the number of characters that are different by position between two equal length strings.
        /// </summary>
        /// <param name="a">The first string to compare.</param>
        /// <param name="b">The second string to compare.</param>
        /// <returns>The number of characters that are different by position.</returns>
        int CountDifferent(string a, string b)
        {
            return a.Where((c, i) => c != b[i]).Count();
        }
    }
}
