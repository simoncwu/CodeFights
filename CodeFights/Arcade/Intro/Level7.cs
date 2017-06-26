using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 1":
    /// https://codefights.com/arcade/intro/level-7
    /// </summary>
    class Level7
    {
        /// <summary>
        /// Given a circle of n evenly spaced numbers (0-based), find the number that radially opposite to a specified number.
        /// </summary>
        /// <param name="n">The total, even number of numbers in the circle.</param>
        /// <param name="firstNumber">A nonnegative number less than <paramref name="n"/>.</param>
        /// <returns>The number in the circle that is radially opposite to <paramref name="firstNumber"/>.</returns>
        int circleOfNumbers(int n, int firstNumber)
        {
            return (n + firstNumber - n / 2) % n;
        }

        /// <summary>
        /// You have deposited a specific amount of dollars into your bank account with a fixed interest rate that is paid annually. Find out how many years it will be until your balance reaches a specific threshold on interest alone.
        /// </summary>
        /// <param name="deposit">The initial deposit of funds into the account, in whole dollars.</param>
        /// <param name="rate">The rate of interest paid to the account annually.</param>
        /// <param name="threshold">The target balance.</param>
        /// <returns>The number of years until the balance reaches <paramref name="threshold"/>.</returns>
        int depositProfit(int deposit, int rate, int threshold)
        {
            int years = 0;
            // change type to support cents
            decimal balance = deposit;
            while (balance < threshold)
            {
                balance += rate * balance / 100;
                years++;
            }
            return years;
        }

        /// <summary>
        /// Returns the smallest value in a sorted array of integers whose sum of absolute differences from the other values in the array is minimal.
        /// </summary>
        /// <param name="a">A non-empty array of integers, sorted in increasing order.</param>
        /// <returns>The smallest element of <paramref name="a"/> that has a minimal sum of absolute differences from the other elements.</returns>
        int absoluteValuesSumMinimization(int[] a)
        {
            int x = a[0], diff = int.MaxValue;

            // potentially simplify calculations by grouping identical values
            var counts = a.GroupBy(_ => _);

            foreach (var n in counts)
            {
                // calculate sum of differences from other values
                int d = counts.Sum(_ => _.Count() * Math.Abs(_.Key - n.Key));
                if (d < diff)
                {
                    diff = d;
                    x = n.Key;
                }
            }
            return x;

            // or, take the median (not sure how algorithmically accurate this is, but it works for all the test cases)
            //return a[~-a.Length / 2];
        }

        /// <summary>
        /// Indicates whether or not it is possible to rearrange an array of equal-length strings such that each string differs from the next one by exactly one character.
        /// </summary>
        /// <param name="inputArray">A non-empty array of strings of equal length.</param>
        /// <returns><c>true</c> if such a rearragement is possible; otherwise, <c>false</c>.</returns>
        bool stringsRearrangement(string[] inputArray)
        {
            Func<string[], string, bool> S = null;
            S = (array, s) =>
            // empty
            !array.Any() ||
            array.Where((_, i) =>
            // positional characters differ by exactly 1
            _.Where((c, j) => c != s[j]).Count() == 1 &&
            // recursively test each string and exclude from next array by its position in array
            S(array.Where((o, j) => i != j).ToArray(), _)).Any();
            return inputArray.Any(_ => S(inputArray, _));
        }
    }
}
