using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "singkatan": 
    /// https://codefights.com/challenge/fLsRtAmnjFgq8u5zG
    /// 
    /// Given two strings, merge them into one string by trying to overlap a 
    /// suffix of the first string with a matching prefix in the second string. 
    /// The overlap should be as long as possible. If there is no overlap, 
    /// simply concatenate the two strings.
    /// </summary>
    public class Singkatan
    {
        /// <summary>
        /// Attempts to merge two strings by overlapping the suffix of the first string with the prefix of the second.
        /// </summary>
        /// <param name="s1">A string consisting of English alphabetic letters.</param>
        /// <param name="s2">A string consisting of English alphabetic letters.</param>
        /// <returns>The result of merging/overlapping <paramref name="s1"/> with <paramref name="s2"/>.</returns>
        public string singkatan(string s1, string s2)
        {
            return singkatanIterative(s1, s2);
        }

        /// <summary>
        /// Attempts to merge two strings by overlapping the suffix of the first string with the prefix of the second, using recursion.
        /// </summary>
        /// <param name="s1">A string consisting of English alphabetic letters.</param>
        /// <param name="s2">A string consisting of English alphabetic letters.</param>
        /// <returns>The result of merging/overlapping <paramref name="s1"/> with <paramref name="s2"/>.</returns>
        string singkatanRecursive(string s1, string s2)
        {
            return s2.StartsWith(s1) ? s2 : s1[0] + singkatan(s1.Substring(1), s2);
        }

        /// <summary>
        /// Attempts to merge two strings by overlapping the suffix of the first string with the prefix of the second, using an iterative loop.
        /// </summary>
        /// <param name="s1">A string consisting of English alphabetic letters.</param>
        /// <param name="s2">A string consisting of English alphabetic letters.</param>
        /// <returns>The result of merging/overlapping <paramref name="s1"/> with <paramref name="s2"/>.</returns>
        string singkatanIterative(string s1, string s2)
        {
            var sb = new StringBuilder();
            while (!s2.StartsWith(s1))
            {
                sb.Append(s1[0]);
                s1 = s1.Substring(1);
            }
            return sb.ToString() + s2;
        }

        /// <summary>
        /// Attempts to merge two strings by overlapping the suffix of the first string with the prefix of the second, using regular expressions.
        /// </summary>
        /// <param name="s1">A string consisting of English alphabetic letters.</param>
        /// <param name="s2">A string consisting of English alphabetic letters.</param>
        /// <returns>The result of merging/overlapping <paramref name="s1"/> with <paramref name="s2"/>.</returns>
        string singkatanRegEx(string s1, string s2)
        {
            return Regex.Replace(s1 + " " + s2, @"(.*) \1.*", s2);
        }
    }
}
