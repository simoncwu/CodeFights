using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "incrementCipher": 
    /// https://codefights.com/challenge/ea9kjzNzE6dQGw8MY
    /// 
    /// You are given a string of lowercase English letters and an array of 
    /// nonnegative integers. For each number i in the array (1-based), 
    /// increment every i-th letter in the string once, with the increment of 
    /// 'z' cycling back to 'a'.
    /// </summary>
    public class IncrementCipher
    {
        /// <summary>
        /// Invrements the letters positioned at regular intervals in a string.
        /// </summary>
        /// <param name="s">A string containing lowercase English letters.</param>
        /// <param name="nums">An array of the intervals at which letters should be incremented.</param>
        /// <returns>The result of incrementing the letters of <paramref name="s"/> once at each interval in <paramref name="nums"/>.</returns>
        public string incrementCipher(string s, int[] nums)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length;)
            {
                // increment each letter the number of times its 1-based position is a multiple of the values in nums
                sb.Append((char)((s[i++] + nums.Count(o => i % o < 1)) % 97 % 26 + 97));
            }
            return sb.ToString();
        }
    }
}
