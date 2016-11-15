using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "multiFactorial": 
    /// https://codefights.com/challenge/BNscgSLWRFdLM52Ed
    /// 
    /// We all know that the factorial of n is equal to the product of all 
    /// positive integers less than or equal to n. We define the m-factorial 
    /// of n to be the product of all positive integers less than or equal to 
    /// n that are congruent to n modulo m.
    /// 
    /// Two integers a and b are called congruent modulo m if a and b have 
    /// the same remainder when divided by m.
    /// 
    /// Given n and m, find the m-factorial of n. The result can be big, so 
    /// return the result modulo 10^9 + 7.
    /// </summary>
    /// <example>
    /// For n = 8, m = 3, the output should be multiFactorial(n, m) = 80.
    /// 
    /// 8 is equal to 2 modulo 3. There are three numbers less that or equal 
    /// to 8 that are equal to 2 modulo 3. These numbers are 2, 5, and 8. 
    /// Their product is 80.
    /// </example>
    class MultiFactorial
    {
        /// <summary>
        /// Returns the m-factorial of a number.
        /// </summary>
        /// <param name="n">A number to compute the m-factorial of. 0 ≤ n ≤ 2 · 10^9.</param>
        /// <param name="m">A number to perform modulo with. 1 ≤ m ≤ 2 · 10^9, n / m ≤ 10^6.</param>
        /// <returns>The m-factorial of <paramref name="n"/>.</returns>
        /// <remarks>The result is modulo 10^9 + 7.</remarks>
        int multiFactorial(int n, int m)
        {
            long r = n % m, f = 1;
            if (r == 0)
                r = m;
            while (r <= n)
            {
                f = f * r % 1000000007;
                r += m;
            }
            return Convert.ToInt32(f);
        }
    }
}
