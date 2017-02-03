using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.TheCore
{
    /// <summary>
    /// Solutions for CodeFights Arcade level Intro Gates: 
    /// https://codefights.com/arcade/code-arcade/intro-gates
    /// </summary>
    class IntroGates
    {
        /// <summary>
        /// Returns the sum of a two-digit integer's digits.
        /// </summary>
        /// <param name="n">A positive two-digit integer.</param>
        /// <returns>The sum of the digits of the input number.</returns>
        int addTwoDigits(int n)
        {
            return n.ToString().Sum(_ => _ - '0');
        }

        /// <summary>
        /// Returns the largest number that contains a specific number of digits.
        /// </summary>
        /// <param name="n">The number of digits in the result. 1 ≤ n ≤ 7.</param>
        /// <returns>The largest integer of length <paramref name="n"/>.</returns>
        int largestNumber(int n)
        {
            return (int)Math.Pow(10, n) - 1;
        }

        /// <summary>
        /// Returns the number of whole pieces of candy that can be given to a number of children when distributed equally per child.
        /// </summary>
        /// <param name="n">The number of children.</param>
        /// <param name="m">The number of pieces of candy available for distribution.</param>
        /// <returns>The total number of whole pieces of candy that can be distributed.</returns>
        int candies(int n, int m)
        {
            return m - m % n;
        }

        /// <summary>
        /// Returns the number of seats in a theater strictly behind a given seat and in its column or to the left.
        /// </summary>
        /// <param name="nCols">The number of columns in the theater.</param>
        /// <param name="nRows">The number of rows in the theater.</param>
        /// <param name="col">The seat's column number (incrementing from right to left).</param>
        /// <param name="row">The seat's row number.</param>
        /// <returns>The number of seats strictly behind the given seat and in its column or to the left.</returns>
        int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }

        /// <summary>
        /// Returns the largest positive integer such that: it is divisible by a given divisor and is less than or equal to a given bound.
        /// </summary>
        /// <param name="divisor">The divisor. 1 ≤ divisor.</param>
        /// <param name="bound">The largest number that can be returned.</param>
        /// <returns>The largest integer not greater than <paramref name="bound"/> that is divisible by <paramref name="divisor"/>.</returns>
        int maxMultiple(int divisor, int bound)
        {
            return bound - bound % divisor;
        }

        /// <summary>
        /// Returns the number which is written in the radially opposite position to a given number in a circle of equidistant integers increasing from 0 to n - 1.
        /// </summary>
        /// <param name="n">A positive, even integer.</param>
        /// <param name="firstNumber">An integer from 0 to <paramref name="n"/> - 1.</param>
        /// <returns>The number radially opposite to <paramref name="firstNumber"/>.</returns>
        int circleOfNumbers(int n, int firstNumber)
        {
            return (firstNumber + n / 2) % n;
        }

        /// <summary>
        /// Returns the sum of the digits of the hh:mm format equivalent of a timespan given in minutes.
        /// </summary>
        /// <param name="n">The timespan, in minutes. It is guaranteed to be less than 24 hours.</param>
        /// <returns>The sum of the digits of <paramref name="n"/> when expressed in hh:mm format.</returns>
        int lateRide(int n)
        {
            int h = n / 60, m = n % 60;
            return h / 10 + h % 10 + m / 10 + m % 10;
        }

        /// <summary>
        /// Returns the duration of the longest call possible with a given starting balance at specific per-minute rates.
        /// </summary>
        /// <param name="min1">The cost of the first minute.</param>
        /// <param name="min2_10">The per-minute cost of minutes 2 to 10.</param>
        /// <param name="min11">The cost of each minute after the 10th.</param>
        /// <param name="s">The amount of money available to make the call.</param>
        /// <returns>The duration of the longest call possible, in whole minutes.</returns>
        int phoneCall(int min1, int min2_10, int min11, int s)
        {
            int duration = 0;

            // first minute
            if (s >= min1)
            {
                duration++;
                s -= min1;

                // number of minutes from 2 - 10
                int d2 = Math.Min(s / min2_10, 9);
                if (d2 > 0)
                {
                    duration += d2;
                    s -= min2_10 * d2;

                    // minutes 11 and on, only if 10th minute was possible
                    if (d2 == 9)
                    {
                        duration += s / min11;
                    }
                }
            }
            return duration;
        }
    }
}