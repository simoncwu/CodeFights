using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "digitSumInverse": 
    /// https://codefights.com/challenge/w6JSeYrX4s2DSSbfQ
    /// 
    /// Find the number of non-negative integers with a maximum number of 
    /// digits where the sum of each number's digits is equal to a target 
    /// sum.
    /// </summary>
    public class DigitSumInverse
    {
        /// <summary>
        /// Returns the number of non-negative integers of a maximum digit length with a specified sum of its digits.
        /// </summary>
        /// <param name="sum">The target sum of digits for each integer to be counted.</param>
        /// <param name="numberLength">The maximum number of digits for each integer to be counted.</param>
        /// <returns>The number of non-negative integers with <paramref name="numberLength"/> or fewer digits whose digit sum is <paramref name="sum"/>.</returns>
        public int digitSumInverse(int sum, int numberLength)
        {
            var counts = new int[sum + 1];
            counts[0] = 1;
            // for each digit
            for (int i = 0; i < numberLength; i++)
            {
                // reverse iterate from theoretical max sum thus far
                for (int j = Math.Min(sum, 9 * i); j >= 0; j--)
                {
                    // process sums j + 1 through j + 9
                    for (int k = j, l = Math.Min(sum, j + 9); ++k <= l;)
                    {
                        // carry over counts from j because j + (new digit) = k
                        counts[k] += counts[j];
                    }
                }
            }
            return counts[sum];
        }
    }
}
