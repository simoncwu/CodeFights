using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "lucas": 
    /// https://codefights.com/challenge/FGWntJmJm2ErFuv9u
    /// </summary>
    public class Lucas
    {
        /// <summary>
        /// Returns the n-th values of the Lucas sequences U(P, Q) and V(P, Q).
        /// </summary>
        /// <param name="p">The value of P.</param>
        /// <param name="q">The value of Q.</param>
        /// <param name="n">The index of the values to retrieve.</param>
        /// <returns>The <paramref name="n"/>-th Lucas sequence values as an array in the format [U(n), V(n)].</returns>
        public long[] lucas(int p, int q, int n)
        {
            // base case values for n = 0
            long u = 0, v = 2;
            for (; n-- > 0;)
            {
                // store current u for use in generating next v
                var previousU = u;
                u = p * u + v >> 1;
                v = (p * p - 4 * q) * previousU + p * v >> 1;
            }
            return new[] { u, v };
        }
    }
}
