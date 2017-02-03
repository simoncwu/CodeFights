using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.TheCore
{
    /// <summary>
    /// Solutions for CodeFights Arcade level "Loop Tunnel": 
    /// https://codefights.com/arcade/code-arcade/loop-tunnel
    /// </summary>
    class LoopTunnel
    {
        /// <summary>
        /// Find the smallest factorial greater than or equal to a given integer.
        /// </summary>
        /// <param name="n">The minimum value of the factorial to find.</param>
        /// <returns>The smallest factorial greater than or equal to <paramref name="n"/>.</returns>
        int leastFactorial(int n)
        {
            int k = 1, i = 1;
            while (k < n)
            {
                k *= ++i;
            }
            return k;
        }

        /// <summary>
        /// Returns the number of distinct ways to represent an integer as a sum of two integers within a given range.
        /// </summary>
        /// <param name="n">The number to represent.</param>
        /// <param name="l">The lower bound (inclusive) of the range of numbers available for summing.</param>
        /// <param name="r">The upper bound (inclusive) of the range of numbers available for summing.</param>
        /// <returns>The number of distinct ways to sum two numbers within the given range to make <paramref name="n"/>.</returns>
        int countSumOfTwoRepresentations2(int n, int l, int r)
        {
            int ways = 0;
            while (l < n)
            {
                int b = n - l;
                if (b >= l && b <= r)
                    ways++;
                l++;
            }
            return ways;

            // O(1) implementation
            if (l + l > n || r + r < n)
                return 0;

            r = Math.Min(r, n - l);
            l = Math.Max(l, n - r);
            return 1 + (r - l) / 2;
        }

        /// <summary>
        /// Returns the total payout from a magic well that dispenses a product of two numbers amount each time a magic marble is thrown into it.
        /// </summary>
        /// <param name="a">The first number used to determine the amount of money the well dispenses. Increases by 1 after each use.</param>
        /// <param name="b">The second number used to determine the amount of money the well dispenses. Increases by 1 after each use.</param>
        /// <param name="n">The number of magic marbles to be thrown into the well.</param>
        /// <returns>The total payout of the well.</returns>
        int magicalWell(int a, int b, int n)
        {
            int money = 0;
            while (n-- > 0)
            {
                money += a++ * b++;
            }
            return money;
        }

        /// <summary>
        ///  Returns the number of times a group of students are guaranteed to all be facing the same direction while following a sequence of commands, even if some can't tell left from right.
        /// </summary>
        /// <param name="commands">A sequence of commands consisting of 'A' for turn around, 'R' for turn right, and 'L' for turn left.</param>
        /// <returns>The number of times the students will be facing the same direction.</returns>
        int lineUp(string commands)
        {
            bool same = true;
            int count = 0;
            foreach (char c in commands)
            {
                switch (c)
                {
                    case 'A':
                        if (same)
                            count++;
                        break;
                    case 'L':
                    case 'R':
                        if (!same)
                            count++;
                        same = !same;
                        break;
                }
            }
            return count;
        }

        /// <summary>
        /// Adds two numbers without carrying.
        /// </summary>
        /// <param name="param1">The first number to add.</param>
        /// <param name="param2">The second number to add.</param>
        /// <returns>The sum of <paramref name="param1"/> and <paramref name="param2"/> if no values are carried over.</returns>
        int additionWithoutCarrying(int param1, int param2)
        {
            int sum = 0, col = 1;
            while (param1 > 0 || param2 > 0)
            {
                sum += (param1 + param2) % 10 * col;
                param1 /= 10;
                param2 /= 10;
                col *= 10;
            }
            return sum;
        }

        /// <summary>
        /// Returns the difference between the sum of the squares of all even integers and the sum of the squares of all odd integers in a sequential series of numbers starting from 1.
        /// </summary>
        /// <param name="k">The last number in the series.</param>
        /// <returns>The difference between the sum of the squares of even integers and the sum of the squares of odd integers from 1 to <paramref name="k"/>.</returns>
        int appleBoxes(int k)
        {
            int sign = k % 2 > 0 ? 1 : -1, diff = 0;
            while (k > 0)
            {
                diff += (sign *= -1) * k * k--;
            }
            return diff;
        }

        /// <summary>
        /// Determines wether or not it is possible to increase the number of trailing zeros in an integer by swapping two of its digits.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <returns><c>true</c> if it's possible to the number of trailing zeros; otherwise, <c>false</c>.</returns>
        bool increaseNumberRoundness(int n)
        {
            while (n % 10 == 0)
            {
                n /= 10;
            }
            while (n > 0)
            {
                if (n % 10 == 0)
                    return true;
                n /= 10;
            }
            return false;
        }

        /// <summary>
        /// Rounds an integer using a tail-rounding approach, which is to repeatedly round its least significant digit until only one non-zero digit remains.
        /// </summary>
        /// <param name="value">A positive integer.</param>
        /// <returns>The tail-rounded value of <paramref name="value"/>.</returns>
        int rounders(int value)
        {
            int e = 10;
            while (value > e && (value % e > 0 || value / e > 10))
            {
                value = (value + e / 2) / e * e;
                e *= 10;
            }
            return value;
        }

        /// <summary>
        /// Returns the total number of candles that can be burned if leftovers from each burning can be combined to make a new candle.
        /// </summary>
        /// <param name="candlesNumber">The number of candles available to burn.</param>
        /// <param name="makeNew">The number of candle leftovers required to make a new candle.</param>
        /// <returns>The total number of candles that can be burned, including those made from leftovers.</returns>
        int candles(int candlesNumber, int makeNew)
        {
            int leftover = 0, total = 0;
            while (candlesNumber > 0)
            {
                total += candlesNumber;
                leftover += candlesNumber;
                candlesNumber = leftover / makeNew;
                leftover %= makeNew;
            }
            return total;
        }

        /// <summary>
        /// Returns the number of cells that intersect the diagonal in a rectangular grid.
        /// </summary>
        /// <param name="n">The number of rows in the grid.</param>
        /// <param name="m">The number of columns in the grid.</param>
        /// <returns>The number of cells that intersect the diagonal.</returns>
        int countBlackCells(int n, int m)
        {
            decimal start = 0, end = start, slope = (decimal)n / m;
            int cells = 0;
            for (int i = 0; i < m; i++)
            {
                end = start + slope;
                int si = (int)start, ei = (int)Math.Ceiling(end);
                cells += ei - si;
                if (si > 0 && start == si)
                    cells++;
                if (ei < n && end == ei)
                    cells++;
                start = end;
            }
            return cells;
        }
    }
}