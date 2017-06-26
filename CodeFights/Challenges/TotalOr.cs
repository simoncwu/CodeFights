using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class TotalOr
    {
        /// <summary>
        /// Solution for CodeFights challenge "totalOr": 
        /// https://codefights.com/challenge/NXE7XwgYZvCXRY6PW
        /// 
        /// Given a non-negative integer k, calculate the result of the bitwise 
        /// OR operation of all the integers from 0 to k, inclusive.
        /// </summary>
        /// <param name="k">A nonnegative integer.</param>
        /// <returns>The result of the bitwise OR of all integers from 0 to <paramref name="k"/>, inclusive.</returns>
        public int totalOr(int k)
        {
            /* Since every less-significant bit is set by some number for all 
             * numbers < k, the result is k with every bit set.
             * Because the most significant bit for k > 0 is a 1, we can 
             * achieve this by right-shifting k and OR-ing it with the result 
             * until all bits are set.
             */
            while (k < (k |= k >> 1)) ;
            return k;
        }

    }
}
