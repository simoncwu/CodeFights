using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "gold": 
    /// https://codefights.com/challenge/ypaJW47zSBpJ3b7EJ
    /// 
    /// Goldbach's conjecture states that every even integer greater than 2 can 
    /// be expressed as the sum of two primes. Given an integeter (not 
    /// necessarily even) greater than 1, count the number of ways to express 
    /// it as the sum of two unordered primes.
    /// </summary>
    public class Gold
    {
        /// <summary>
        /// Counts the number of ways to express an integer greater than 1 as the sum of two primes.
        /// </summary>
        /// <param name="n">An integer greater than 1.</param>
        /// <returns>The number of ways to express <paramref name="n"/> as the sum of two unordered primes.</returns>
        public int gold(int n)
        {
            int count = 0;

            // track primes as 1, nonprimes as 0
            var primes = new int[n];

            // try every number from 2 to n - 1 (we skip n because in "n + 0 = n", 0 is not a prime)
            for (int i = 1; ++i < n;)
            {
                // non-performant basic primality test. if i is prime, x == i at the end of the loop.
                int x = 1;
                while (i % ++x > 0)
                {
                }

                // store primality result for i
                primes[i] = x /= i;

                // increment count
                count += x & primes[n - i];
            }
            return count;
        }
    }
}
