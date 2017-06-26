using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "primeClimb": 
    /// https://codefights.com/challenge/exviHuziJjMp9hk4v
    /// 
    /// Given a positive integer n, calculate its prime factorization (using 
    /// exponents) in increasing factor order, and concatenate all the digits, 
    /// including exponents.
    /// 
    /// Example: n = 60 = 2^2 × 3 × 5 => "2235"
    /// </summary>
    public class PrimeClimb
    {
        /// <summary>
        /// Returns a string representing the digits of the ordered prime factorization using exponents of a number.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns>THe digits of the ordered prime factorization of <paramref name="n"/>.</returns>
        public string primeClimb(int n)
        {
            var sb = new StringBuilder();

            // incrementally try each possible divisor until the root of the original number is reached
            for (int divisor = 2, root = (int)Math.Sqrt(n); divisor <= root; divisor++)
            {
                // repeatedly reduce by divisor if it is a factor
                int exponent = 0;
                for (; n % divisor < 1; n /= divisor)
                {
                    // count the exponent
                    exponent++;
                }

                // update answer if number was divisible by any positive power of divisor
                if (exponent > 0)
                {
                    sb.Append(divisor);

                    // bring down non-trivial exponent
                    if (exponent > 1)
                        sb.Append(exponent);
                }

                // at this point, n is coprime with all numbers that are divisible by any non-trivial number less than or equal to divisor
            }

            // clean-up step: remaining value is the last prime factor (don't add 1 because it is non-prime)
            if (n > 1)
                sb.Append(n);

            return sb.ToString();
        }
    }
}
