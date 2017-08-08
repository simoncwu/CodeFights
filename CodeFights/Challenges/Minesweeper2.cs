using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "minesweeper2": 
    /// https://codefights.com/challenge/g6hd5k9Jfsfgs9hYF
    /// 
    /// Clicking on a Minesweeper gameboard cell can result in one of three 
    /// outcomes:
    /// 1. A non-zero cell will open only itself.
    /// 2. A zero cell will result in clicks to open all 8 neighboring cells.
    /// 3. A 9 cell is a mine and ends the game with a loss.
    /// Given a valid Minesweeper gameboard and a matrix of the initial 
    /// opening status for each cell, return the resulting opening status of 
    /// the board after executing a series of cell opening moves. If the game 
    /// ends in a loss at any point, return an empty matrix.
    /// </summary>
    public class Minesweeper2
    {
        public bool[][] minesweeper2(int[][] gameboard, bool[][] opening, int[][] moves)
        {
            // delegate for opening cells
            Action<int[]> Open = null;
            Open = m =>
            {
                int i = 9, r = m[0], c = m[1];

                // try/catch for skipping explicit bounds checking
                try
                {
                    // if cell is a mine, replace opening matrix with empty one
                    opening = gameboard[m[0]][m[1]] > 8 ? new bool[0][] : opening;

                    // skip opened cells
                    if (!opening[r][c])
                    {
                        // open cell and, if value is 0, recursively click all surrounding cells
                        for (opening[r][c] = true; gameboard[r][c] < 1 & i-- > 0;)
                        {
                            Open(new[] { r - 1 + i / 3, c - 1 + i % 3 });
                        }
                    }
                }
                catch { }
            };

            // execute each move
            Array.ForEach(moves, Open);

            return opening;
        }
    }
}
