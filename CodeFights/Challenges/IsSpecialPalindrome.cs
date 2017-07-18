using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isSpecialPalindrome": 
    /// https://codefights.com/challenge/H3xfuW74xaSgAXaSt
    /// 
    /// Given an integer, determine whether or not its binary representation 
    /// is a special palindrome that contains exactly one 0 and at least one 1.
    /// </summary>
    public class IsSpecialPalindrome
    {
        /// <summary>
        /// Indicates whether or not the binary representation of an integer is a special palindrome of all 1s except for a single 0 at the midpoint.
        /// </summary>
        /// <param name="n">A nonnegative integer.</param>
        /// <returns><c>true</c> if the binary representation of <paramref name="n"/> is a special palindrome; otherwise, <c>false</c>.</returns>
        public bool isSpecialPalindrome(int n) => 
            // at least one 1
            n > 0 & 
            // left of rightmost 0 == right of rightmost 0
            ++n / (n &= -n) / 2 == n - 1;
    }
}
