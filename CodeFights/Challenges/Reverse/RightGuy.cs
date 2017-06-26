using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "rightGuy": 
    /// https://codefights.com/challenge/5W5Q5fNMiauqSgA6c
    /// </summary>
    public class RightGuy
    {
        /// <summary>
        /// Returns the 1-based position of the rightmost set bit in a nonnegative integer.
        /// </summary>
        /// <param name="k">A nonnegative integer.</param>
        /// <returns>The 1-based position of the rightmost set bit in <paramref name="k"/>, or <c>0</c> if no bits are set.</returns>
        public int rightGuy(int k)
        {
            return k < 1 ? 0 : k % 2 > 0 ? 1 : 1 + rightGuy(k / 2);
        }
    }
}
