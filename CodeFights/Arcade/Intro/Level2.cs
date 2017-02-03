using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 2":
    /// https://codefights.com/arcade/intro/level-2
    /// </summary>
    class Level2
    {
        /// <summary>
        /// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
        /// </summary>
        /// <param name="inputArray">An array of integers containing at least two elements.</param>
        /// <returns>The largest product of adjacent elements.</returns>
        int adjacentElementsProduct(int[] inputArray)
        {
            int max = -2500;
            for (int i = 1; i < inputArray.Length;)
            {
                max = Math.Max(max, inputArray[i - 1] * inputArray[i++]);
            }
            return max;
        }

        /// <summary>
        /// A 1-interesting polygon is a square with a side of length 1. An n-interesting polygon is obtained by taking the n-1-interesting polygon and appending 1-interesting polygons to its rim side by side.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns>The area of the n-interesting polygon.</returns>
        /// <example>
        /// Examples of interesting polygons:
        ///                   □
        ///           □      □□□
        ///   □      □□□    □□□□□
        ///           □      □□□
        ///                   □
        /// n = 1   n = 2   n = 3
        /// </example>
        int shapeArea(int n)
        {
            return n == 1 ? 1 : 4 * --n + shapeArea(n);
        }

        /// <summary>
        /// Given an array of integers, we need to find the number of "holes" that need to be filled such that it contains all the integers from some range.
        /// </summary>
        /// <param name="sequence">An array of distinct integers.</param>
        /// <returns>The minimal number of integers that need to be added to <paramref name="sequence"/> such that it contains every integer from an interval [L, R] (for some L, R) and no other integers.</returns>
        int makeArrayConsecutive2(int[] sequence)
        {
            return sequence.Max() - sequence.Min() - sequence.Length + 1;
        }

        /// <summary>
        /// Given a sequence of integers, check whether it is possible to obtain a strictly increasing sequence by erasing no more than one element from it.
        /// </summary>
        /// <param name="sequence">An array of integers.</param>
        /// <returns><c>true</c> if it is possible, <c>false</c> otherwise.</returns>
        bool almostIncreasingSequence(int[] sequence)
        {
            int i = 0;
            Func<int, bool> f = _ => _ > sequence[i++];
            return sequence.Skip(1).SkipWhile(f).Skip(1).All(f);
        }

        /// <summary>
        /// In a rectangular matrix of integers, call an element top-zero-free if on top of that element (in the same column) there are no 0s. Find the sum of all top-zero-free elements.
        /// </summary>
        /// <param name="matrix">2-dimensional array of integers representing a rectangular matrix.</param>
        /// <returns>The sum of all top-zero-free elements in <paramref name="matrix"/>.</returns>
        int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            for (int c = 0; c < matrix[0].Length; c++)
            {
                sum += matrix.TakeWhile(_ => _[c] != 0).Sum(_ => _[c]);
            }
            return sum;
        }
    }
}
