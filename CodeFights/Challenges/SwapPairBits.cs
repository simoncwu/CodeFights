using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "swapPairBits": 
    /// https://codefights.com/challenge/EYpoYCY6FNTKeimZx
    /// 
    /// Given a non-negative integer, swap the bits at two given positions in 
    /// its binary representation and return the resulting value.
    /// </summary>
    public class SwapPairBits
    {
        /// <summary>
        /// Returns the result of swapping two bits of an integer.
        /// </summary>
        /// <param name="k">A nonnegative integer.</param>
        /// <param name="p1">The 1-based index from the right of a bit to swap.</param>
        /// <param name="p2">The 1-based index from the right of a bit to swap.</param>
        /// <returns>The number obtained by swapping bits <paramref name="p1"/> and <paramref name="p2"/> in <paramref name="k"/>.</returns>
        public long swapPairBits(long k, int p1, int p2)
        {
            return k ^ (k = (k >> --p1 ^ k >> --p2) & 1) << p1 ^ k << p2;
        }
    }
}
