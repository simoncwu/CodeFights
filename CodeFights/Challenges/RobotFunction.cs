using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "robotFunction": 
    /// https://codefights.com/challenge/Z6N5AJif9WxYysSgy
    /// 
    /// A robot is attempting to convert positive integers to zero by dividing 
    /// even integers by 2 and decrementing odd integers by 1, only, until the 
    /// number becomes 0. The calculation complexity f(n) for any number n is 
    /// expressed as the product of the numbers of these two operations, or: 
    /// f(n) = a · b.
    /// 
    /// Find the total calculation complexity of zeroing all numbers within a 
    /// given range of numbers, inclusive; i.e., f(l) + f(l + 1) + ... + f(r).
    /// </summary>
    public class RobotFunction
    {
        /// <summary>
        /// Returns the total calculation complexity of zeroing a range of positive integers.
        /// </summary>
        /// <param name="l">The lower bound of the range of integers.</param>
        /// <param name="r">The upper bound of the range of integers, inclusive.</param>
        /// <returns>The total calculation complexity of zeroing all integers from <paramref name="l"/> to <paramref name="r"/>, inclusive.</returns>
        public long robotFunction(long l, long r)
        {
            return CalculationComplexityIterative(r) - CalculationComplexityIterative(l - 1);
        }

        /// <summary>
        /// Returns the total calculation complexity of zeroing all positive integers up to a maximum via recursion.
        /// </summary>
        /// <param name="n">The largest integer to zero.</param>
        /// <returns>The total calculation complexity of zeroing all integers from 1 to <paramref name="n"/>, inclusive.</returns>
        long CalculationComplexityRecursive(long n)
        {
            var log = (int)Math.Log(n, 2);
            var power = 1L << log;
            return n < 2 ? 0 : log * (CountBits(n -= power) + n + 1) + CalculationComplexityRecursive(power - 1);
        }

        /// <summary>
        /// Returns the total calculation complexity of zeroing all positive integers up to a maximum iteratively.
        /// </summary>
        /// <param name="n">The largest integer to zero.</param>
        /// <returns>The total calculation complexity of zeroing all integers from 1 to <paramref name="n"/>, inclusive.</returns>
        long CalculationComplexityIterative(long n)
        {
            long sum = 0, term = 1, pow = 1;
            var log = (int)Math.Log(n, 2);
            for (int i = 1; i < log; pow <<= 1)
            {
                term = 2 * term + pow;
                sum += i++ * term;
            }
            return sum + log * (CountBits(n -= 2 * pow) + n + 1);
        }

        /// <summary>
        /// Returns the number of set bits in the binary representations of a range of positive integers.
        /// </summary>
        /// <param name="n">The largest integer in the range.</param>
        /// <returns>The number of set bits in all integers from 1 to <paramref name="n"/>.</returns>
        long CountBits(long n)
        {
            long t = 0;
            // stop when power of 2 > n or exponent > 62 (64-bit signed integer max is < 2^63)
            for (int exp = 0, powerOf2 = 1; powerOf2 <= n && exp < 63; exp++, powerOf2 *= 2)
                // if exp-th bit is set
                if ((n & powerOf2) > 0)
                    t +=
                        powerOf2 / 2 * exp + 1 + // value for powers of 2 = 2^x * x / 2 + 1
                        n % powerOf2; // # of most-significant bits for #s > 2^x
            return t;
        }
    }
}