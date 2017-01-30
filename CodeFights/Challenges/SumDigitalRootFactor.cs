using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge: 
    /// https://codefights.com/challenge/pNs68Sh3W25u7hRaP
    /// 
    /// Consider a function F(n) as the maximum possible sum of the digital 
    /// roots for all possible factorizations (excluding 1) of a number. For 
    /// example, for n = 12: 
    /// 12 = 2 * 2 * 3: Σ(digital roots) = root(2) + root(2) + root(3) 
    ///                                  = 2 + 2 + 3 = 7
    /// 12 = 4 * 3 : root(4) + root(3) = 7
    /// 12 = 2 * 6: root(2) + root(6) = 8
    /// 12 = 12: root(12) = 3
    /// 2 * 6 produces a maximum possible digital roots sum of 8.
    /// 
    /// For a given number N, find Σ(F(K)) Ɐ positive K ≤ N.
    /// </summary>
    /// <example>
    /// </example>
    public class SumDigitalRootFactor
    {
        /// <summary>
        /// Returns the maximum possible sum of the digital roots of all factorizations of a series of sequential numbers greater than 1.
        /// </summary>
        /// <param name="n">The largest number in the sequence to factorize and sum digital roots for.</param>
        /// <returns>The maximum sum of the digital roots of all factorizations of all numbers greater than 1, up to <paramref name="n"/> (inclusive).</returns>
        public int sumDigitalRootFactor(int n)
        {
            var rootFactorSums = new int[n + 1];
            return Enumerable.Range(2, n - 1).Sum(_ => MaxRootFactorSum(_, rootFactorSums));
        }

        /// <summary>
        /// Returns the maximum possible sum of the digital roots of a number's factors.
        /// </summary>
        /// <param name="n">The number to factorize and sum digital roots for.</param>
        /// <param name="rootFactorSums">An array </param>
        /// <returns>The maximum sum of the digital roots of all possible factorizations of <paramref name="n"/>.</returns>
        int MaxRootFactorSum(int n, int[] rootFactorSums)
        {
            // seed with the number itself, since n / 1 = n
            rootFactorSums[n] = DigitalRoot(n);
            if (n > 9) // no digital root factor sum exists for n < 10 that is > n
            {
                // test all possible factorizations in increasing order
                for (int i = 2, r = (int)Math.Sqrt(n); i <= r; i++)
                {
                    if (n % i == 0)
                    {
                        // maximum sum is the larger of itself and the sum of a pair of divisors' largest sums (either of which will include all smaller factors)
                        rootFactorSums[n] = Math.Max(rootFactorSums[n], rootFactorSums[i] + rootFactorSums[n / i]);
                    }
                }
            }
            return rootFactorSums[n];
        }

        /// <summary>
        /// Returns the digital root of a positive integer.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns>The digital root of <paramref name="n"/>.</returns>
        int DigitalRoot(int n)
        {
            return n < 10 ? n : DigitalRoot(n.ToString().Sum(_ => _ - '0'));
        }
    }
}
