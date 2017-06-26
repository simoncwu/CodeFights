using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution to CodeFights interview practice "findFirstSubstringOccurrence" (formerly "strstr"): 
    /// https://codefights.com/interview-practice/task/C8Jdyk3ybixqQdAvM
    /// Asked By: Amazon, Facebook, Microsoft
    /// 
    /// Implement a function that finds the index of the first occurrence of 
    /// one string in another. If the substring does not occur, return -1.
    /// </summary>
    public class FindFirstSubstringOccurrence
    {
        /// <summary>
        /// Returns the zero-based index of the first occurrence of one string in another string.
        /// </summary>
        /// <param name="s">The string to seek in.</param>
        /// <param name="x">The string to seek.</param>
        /// <returns>The zero-based index position within <paramref name="s"/> of <paramref name="x"/> if found; otherwise, <c>-1</c>.</returns>
        public int strstr(string s, string x)
        {
            // Boyer-Moore-Horspool algorithm

            // preprocess and construct bad match skip table (per char)
            var badMatchSkipTable = new int[256].Select(_ => x.Length).ToArray();
            for (int i = 0; i < x.Length - 1;)
            {
                // T[i] represents the reverse index of the character i in x, or length of x if not found
                badMatchSkipTable[x[i]] = x.Length - ++i;
            }

            // main search algorithm
            // last possible position aligns end of x with end of s
            for (int index = 0; s.Length - index >= x.Length;)
            {
                // confirm match starting from end of x
                for (int rightIndex = x.Length - 1; s[index + rightIndex] == x[rightIndex]; rightIndex--)
                {
                    if (rightIndex == 0)
                        return index;
                }

                // Mismatch: advance search position such that current last character aligns with last occurrence in x, using skip table.
                // This allows us to advance the whole length of x if the last character does not occur in x.
                index += badMatchSkipTable[s[index + x.Length - 1]];
            }
            return -1;
        }

    }
}
