using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "toBeContinued": 
    /// https://codefights.com/challenge/TLsLu3m26FFXgoaf8
    /// </summary>
    public class ToBeContinued
    {
        /// <summary>
        /// Returns an array of the quotients in each step of Euclid's algorithm for finding the Greatest Common Divisor of two nonnegative integers.
        /// </summary>
        /// <param name="f">An array of the two nonnegative integers whose GCD is to be computed.</param>
        /// <returns>An array of the quotients in each step of Euclid's algorithm for computing the GCD of the values in <paramref name="f"/>.</returns>
        public int[] toBeContinued(int[] f)
        {
            return GetEuclidQuotients(f).ToArray();
        }

        /// <summary>
        /// Returns the quotients in each step of Euclid's algorithm for finding the Greatest Common Divisor of two nonnegative integers.
        /// </summary>
        /// <param name="f">An array of the two nonnegative integers whose GCD is to be computed.</param>
        /// <returns>An <see cref="IEnumerable{Int32}"/> of the quotients in each step of Euclid's algorithm for computing the GCD of the values in <paramref name="f"/>.</returns>
        IEnumerable<int> GetEuclidQuotients(int[] f)
        {
            while (f[1] > 0)
            {
                yield return f[0] / f[1];
                f[1] = f[0] % (f[0] = f[1]);
            }
        }
    }
}