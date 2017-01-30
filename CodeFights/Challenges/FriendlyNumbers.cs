using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "friendly_numbers": 
    /// https://codefights.com/challenge/zeS6of248AhuJB3xM
    /// 
    /// Two numbers are considered "friendly" if they differ and the sum of 
    /// the proper divisors of each number is equal to the other number. Given 
    /// two integers, determine whether or not they are friendly.
    /// </summary>
    public class FriendlyNumbers
    {
        /// <summary>
        /// Determines whether or not two numbers are "friendly".
        /// </summary>
        /// <param name="x">The first integer to compare.</param>
        /// <param name="y">The second integer to compare.</param>
        /// <returns><c>Yes</c> if <paramref name="x"/> and <paramref name="y"/> are friendly; otherwise, <c>No</c>.</returns>
        public string friendly_numbers(int x, int y)
        {
            return x != y && DivisorsSum(x) == y && DivisorsSum(y) == x ? "Yes" : "No";
        }

        /// <summary>
        /// Calculates the sum of an integer's proper divisors.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns></returns>
        int DivisorsSum(int n)
        {
            int sum = 1;
            for (int i = 2, r = (int)Math.Sqrt(n); i <= r; i++)
            {
                if (n % i == 0)
                {
                    sum += i * i < n ? i + n / i : i;
                }
            }
            return sum;
        }
    }
}
