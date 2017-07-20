using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "nextGameOfLife": 
    /// https://codefights.com/challenge/J9tdW6Fo7FiHmsqk4
    /// 
    /// Conway's Game of Life is a zero-player game that simulates a population 
    /// of growing cells. Every cell interacts with its neighbors, which are 
    /// the cells that are vertically, horizontally, or diagonally adjacent. At 
    /// each step in time, the following changes take place:
    /// - Any live cell with fewer than two live neighbors (underpopulation) or 
    ///   more than three live neighbors (overpopulation) dies;
    /// - Any live cell with two or three live neighbors lives on to the next 
    ///   generation;
    /// - Any dead cell with exactly three live neighbors becomes a new live 
    ///   cell (reproduction).
    /// Given a population matrix of integers where 1 and 0 represent live and 
    /// dead cells, respectively, determine the state of the population after 
    /// one step in time.
    /// </summary>
    public class NextGameOfLife
    {
        /// <summary>
        /// Returns the state of a population in Conway's Game of Life after one step in time.
        /// </summary>
        /// <param name="seed">A rectuangular matrix of <c>1</c>s and <c>0</c>s representing live and dead cells, respectively.</param>
        /// <returns>The state of <paramref name="seed"/> after one step in time.</returns>
        public int[][] nextGameOfLife(int[][] seed) =>
            // iterate per row
            seed.Select((_, r) =>
            // iterate per column
            _.Select((v, c) =>
            {
                // offset to distinguish between (live, 3 neighbors) and (dead, 4 neighbors)
                v = -v;

                // iterate from 8 to 0 for each position of a 3 x 3 grid centered at (r, c) and sum values
                for (int i = 9; i-- > 0;)
                {
                    try
                    {
                        v += 2 * seed[r - 1 + i / 3][c - 1 + i % 3];
                    }
                    catch { }
                }

                // restrict values of c to total 3 live cells (5 or 6) or live cell with 3 live neighbors (max 7)
                return v > 4 ? 7 / v : 0;
            }
            ).ToArray()).ToArray();
    }
}
