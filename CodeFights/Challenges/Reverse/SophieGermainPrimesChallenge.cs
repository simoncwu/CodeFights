using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "SophieGermainPrimes": 
    /// https://codefights.com/challenge/REsoj6NnHZYpA8zfa
    /// </summary>
    public class SophieGermainPrimesChallenge
    {
        /// <summary>
        /// Counts the number of Sophie Germain primes in a set of positive integers.
        /// </summary>
        /// <param name="n">A set of positive integers.</param>
        /// <returns>The number of Sophie Germain primes in <paramref name="n"/>.</returns>
        public int SophieGermainPrimes(int[] n)
        {
            return n.Sum(_ => Prime(_) * Prime(2 * _ + 1));
        }

        /// <summary>
        /// Determines whether or not a number is prime.
        /// </summary>
        /// <param name="n">The number to test.</param>
        /// <returns><c>1</c> if <paramref name="n"/> is prime; otherwise, <c>0</c>.</returns>
        int Prime(int n)
        {
            for (int i = 2, r = (int)Math.Sqrt(n); i <= r;)
            {
                if (n % i++ < 1)
                    return 0;
            }
            return n > 1 ? 1 : 0;
        }
    }
}
