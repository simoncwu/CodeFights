using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "candyCrush2": 
    /// https://codefights.com/challenge/eeABFLMYpFvSoe6Ls
    /// 
    /// Given a Candy Crush gameboard, determine if a move from a given cell in 
    /// a given direction is a valid move, i.e., if it will result in a board 
    /// state where at least three candies of the same type are grouped in a 
    /// single row or column. The move is guaranteed to occur wholly within the 
    /// boundaries of the board. It is also guaranteed that the board's current 
    /// state does not already contain any groups of three candies of the same 
    /// type in a single row or column.
    /// </summary>
    public class CandyCrush2
    {
        /// <summary>
        /// Indicates whether or not a move on a Candy Crush board will result in a combination of candies.
        /// </summary>
        /// <param name="gameboard">A rectangular Candy Crush gameboard matrix where each cell's value indicates its candy type.</param>
        /// <param name="cell">The location of a cell that is the origin of a move, in the format [row, column] (0-based indices).</param>
        /// <param name="direction">A direction in which to move, which is one of 'U' (up), 'D' (down), 'L' (left), or 'R' (right).</param>
        /// <returns><c>true</c> if the move creates a group of at least three candies of the same type in a single row or column; otherwise, <c>false</c>.</returns>
        public bool candyCrush2(char[][] gameboard, int[] cell, char direction)
        {
            // copy board so as to leave state unaltered
            var g = gameboard.Select(_ => _.Select(o => o).ToArray()).ToArray();

            // map direction to row and column coordinate offset
            int r = cell[0], c = cell[1], d = direction - 79;
            direction = g[r][c];
            g[r][c] = g[r -= d / 6][c += 3 / d];
            g[r][c] = direction;
            return new CandyCrush1().candyCrush1(g);
        }
    }
}
