using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "successivePrimes": 
    /// https://codefights.com/challenge/WEurBmxNGxnuXxuHt
    /// 
    /// Given an array that is comprised of a successive range of prime numbers 
    /// except for one, find the missing number.It is guaranteed that there is 
    /// always exactly one number missing.
    /// </summary>
    public class SuccessivePrimes
    {
        /// <summary>
        /// Returns the missing number from a range of successive prine numbers.
        /// </summary>
        /// <param name="primes">An array of prime numbers.</param>
        /// <returns>The number missing from the prime number range <paramref name="primes"/>.</returns>
        public int successivePrimes(int[] primes)
        {
            Array.Sort(primes);
            int n = primes[0];
            // loop until a prime is found that is not the next successive prime
            for (int index = 0; n == primes[index++]; )
            {
                // test next number
                n++;
                for (int i = 2; i * i <= n; i++)
                {
                    // if not prime, reset loop counter and try next candidate
                    if (n % i == 0)
                        n += i = 1;
                }
            }
            return n;
        }
    }
}
