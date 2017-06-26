using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "dDelta": 
    /// https://codefights.com/challenge/E5pfJa5D7jsWFgBai
    /// 
    /// Given a nonnegative integer number in base 10, return the difference 
    /// between its smallest and largest digits in the given base.
    /// </summary>
    public class DDelta
    {
        /// <summary>
        /// Returns the difference between a base-10 number's smallest and largest digits in an arbitrary base.
        /// </summary>
        /// <param name="number">A nonnegative integer.</param>
        /// <param name="numberBase">A numeric base ≥ 2.</param>
        /// <returns>The difference between the largest and the smallest digits of <paramref name="number"/> in base <paramref name="numberBase"/>.</returns>
        public int dDelta(int number, int numberBase)
        {
            // The largest possible digit is the base (minus 1), but can't be greater than the number itself.
            int min = Math.Min(number, numberBase), max = 0, digit;
            for (; number > 0; number /= numberBase)
            {
                digit = number % numberBase;
                if (digit < min)
                    min = digit;
                if (digit > max)
                    max = digit;
            }
            return max - min;
        }
    }
}
