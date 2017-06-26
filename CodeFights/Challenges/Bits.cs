using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "bits": 
    /// https://codefights.com/challenge/BiEcfpJAevtSMXAaQ
    /// 
    /// Given a array of positive integers, attempt to maximize each value in 
    /// it by performing a single swap of any two bits in its binary 
    /// representation, and return the larger of the two.
    /// </summary>
    public class Bits
    {
        /// <summary>
        /// Attempts to maximize the numbers in an array by performing a single swap of any two bits in each number's binary representation.
        /// </summary>
        /// <param name="number">An array of positive integers.</param>
        /// <returns>An array containing, for every number in <paramref name="number"/>, the larger of itself and the maximum obtainable value from swapping two bits in its binary representation.</returns>
        public long[] bits(long[] number)
        {
            return number.Select(
                x => Math.Max(x,
                // clear rightmost 1
                x & ~-x |
                // set leftmost 0
                1L << (int)Math.Log(~x & x >> 1, 2))).ToArray();
        }
    }
}
