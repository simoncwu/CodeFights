using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "squaresUnderQueenAttack": 
    /// https://codefights.com/interview-practice/task/awcwfd2TXRvoFhnPH
    /// Asked By: Google
    /// 
    /// Are given an n × n chessboard, the positions of multiple queens, and 
    /// several queries, each represented by a position on the chessboard. For 
    /// each query, determine whether or not the position is within a line of 
    /// attack by any of the queens.
    /// 
    /// The solution should have O(queries.length + queens.length + n) 
    /// complexity and allocate O(n) additional memory.
    /// </summary>
    public class SquaresUnderQueenAttack
    {
        /// <summary>
        /// Indicates for each query in an array of queries whether or not a position can be attacked by any of several queens on a chessboard.
        /// </summary>
        /// <param name="n">The size of the chessboard.</param>
        /// <param name="queens">An array of the positions of all queens, where each position is a two-element array of the 0-based row and column coordinates, respectively.</param>
        /// <param name="queries">An array of positions on the chessboard, where each position is a two-element array of the 0-based row and column coordinates, respectively.</param>
        /// <returns>An array of values indicating whether or not each respective query position can be attacked by a queen.</returns>
        public bool[] squaresUnderQueenAttack(int n, int[][] queens, int[][] queries)
        {
            // under attack columns
            var cols = new bool[n];
            // under attack rows
            var rows = new bool[n];
            // under attack diagonals (positive slope, y-intercept offset by n as index)
            var diag1 = new bool[2 * n];
            // under attack diagonals (negative slope, y-intercept as index)
            var diag2 = new bool[2 * n];

            // preprocess all queens and flag the paths that are aligned with each queen
            foreach (var q in queens)
            {
                // same row as queen
                rows[q[0]] = true;
                // same column as queen
                cols[q[1]] = true;
                // same positive slope diagonal as queen (y - x = b)
                diag1[q[0] - q[1] + n] = true;
                // same negative slope diagonal as queen (y + x = b)
                diag2[q[0] + q[1]] = true;
            }

            // for each query, check if position's row, column, or diagonals (via y-intercept) were flagged during preprocessing of queens
            return queries.Select(_ => rows[_[0]] || cols[_[1]] || diag1[_[0] - _[1] + n] || diag2[_[0] + _[1]]).ToArray();
        }

    }
}
