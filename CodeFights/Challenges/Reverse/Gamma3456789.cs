using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "gamma3456789": 
    /// https://codefights.com/challenge/NKvpmHc3tXYerYKH7
    /// </summary>
    public class Gamma3456789
    {
        /// <summary>
        /// Returns the gamma of a number, modulo 3456789.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns>The gamma of <paramref name="n"/>, modulo 3456789.</returns>
        public long gamma3456789(int n)
        {
            long g = 1;
            while (--n * g > 0)
            {
                g = g * n % 3456789;
            }
            return g;
        }
    }
}