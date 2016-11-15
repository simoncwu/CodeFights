using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "primeDigits": 
    /// https://codefights.com/challenge/PYqXBbXgEoDeZmJm3
    /// 
    /// You are given a positive integer N, your task is to calculate the 
    /// total number of primes less than or equal to N with additional 
    /// requirement that each digit of those primes should be a prime number 
    /// itself.
    /// </summary>
    /// <example>
    /// For N = 11, the output should be primeDigits(11) = 4.
    /// 
    /// There are 5 primes less than N or equal to it: 2, 3, 5, 7 and 11. But 
    /// there is a digit 1 (even two of them) in 11, and 1 is not a prime 
    /// number. Thus, the answer is 4.
    /// </example>
    class PrimeDigits
    {
        /// <summary>
        /// Calculates the total number of primes up to (and including) a specific number whose digits are all primes.
        /// </summary>
        /// <param name="N">The ending prime number. 0 ≤ N ≤ 1000000.</param>
        /// <returns>The number of primes less than or equal to <paramref name="N"/> and comprising of prime digits.</returns>
        int primeDigits(int N)
        {
            int ct = 0;
            while (N > 1)
            {
                // more efficient to check the number's digits' primality before checking its own primality
                if (IsPrimeDigits(N) && IsPrime(N))
                    ct++;
                N--;
            }
            return ct;
        }

        /// <summary>
        /// Determines whether or not a number's individual digits are all prime numbers.
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns><c>true</c> if <paramref name="n"/>'s individual digits are all prime numbers; otherwise, <c>false</c>.</returns>
        bool IsPrimeDigits(int n)
        {
            foreach (char c in n.ToString())
            {
                // more efficient to convert and check each digit for primality simultaneously
                if (!IsPrime(c - '0'))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether or not a number is prime.
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns><c>true</c> if <paramref name="n"/> is prime; otherwise, <c>false</c>.</returns>
        bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for (int i = 2, end = (int)Math.Sqrt(n); i <= end; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
