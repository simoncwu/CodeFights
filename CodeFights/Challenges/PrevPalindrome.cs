using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "prevPalindrome": 
    /// https://codefights.com/challenge/PQCRmQjcY32TARpWh
    /// 
    /// Given a positive integer, find the largest palindromic number smaller 
    /// than it.
    /// </summary>
    public class PrevPalindrome
    {
        /// <summary>
        /// Returns the largest palindromic integer less than a specified positive integer.
        /// </summary>
        /// <param name="x">A positive integer.</param>
        /// <returns>The largest palindromic integer less than <paramref name="x"/>.</returns>
        public int prevPalindrome(int x)
        {
            for (; --x + "" != string.Concat((x + "").Reverse());) ;
            return x;
        }
    }
}
