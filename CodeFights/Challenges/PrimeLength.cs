using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "primeLength": 
    /// https://codefights.com/challenge/dAKnq75kgYntsoviN
    /// 
    /// Given a non-negative integer N, return the total number of digits in all the primes less than N.
    /// </summary>
    public class PrimeLength
    {
        /// <summary>
        /// Returns the total number of digits in all the prime integers less than a specified number.
        /// </summary>
        /// <param name="n">The upper limit (exclusive) of primes to include.</param>
        /// <returns>The total number of digits in all the primes less than <paramref name="n"/>.</returns>
        public int primeLength(int n)
        {
            int l = n > 2 ? 1 : 0;
            for (int i = 3; i < n; i += 2)
            {
                l += PrimeDigits(i);
            }
            return l;
        }

        /// <summary>
        /// Returns the number of digits in a prime number.
        /// </summary>
        /// <param name="n">The number to examine.</param>
        /// <returns>The number of digits in the <paramref name="n"/> if it is prime; otherwise, 0.</returns>
        int PrimeDigits(int n)
        {
            if (n % 2 == 0 && n != 2 || n < 2)
                return 0;
            int i = 3, root = (int)Math.Sqrt(n);
            while (i <= root && n % i > 0)
            {
                i += 2;
            }
            return i > root ? n.ToString().Length : 0;
        }
    }
}
