using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "AFM_numbers": 
    /// https://codefights.com/challenge/T6G5FmTpmM6rfd8id
    /// </summary>
    public class AFMNumbers
    {
        /// <summary>
        /// Returns the numbers whose binary representations represent the two possible antiferromagnet states in an n-site chain.
        /// </summary>
        /// <param name="b">The length of the antiferromagnet chain.</param>
        /// <returns>A sorted array of two numbers whose binary representations represent the antiferromagnet states of a <paramref name="b"/>-site chain.</returns>
        public int[] AFM_numbers(int b)
        {
            b = 0x55555555 >> 31 - b;
            return new[] { b / 2, b };
        }
    }
}
