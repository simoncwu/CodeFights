using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "primeDistance": 
    /// https://codefights.com/challenge/e68HxZ8Qo5jF7Mjxi
    /// 
    /// Given a non-negative integer, calculate the distance between it and the closest prime integer.
    /// </summary>
    public class PrimeDistance
    {
        /// <summary>
        /// Returns the distance from a non-negative integer to the closest prime integer.
        /// </summary>
        /// <param name="number">The integer to start from.</param>
        /// <returns>The distance from <paramref name="number"/> to the closest prime integer.</returns>
        /// <remarks>0 ≤ number ≤ 9E14.</remarks>
        public int primeDistance(string number)
        {
            var n = long.Parse(number);
            int d = 0;
            while (!Prime(n + d) && !Prime(n - d))
            {
                d++;
            }
            return d;
        }

        /// <summary>
        /// Determines whether or not a number is prime.
        /// </summary>
        /// <param name="n">The number to test.</param>
        /// <returns><c>true</c> if <paramref name="n"/> is prime; otherwise, <c>false</c>.</returns>
        bool Prime(long n)
        {
            n = n < 2 ? 4 : n;
            int i = 2, root = (int)Math.Sqrt(n);
            while (i <= root)
            {
                if (n % i++ == 0)
                    return false;
            }
            return true;
        }
    }
}