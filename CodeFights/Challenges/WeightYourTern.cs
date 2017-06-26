using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "weightYourTern": 
    /// https://codefights.com/challenge/GvRQ3ovd582FtMoNk
    /// 
    /// A balanced ternary numeral system is a system in which each number is represented in base 3 using three digits: -1, 0, and 1. For example, 8 in the decimal notation can be represented as 10(-1) in the balanced ternary system, since 10(-1)bal3 = 1 * 32 + 0 * 31 + (-1) * 30 = 9 + 0 - 1 = 8.
    /// Given a number n in the decimal numeral system, your task is to calculate the sum of its digits in the balanced ternary system.
    /// </summary>
    public class WeightYourTern
    {
        /// <summary>
        /// Returns t sum of the digits of an integer's balanced ternary representation.
        /// </summary>
        /// <param name="n">An integer.</param>
        /// <returns>The sum of the digits of <paramref name="n"/> in a balanced ternary system.</returns>
        public int weightYourTern(long n)
        {
            int sum = 0;
            for (; n > 0; n /= 3)
            {
                // To convert % values of { 2, 1, 0 } to { 1, 0, -1 }, we subtract 1. But that means we have to compensate by incrementing n by 1.
                sum += (int)(++n % 3) - 1;
            }

            // if n is negative, negate the sum of its positive counterpart
            return n < 0 ? -weightYourTern(-n) : sum;
        }
    }
}
