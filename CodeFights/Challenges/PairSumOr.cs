using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "pairSumOr": 
    /// https://codefights.com/challenge/NbDwPvtLjfXBB63Wx
    /// 
    /// Given an array of nonnegative integers, calculate the sum of the 
    /// bitwise OR results of all possible pairings of integers in it.
    /// </summary>
    public class PairSumOr
    {
        /// <summary>
        /// Calculates the sum of the bitwise OR result of all possible pairings of integers in an array.
        /// </summary>
        /// <param name="arr">An array of nonnegative integers.</param>
        /// <returns>The sum of the bitwise OR result of all possible pairings of integers in <paramref name="arr"/>.</returns>
        public long pairSumOr(int[] arr)
        {
            long sum = 0, n = arr.Length;
            // loop over each possible nonnegative integer bit
            for (int i = 0; i < 31; i++)
            {
                int power = 1 << i;
                // count # of unset bits at position i
                long k = arr.Sum(_ => ~_ >> i & 1);

                // Every pair of numbers (n Choose 2) contributes 2^i to the 
                // answer, except pairs of 0 (k Choose 2).
                sum += power * (n * ~-n - k * ~-k) / 2;

                // Alternatively, we can count the number of set bits and apply 
                // the same formula to its n-complement. The resulting 
                // combinatorial expression is n(n-1)/2-(n-k)(n-k-1)/2, which 
                // reduces to k(2n-k-1).
                /*
                long k = arr.Sum(_ => _ >> i & 1);
                sum += k * power * (2 * arr.Length + ~k) / 2;
                */
            }
            return sum;
        }
    }
}