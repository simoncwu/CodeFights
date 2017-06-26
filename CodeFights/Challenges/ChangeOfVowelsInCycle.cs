using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "changeOfvowelsInCycle": 
    /// https://codefights.com/challenge/CA2ShAfLkb5D5JHCG
    /// 
    /// Given a string of text, reverse the order of its characters and then 
    /// right-rotate its vowels by a given offset. The vowels to be considered 
    /// are 'a', 'e', 'i', 'o', and 'u'.
    /// </summary>
    public class ChangeOfVowelsInCycle
    {
        /// <summary>
        /// Reverses a string of text and rotates its vowels.
        /// </summary>
        /// <param name="cycle">The offset by which to right-rotate vowels.</param>
        /// <param name="text">A string of characters.</param>
        /// <returns>The result of reversing <paramref name="text"/> and right-rotating its vowels by <paramref name="cycle"/> positions.</returns>
        public string changeOfVowelsInCycle(int cycle, string text)
        {
            var vowels = text.Where(IsVowel).ToArray();
            int n = vowels.Length, i = n + cycle;
            var sb = new StringBuilder();
            foreach (var c in text.Reverse())
            {
                sb.Append(IsVowel(c) ? vowels[--i % n] : c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns whether or not a character is a vowel.
        /// </summary>
        /// <param name="c">A character.</param>
        /// <returns><c>true</c> if <paramref name="c"/> is a vowel; otherwise, <c>false</c>.</returns>
        bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
            //return "	 			 			 					 					 					"[_ % 32] > 9;
        }
    }
}
