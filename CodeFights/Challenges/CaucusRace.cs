using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solutions for CodeFights challenge "caucusRace": 
    /// https://codefights.com/challenge/XRMzBvaNTmSkSKZjt
    /// 
    /// Given a list of integers that represents a cycle, return the sorted 
    /// list of 0-based start positions where accumulating the values in order 
    /// (with looping) will always yield a positive aggregate sum.
    /// </summary>
    public class CaucusRace
    {
        /// <summary>
        /// Returns the ordered 0-based start positions of a cycle of numbers where accumulating the values in order will always yield a positive aggregate sum.
        /// </summary>
        /// <param name="values">A sequence of integers.</param>
        /// <returns>The 0-based start positions of <paramref name="values"/> that will always yield a positive aggregate sum.</returns>
        /// <remarks>This algorithm has a worst-case O(n^2) runtime complexity.</remarks>
        public int[] caucusRace(int[] values)
        {
            return values.Select((_, i) =>
            {
                int movesLeft = values.Length, balance = 0;
                // try to process one full cycle of values while keeping balance strictly positive
                while (movesLeft > 0 && (balance += values[i]) > 0)
                {
                    i = ++i % values.Length;
                    movesLeft--;
                }
                return balance > 0 ? i : -1;
            }).Where(_ => _ > -1).ToArray();
        }

        /// <summary>
        /// Returns the ordered 0-based start positions of a cycle of numbers where accumulating the values in order will always yield a positive aggregate sum.
        /// </summary>
        /// <param name="values">A sequence of integers.</param>
        /// <returns>The 0-based start positions of <paramref name="values"/> that will always yield a positive aggregate sum.</returns>
        /// <remarks>This algorithm has a worst-case O(n) runtime complexity.</remarks>
        public int[] CaucusRaceByPivot(int[] values)
        {
            var winningPositions = new LinkedList<int>();
            int balance = 0, minSum = 0, minSumPivot = 0;

            // find the minimum sum going forwards from position 0 to end
            foreach (int v in values)
            {
                minSum = Math.Min(minSum, balance += v);
            }

            // reverse iterate through array
            for (int i = values.Length - 1; i >= 0; i--)
            {
                int v = values[i];
                // find the minimum sum going forwards from position i to end
                minSumPivot = Math.Min(minSumPivot + v, v);
                // adjust minimum sum going forwards from 0, making it the minimum sum forwards from position i to end (> 1 cycle)
                minSum += v;
                // position i is a valid start if min sum remains positive to end AND for at least 1 cycle
                if (Math.Min(minSum, minSumPivot) > 0)
                {
                    // prepend to keep results in increasing order
                    winningPositions.AddFirst(i);
                }
            }

            return winningPositions.ToArray();
        }
    }
}
