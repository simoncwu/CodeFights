using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "areFollowingPatterns": 
    /// https://codefights.com/interview-practice/task/3PcnSKuRkqzp8F6BN
    /// Asked By: Google
    /// 
    /// Determine if an array follows the same pattern as another array. That 
    /// is, for all possible indices i and j, strings[i] = strings[j] if and 
    /// only if  patterns[i] = patterns[j].
    /// </summary>
    public class AreFollowingPatterns
    {
        /// <summary>
        /// Indicates whether or not an array follows a specified pattern.
        /// </summary>
        /// <param name="strings">An array of strings.</param>
        /// <param name="patterns">An array of pattern strings.</param>
        /// <returns><c>true</c> if <paramref name="strings"/> follows pattern <paramref name="patterns"/>.</returns>
        public bool areFollowingPatterns(string[] strings, string[] patterns)
        {
            var stringMap = new Dictionary<string, string>();
            var patternMap = new Dictionary<string, string>();
            for (int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                var p = patterns[i];

                // check for mismatch
                if (stringMap.ContainsKey(s) && stringMap[s] != p ||
                   patternMap.ContainsKey(p) && patternMap[p] != s)
                    return false;

                // add new (or re-add existing) mapping
                stringMap[s] = p;
                patternMap[p] = s;
            }
            return true;
        }

    }
}
