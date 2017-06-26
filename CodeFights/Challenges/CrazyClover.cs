using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "crazyClover": 
    /// https://codefights.com/challenge/x8HkBKBW8PxKApXPs
    /// 
    /// Determine whether or not a clover with a potentially very large number 
    /// of leaves (i.e., cannot be stored by a built-in numeric data type) is 
    /// lucky. A clover is lucky if it's number of leaves is a multiple of 4.
    /// </summary>
    public class CrazyClover
    {
        /// <summary>
        /// Determines whether or not a clover is lucky.
        /// </summary>
        /// <param name="leaves">The number of leaves on the clover.</param>
        /// <returns><c>true</c> if the clover's number of leaves is a multiple of 4, and therefore lucky; otherwise, <c>false</c>.</returns>
        public bool crazyClover(string leaves)
        {
            int n = 0;
            foreach (var digit in leaves)
            {
                // let n overflow because divisibility-by-4 property is still preserved
                n += n + digit;
            }
            return n % 4 == 0;
        }
    }
}
