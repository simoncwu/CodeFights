using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "sumDivisors": 
    /// https://codefights.com/challenge/A9hB67Kfqc7ADHGCo
    /// 
    /// Given a non-negative integer, calculate the sum of its non-prime divisors.
    /// </summary>
    public class SumDivisors
    {
        /// <summary>
        /// Returns the sum of the non-prime divisors of a non-negative integer.
        /// </summary>
        /// <param name="number">The integer to sum divisors for.</param>
        /// <returns>The sum of the non-prime divisors of </returns>
        public int sumDivisors(int number)
        {
            int sum = 0;
            // try up to √n
            for (int d = 1, r = (int)Math.Sqrt(number); d <= r; d++)
            {
                if (number % d == 0)
                {
                    // divisor
                    sum += d * NotPrime(d);

                    // quotient
                    int D = number / d;
                    if (D != d) // don't double-process square roots
                        sum += D * NotPrime(D);
                }
            }
            return sum;
        }

        /// <summary>
        /// Determines whether or not a number is prime.
        /// </summary>
        /// <param name="n">The number to test.</param>
        /// <returns><c>true</c> if <paramref name="n"/> is prime; otherwise, <c>false</c>.</returns>
        int NotPrime(int n)
        {
            for (int i = 2, root = (int)Math.Sqrt(n); i <= root;)
            {
                if (n % i++ == 0)
                    return 1;
            }
            return n > 1 ? 0 : 1;
        }
    }
}
