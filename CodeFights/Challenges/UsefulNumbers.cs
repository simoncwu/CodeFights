using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "usefulNumbers": 
    /// https://codefights.com/challenge/WzAnYbosFHf7DaFuz
    /// 
    /// A number i is considered to be useful to k if (i + k) == (i | k). Given 
    /// a positive integer k, calculate the number of nonnegative integers less 
    /// than or equal to k that are useful to k.
    /// </summary>
    public class UsefulNumbers
    {
        /// <summary>
        /// Counts the number of nonnegative integers less than or equal a given number that are useful to it.
        /// </summary>
        /// <param name="k">A positive integer.</param>
        /// <returns>The number of nonnegative integers less than or equal to <paramref name="k"/> that are useful to it.</returns>
        public int usefulNumbers(int k)
        {
            // Since 0 | [0, 1] == 0 + [0, 1], double the answer for every 0 
            // bit. The result is k with all 1-bits removed, except the most 
            // significant bit.
            while (k > (k & -k))
            {
                // k & -k isolates rightmost 1-bit, k & k - 1 clears it
                k &= k - 1;
                // right shift to drop the bit just cleared
                k >>= 1;
            }
            return k;
        }
    }
}
