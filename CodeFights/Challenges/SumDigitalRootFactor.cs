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
    /// For all possible factorizations (excluding 1) of a number, calculate 
    /// the sum of the digital roots of those factors and return the maximum 
    /// possible sum.
    /// For each case, calculate sum of digital roots of all factors and 
    /// efine maximum possible sum of digital roots for the given N among all its factorizations as F(N). For instance, F(12) = 2 + 6 = 8, F(7) = 7(7), F(24) = 3 + 8 = 11.
    /// For the given N, find Σ F(K), 1 < K ≤ N where Σ stands for sum operation.
    /// </summary>
    /// <example>
    /// For N = 12: 
    /// 12 = 2 * 2 * 3: sum(digital roots) = root(2) + root(2) + root(3) = 2 + 2 + 3 = 7
    /// 12 = 4 * 3 : root(4) + root(3) = 7
    /// 12 = 2 * 6: root(2) + root(6) = 8
    /// 12 = 12: root(12) = 3
    /// 2 * 6 produces a maximum possible digital roots sum of 8.
    /// </example>
    public class SumDigitalRootFactor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="N">2 ≤ N ≤ 5 · 10^5.</param>
        /// <returns></returns>
        public int sumDigitalRootFactor(int N)
        {
            var roots = new int[N + 1];
            return Enumerable.Range(2, N - 1).Sum(n => MaxRootSum(n, roots));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="roots"></param>
        /// <returns></returns>
        int MaxRootSum(int n, int[] roots)
        {
            roots[n] = Root(n);
            if (n > 9)
            {
                for (int i = 2, r = (int)Math.Sqrt(n); i <= r; i++)
                {
                    if (n % i == 0)
                    {
                        roots[n] = Math.Max(roots[n], roots[i] + roots[n / i]);
                    }
                }
            }
            return roots[n];
        }

        /// <summary>
        /// Returns the digital root of a positive integer.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns>The digital root of <paramref name="n"/>.</returns>
        int Root(int n)
        {
            return n < 10 ? n : Root(n.ToString().Sum(d => d - '0'));
        }
    }
}
