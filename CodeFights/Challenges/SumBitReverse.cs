using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "sumBitReverse": 
    /// https://codefights.com/challenge/j336JGvw3qnyBsqpp
    /// 
    /// Let's define a function f(x, y) of two positive integers as follows: 
    /// 1. reverse the bits in the binary representations of each number
    /// 2. sum the obtained values
    /// 3. reverse the bits in the result.
    /// 
    /// Given an array of numbers, construct a square matrix where the value at each [i, j] is equal to f(numbers[i], numbers[j]).
    /// </summary>
    public class SumBitReverse
    {
        /// <summary>
        /// Generates f(x, y) for every possible pair of values in an array.
        /// </summary>
        /// <param name="numbers">An array of integers.</param>
        /// <returns>A square matrix where each [i, j] contains the value of f(<paramref name="numbers"/>[i], <paramref name="numbers"/>[j]).</returns>
        public long[][] sumBitReverse(long[] numbers) => numbers.Select(x => numbers.Select(y => ReverseBits(ReverseBits(x) + ReverseBits(y))).ToArray()).ToArray();

        /// <summary>
        /// Reverses the order of the bits in an integer.
        /// </summary>
        /// <param name="x">An integer.</param>
        /// <param name="n"></param>
        /// <returns></returns>
        long ReverseBits(long x, long n = 0) => x < 1 ? n : ReverseBits(x / 2, n + n + x % 2);
    }
}
