using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "maxVassal": 
    /// https://codefights.com/challenge/kfNdzuQtQZ23MPDZx/solutions
    /// 
    /// Given a positive integer, calculate the value of its maximum vassal. A 
    /// number k is considered to be a vassal of number n if k^3 is less than 
    /// n, and k^3 and n share a common non-trivial (greater than 1) divisor.
    /// </summary>
    public class MaxVassal
    {
        /// <summary>
        /// Returns a number's maximum vassal.
        /// </summary>
        /// <param name="num">A positive integer.</param>
        /// <returns>The maximum vassal of <paramref name="num"/>.</returns>
        public int maxVassal(int num)
        {
            int i = (int)Math.Pow(num, 1D / 3);
            while (GCD(num, i) == 1)
            {
                i--;
            }
            return i;
        }

        /// <summary>
        /// Returns the Greatest Common Divisor of two integers.
        /// </summary>
        /// <param name="a">An integer to compare.</param>
        /// <param name="b">An integer to compare.</param>
        /// <returns>The Greatest Common Divisor of <paramref name="a"/> and <paramref name="b"/>.</returns>
        int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

    }
}
