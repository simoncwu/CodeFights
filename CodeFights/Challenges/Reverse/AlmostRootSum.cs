using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "almostRootSum": 
    /// https://codefights.com/challenge/myTuytYfXXEN5mr6z
    /// </summary>
    public class AlmostRootSum
    {
        /// <summary>
        /// Returns the ceiling of the square root of a number, plus the integer one less than it.
        /// </summary>
        /// <param name="n">An integer greater than 1.</param>
        /// <returns>The ceiling of the square root of <paramref name="n"/>, plus the integer one less than it.</returns>
        public int almostRootSum(int n)
        {
            int i = 0;
            // increment until square of i is >= n (ceiling of root)
            for (; ++i < n / i;) ;
            return i + i - 1;
        }
    }
}
