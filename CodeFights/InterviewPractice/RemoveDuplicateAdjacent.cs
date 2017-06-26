using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "removeDuplicateAdjacent": 
    /// https://codefights.com/interview/DT3wiw6t5mdjc2d2w
    /// 
    /// Given a string s, recursively remove all adjacent duplicate characters 
    /// until none remain.
    /// </summary>
    public class RemoveDuplicateAdjacent
    {
        /// <summary>
        /// Recursively removes all adjacent duplicate characters from a string until none remain.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <returns>A string obtained by recursively removing all adjacent duplicate characters from <paramref name="s"/>.</returns>
        public string removeDuplicateAdjacent(string s)
        {
            var sb = new StringBuilder();
            for (int i = 0, e = s.Length - 1; i <= e; i++)
            {
                // keep only letters not surrounded by duplicates
                if ((i == 0 || s[i] != s[i - 1]) && (i == e || s[i] != s[i + 1]))
                    sb.Append(s[i]);
            }
            // recurse until no more removals are possible
            return s.Length == (s = sb.ToString()).Length ? s : removeDuplicateAdjacent(s);
        }
    }
}
