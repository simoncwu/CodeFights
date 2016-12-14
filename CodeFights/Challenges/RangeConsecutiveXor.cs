using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "rangeConsecutiveXor": 
    /// https://codefights.com/challenge/SJh6r935MqtFSKtqi
    /// 
    /// Consider a sequence: 
    /// X(1) = 1, X(2) = 1^2, X(3) = 1^2^3, ..., X(n) = 1^2^...^n.
    /// 
    /// Given l and r, find the value of X(l)^X(l+1)^X(l+2)^...^X(r).
    /// </summary>
    public class RangeConsecutiveXor
    {
        /// <summary>
        /// Returns the value of X(l)^X(l+1)^X(l+2)^...^X(r) where X(n) is the cumulative XOR value of all numbers from 1 to n.
        /// </summary>
        /// <param name="l">The lower bound of the X(n) range (inclusive).</param>
        /// <param name="r">The upper bound of the X(n) range (inclusive).</param>
        /// <returns>The value of X(<paramref name="l"/>)^X(l+1)^X(l+2)^...^X(<paramref name="r"/>).</returns>
        public int rangeConsecutiveXor(int l, int r)
        {
            return rangeConsecutiveXorByRangeSimplification(l, r);
        }

        /// <summary>
        /// Returns the cumulative XOR value of the X(n) of all n within a given range, where X(n) is the cumulative XOR value of all numbers from 1 to n, by reducing the range to a manageable, fixed-upper-limit subset.
        /// </summary>
        /// <param name="l">The lower bound of the X(n) range (inclusive).</param>
        /// <param name="r">The upper bound of the X(n) range (inclusive).</param>
        /// <returns>The value of X(<paramref name="l"/>)^X(l+1)^X(l+2)^...^X(<paramref name="r"/>).</returns>
        int rangeConsecutiveXorByRangeSimplification(int l, int r)
        {
            if (l == r)
                return X(l);
            switch (r % 4)
            {
                case 0:
                    return rangeConsecutiveXorByRangeSimplification(l, r - 1) ^ X(r);
                case 1:
                    return rangeConsecutiveXorByRangeSimplification(l, r - 1) ^ 1;
                case 3:
                    return rangeConsecutiveXorByRangeSimplification(l, r - 1);
            }
            int d = r - l;
            return d < 8 ? X(r) ^ rangeConsecutiveXorByRangeSimplification(l, r - 1) : rangeConsecutiveXorByRangeSimplification(l, l + d % 8);
        }

        /// <summary>
        /// Returns the cumulative XOR value of all positive integers less than or equal to a specified number.
        /// </summary>
        /// <param name="n">The largest integer to include in the computation.</param>
        /// <returns>The cumulative XOR value of all positive integers less than or equal to <paramref name="n"/>.</returns>
        int X(int n)
        {
            return new[] { n, 1, n + 1, 0 }[n % 4];
        }

        /// <summary>
        /// Returns the cumulative XOR value of the X(n) of all n within a given range, where X(n) is the cumulative XOR value of all numbers from 1 to n, by following the resulting pattern of possible values.
        /// </summary>
        /// <param name="l">The lower bound of the X(n) range (inclusive).</param>
        /// <param name="r">The upper bound of the X(n) range (inclusive).</param>
        /// <returns>The value of X(<paramref name="l"/>)^X(l+1)^X(l+2)^...^X(<paramref name="r"/>).</returns>
        int rangeConsecutiveXorByPattern(int l, int r)
        {
            return XX(r) ^ XX(l - 1);
        }

        /// <summary>
        /// Returns the cumulative XOR value of the X(n) of all positive integers less than or equal to a specified number, where X(n) is the cumulative XOR value of all numbers from 1 to n.
        /// </summary>
        /// <param name="n">The largest integer to include in the computation.</param>
        /// <returns>The cumulative XOR value of the X(n) of all positive integers less than or equal to <paramref name="n"/>.</returns>
        int XX(int n)
        {
            return new[] { n, 2, n + 2, 0 }[n % 8 / 2];
        }
    }
}
