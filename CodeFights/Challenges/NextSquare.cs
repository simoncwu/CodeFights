using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "nextSquare": 
    /// https://codefights.com/challenge/DCMvQpeqXo3EjPjG3
    /// 
    /// Given an integer, return the smallest perfect square greater than it.
    /// </summary>
    public class NextSquare
    {
        /// <summary>
        /// Returns the smallest perfect square greater than a given integer.
        /// </summary>
        /// <param name="n">A nonnegative integer.</param>
        /// <returns>The smallest square greater than <paramref name="n"/>.</returns>
        public int nextSquare(int n)
        {
            int a = 0;
            for (; a < n / ++a;) ;
            return a * a;
        }
    }
}
