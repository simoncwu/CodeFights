using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.TheCore
{
    /// <summary>
    /// Solutions for CodeFights Arcade level Intro Gates: 
    /// https://codefights.com/arcade/code-arcade/corner-of-0s-and-1s
    /// </summary>
    class CornerOf0sAnd1s
    {
        /// <summary>
        /// Clears the k-th rightmost bit of a number.
        /// </summary>
        /// <param name="n">The number to alter.</param>
        /// <param name="k">The 1-based index of the bit to clear (counting from the right).</param>
        /// <returns>The result of the bit-wise modification.</returns>
        int killKthBit(int n, int k)
        {
            return n & ~(1 << --k);
        }

        /// <summary>
        /// Packs up to four non-negative integers into a single number.
        /// </summary>
        /// <param name="a">An array of up to four numbers to pack together, in order of increasing byte significance.</param>
        /// <returns>The result of packing the lowest byte values of <paramref name="a"/> into a new 32-bit integer.</returns>
        int arrayPacking(int[] a)
        {
            return a.Reverse().Aggregate((r, v) => (r << 8) + v);
        }

        /// <summary>
        /// Returns the number of 1s in the binary representations of all numbers within a specified range.
        /// </summary>
        /// <param name="a">The lower bound of the range, inclusive.</param>
        /// <param name="b">The upper bound of the range, inclusive.</param>
        /// <returns>The number of binary 1s in the numbers from <paramref name="a"/> to <paramref name="b"/>.</returns>
        int rangeBitCount(int a, int b)
        {
            int c = 0;
            while (a <= b)
            {
                int i = a - ((a++ >> 1) & 0x55555555);
                i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
                c += (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
            }
            return c;
        }

        /// <summary>
        /// Reverses the order of the bits in a given integer.
        /// </summary>
        /// <param name="n">The integer to reverse.</param>
        /// <returns>The value of the bit-wise reverse of <paramref name="n"/>.</returns>
        int mirrorBits(int n)
        {
            int m = 0;
            while (n > 0)
            {
                m = m << 1 | n & 1;
                n >>= 1;
            }
            return m;
        }

        /// <summary>
        /// Returns the number that represents the rightmost 0 bit in a given number's binary representation.
        /// </summary>
        /// <param name="n">The number to examine for a rightmost 0 bit.</param>
        /// <returns>The number has as its only set bit the rightmost 0 bit in <paramref name="n"/>.</returns>
        int secondRightmostZeroBit(int n)
        {
            return ((n = (n | (n + 1))) | (n + 1)) ^ n;

            // by converting to a binary string and calculating indices:
            //return 1 << (int)Math.Log(n, 2) >> Convert.ToString(n, 2).Remove(Convert.ToString(n, 2).LastIndexOf('0')).LastIndexOf('0');
        }

        /// <summary>
        /// Returns the result of swapping adjacent binary bits by pairs in a 32-bit integer.
        /// </summary>
        /// <param name="n">The number to change.</param>
        /// <returns>The result of swapping adjacent binary bits by pairs in <paramref name="n"/>.</returns>
        int swapAdjacentBits(int n)
        {
            return ((n & 0x55555555) << 1) | ((n & -0x55555556) >> 1);

            // recursive solution:
            //return n > 0 ? (((n & 1) == (n >> 1 & 1) ? n : n ^ 3) & 3) | (swapAdjacentBits(n >> 2) << 2) : 0;
        }

        /// <summary>
        /// Returns the number that represents the rightmost bit in which two given numbers' binary representations differ.
        /// </summary>
        /// <param name="n">The first number to compare.</param>
        /// <param name="m">The second number to compare.</param>
        /// <returns>The number that has as its only set bit the rightmost bit in which <paramref name="n"/> and <paramref name="m"/> differ.</returns>
        int differentRightmostBit(int n, int m)
        {
            return (n ^= m) & -n;
        }

        /// <summary>
        /// Returns the number that represents the rightmost bit in which two given numbers' binary representations match.
        /// </summary>
        /// <param name="n">The first number to compare.</param>
        /// <param name="m">The second number to compare.</param>
        /// <returns>The number that has as its only set bit the rightmost bit in which <paramref name="n"/> and <paramref name="m"/> match.</returns>
        int equalPairOfBits(int n, int m)
        {
            return (n = ~n ^ m) & -n;
        }
    }
}
