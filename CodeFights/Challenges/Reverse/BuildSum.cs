using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "buildSum": 
    /// https://codefights.com/challenge/YqTsRei3LjHNaByFP
    /// </summary>
    public class BuildSum
    {
        /// <summary>
        /// Returns the sum of all integers from 0 to a specified number, each raised to itself as a power.
        /// </summary>
        /// <param name="n">A nonnegative integer.</param>
        /// <returns>The sum of k^k for all k from 0 to <paramref name="n"/>.</returns>
        public int buildSum(int n) => n < 1 ? 1 : (int)Math.Pow(n, n) + buildSum(n - 1);
    }
}
