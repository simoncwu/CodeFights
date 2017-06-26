using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "coolSubsets": 
    /// https://codefights.com/challenge/vHiHgQhfhvd5TM6mF
    /// 
    /// Let's define the coolness of a subset of an array as the bitwise OR of 
    /// all the values in the subset, divided by the length of the subset 
    /// (integer division). Calculate the number of position-distinct ways to 
    /// choose a non-empty proper subset of the array that has maximal 
    /// coolness.
    /// </summary>
    public class CoolSubsets
    {
        /// <summary>
        /// Returns the number of distinct ways to choose a non-empty proper subset of an array, with maximal coolness.
        /// </summary>
        /// <param name="a">An array of non-negative integers.</param>
        /// <returns>The number of distinct ways to choose a non-emty proper subset of <paramref name="a"/>, with maximal coolness.</returns>
        public long coolSubsets(int[] a)
        {
            int m = a.Max();
            /* Because of the division, the coolness of any subset with at 
             * least one positive number is largest when it consists of the 
             * largest number in it by itself. If there is more than one 
             * instance of the largest number, then each instance is a viable 
             * candidate.
             * 
             * Because 0 divided by any number is still zero, when the array 
             * contains only 0s, enumerate all the possible subset 
             * combinations. This can be compared to treating the array as a 
             * binary number and iterating through all the possible toggles of 
             * each bit, which is basically 2^0 through 2^(length of array).
             */
            return m > 0 ? a.Count(_ => _ == m) : (1L << a.Length) - 1;
        }
    }
}
