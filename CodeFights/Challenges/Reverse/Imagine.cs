using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "imagine": 
    /// https://codefights.com/challenge/vwrjaSzc2egE3FiYf
    /// </summary>
    public class Imagine
    {
        /// <summary>
        /// Computes the product of two complex numbers.
        /// </summary>
        /// <param name="a">The real part of the first complex number.</param>
        /// <param name="b">The imaginary part of the first complex number.</param>
        /// <param name="c">The real part of the second complex number.</param>
        /// <param name="d">The imaginary part of the second complex number.</param>
        /// <returns>The product of the specified complex numbers as a two-element array of its real and imaginary parts, respectively.</returns>
        public int[] imagine(int a, int b, int c, int d)
        {
            return new[] { a * c - b * d, a * d + b * c };
        }
    }
}
