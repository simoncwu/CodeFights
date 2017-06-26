using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "sum4Squares": 
    /// https://codefights.com/challenge/rMNLxtfo9gDcECcaP
    /// 
    /// Given a non-negative integer, count the number of ways to represent it 
    /// as a sum of squares of exactly 4 integers (positive, negative, or 0), 
    /// where the order of the integers matters.
    /// </summary>
    public class Sum4Squares
    {
        /// <summary>
        /// Counts the number of ordered ways to represent an integer as a sum of 4 squares.
        /// </summary>
        /// <param name="k">A nonnegative integer.</param>
        /// <returns>The number of ordered ways to represent <paramref name="k"/> as a sum of 4 squares.</returns>
        public long sum4Squares(long k)
        {
            // using Lagrange and Jacobi's four-square theorems: 
            // 8 times the sum of all divisors not divisible by 4
            long sum = 0;
            for (long i = 1; i * i <= k; i++)
            {
                // test for divisor of k
                if (k % i == 0)
                {
                    // sum divisors that are not divisible by 4
                    if (i % 4 != 0)
                        sum += i;

                    var j = k / i;
                    if (i != j && j % 4 != 0) // distinct divisors only
                        sum += j;
                }
            }
            return k == 0 ? 1 : 8 * sum;
        }
    }
}
