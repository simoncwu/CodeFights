using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "reverseVowelsOfString": 
    /// https://codefights.com/interview/9JbYrEhK9tz6ANKLC
    /// 
    /// Given a string as input, return the string with only the vowels 
    /// reversed. For the purposes of this exercise, 'y' is not a vowel.
    /// </summary>
    public class ReverseVowelsOfString
    {
        /// <summary>
        /// Reverses only the vowels in a string.
        /// </summary>
        /// <param name="s">The string whose vowels are to be reversed.</param>
        /// <returns>The value of <paramref name="s"/> with its vowels reversed.</returns>
        public string reverseVowelsOfString(string s)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var reverse = new char[s.Length];
            // reverse vowels by reverse searching for each vowel when one is requested in sequence and saving search position across requests
            for (int i = 0, j = s.Length; i < s.Length; i++)
            {
                var c = s[i];
                reverse[i] = vowels.Contains(c) ? s[j = s.LastIndexOfAny(vowels, --j)] : c;
            }
            return new string(reverse);
        }
    }
}
