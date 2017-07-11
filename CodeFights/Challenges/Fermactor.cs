using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "fermactor": 
    /// https://codefights.com/challenge/admES7uudjBkBNSB3
    /// 
    /// Fermat's factorization method represents an odd integer as a difference 
    /// of two squares: n = a^2 - b^2. Given an odd integer, return the values 
    /// of a and b as an array.
    /// </summary>
    public class Fermactor
    {
        /// <summary>
        /// Returns an array of the values of a and b for Fermat's factorization method of an odd integer.
        /// </summary>
        /// <param name="n">An odd integer.</param>
        /// <returns>An array containing the values of a and b such that a^2 - b^2 = <paramref name="n"/>.</returns>
        public int[] fermactor(int n)
        {
            int a = 0, b = 0;
            for (; n != 0;)
            {
                // The summation series "n + (n + 1)" generates perfect squares.
                // Since a^2 - b^2 = n, n - a^2 + b^2 = 0. So we try adjusting n by increasingly larger perfect squares for a^2 and b^2 until it equals 0.
                n += n < 0 ? b + ++b : -a - ++a;
            }
            return new[] { a, b };
        }
    }
}
