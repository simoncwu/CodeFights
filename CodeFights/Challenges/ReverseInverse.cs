using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "reverseInverse": 
    /// https://codefights.com/challenge/bzkdx7vP3QJ8DgQTL
    /// 
    /// Given a string, apply the following transformation:
    /// 1. Find all the words in the string, where a word is a sequence of 
    ///    consecutive alphanumeric characters;
    /// 2. Reverse the characters in each word;
    /// 3. Set the case of each reversed character to be the opposite of the 
    ///    character at the corresponding position in the original, unreversed 
    ///    word.
    /// Return the resulting string.
    /// </summary>
    public class ReverseInverse
    {
        /// <summary>
        /// Reverses the characters of the words in a string, and inverts the casing at each character position.
        /// </summary>
        /// <param name="s">A string of characters.</param>
        /// <returns>The result of reversing the characters and inverting the casing at each position of each word in <paramref name="s"/>.</returns>
        public string reverseInverse(string s)
        {
            return Regex.Replace(s, "\\w+", _ => string.Concat((s = _.Value).Reverse().Select((c, i) => (char)(c % ' ' + "@ `"[s[i] % 96 / 32]))));
        }
    }
}
