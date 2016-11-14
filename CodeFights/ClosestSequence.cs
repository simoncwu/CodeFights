using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "closestSequence2": 
    /// https://codefights.com/challenge/Qjts7cukDvYpDW4Bc
    /// 
    /// The difference between two sequences of the same length a1, a2, a3,
    /// ..., an and b1, b2, b3,..., bn can be defined as the sum of absolute 
    /// differences between their respective elements:
    /// diff(a, b) = |a1 - b1| + |a2 - b2| + ... + |an - bn|.
    /// 
    /// For the given sequences a and b (not necessarily having the same 
    /// lengths) find a subsequence b' of b such that diff(a, b') is minimal. 
    /// Return this difference.
    /// </summary>
    /// <example>
    /// For a = [1, 2, 6] and b = [0, 1, 3, 4, 5], the output should be closestSequence2(a, b) = 2.
    ///
    /// The best subsequence will be b' = [1, 3, 5] which has a difference of 2 with a.
    ///</example>
    class ClosestSequence
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">The first sequence to compare. 3 ≤ a.length ≤ 1000, -1000 ≤ a[i] ≤ 1000.</param>
        /// <param name="b">The second sequence to compare. a.length ≤ b.length ≤ 1000, -1000 ≤ b[i] ≤ 1000.</param>
        /// <returns>The minimal sum of absolute differences between sequences <paramref name="a"/> and b' (subsequence of <paramref name="b"/>).</returns>
        int closestSequence2(int[] a, int[] b)
        {
            // calculate all differences
            int choices = b.Length - a.Length + 1;
            int[,] diffs = new int[choices, a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0, end = choices; j < end; j++)
                {
                    diffs[j, i] = Math.Abs(a[i] - b[i + j]);
                }
            }

            int min;
            // accumulate and bubble-up sums
            // per column
            for (int i = a.Length - 2; i >= 0; i--)
            {
                int nexti = i + 1;
                // per choice
                for (int j = 0; j < choices; j++)
                {
                    min = int.MaxValue;
                    // per next column choice
                    for (int k = j; k < choices; k++)
                    {
                        if (diffs[k, nexti] < min)
                            min = diffs[k, nexti];
                    }
                    diffs[j, i] += min;
                }
            }

            // find min in first column
            min = int.MaxValue;
            for (int i = 0; i < choices; i++)
            {
                if (diffs[i, 0] < min)
                    min = diffs[i, 0];
            }
            return min;
        }
    }
}
