using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isSuperPalindrome": 
    /// https://codefights.com/challenge/HRfkmH66XAMDBfcAd
    /// 
    /// A string is considered to be a super palindrome of rank k if all 
    /// prefixes of length k * 2^j for all positive j are also 
    /// palindromes. Given a string and rank, determine whether it's a super 
    /// palindrome or not.
    /// </summary>
    public class IsSuperPalindrome
    {
        /// <summary>
        /// Indicates whether or not a string is a super palindrome.
        /// </summary>
        /// <param name="s">A string of length 2 * <paramref name="k"/> or longer.</param>
        /// <param name="k">The rank of the super palindrome to test for.</param>
        /// <returns><c>true</c> if <paramref name="s"/> is a super palindrome of rank <paramref name="k"/>; otherwise, <c>false</c>.</returns>
        public bool isSuperPalindrome(string s, int k)
        {
            int l = 0, r = 0;
            return s.All(_ => 
            // increment right pointer, and stop if pointer is to the left of k (minimum prefix midpoint)
            r++ < k || 
            // Compare current character (at right pointer - 1) to mirror character (left pointer).
            // If left pointer is alread at 0 (start), set left pointer to left of current character.
            // Otherwise, decrement left pointer.
            _ == s[l -= l < 1 ? 2 - r : 1]);
        }
    }
}
