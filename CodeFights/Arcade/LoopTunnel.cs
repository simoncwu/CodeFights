using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade
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

    }
}