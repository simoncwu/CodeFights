using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "powery": 
    /// https://codefights.com/challenge/YKGzjAMzGz79cTAe2
    /// </summary>
    public class Powery
    {
        /// <summary>
        /// Returns the largest (by absolute value) power of a base that is less than or equal to a given number, augmented by the exponent.
        /// </summary>
        /// <param name="n">An integer.</param>
        /// <param name="b">An integer whose absolute value is greater than 1.</param>
        /// <returns>The largest (by absolute value) power of <paramref name="b"/> that is less than or equal to <paramref name="n"/>, plus the exponent.</returns>
        public int powery(int n, int b)
        {
            int x = 1, exponent = 0;
            for (; x * b <= n; exponent++)
            {
                x *= b;
            }
            return x + exponent;
        }
    }
}
