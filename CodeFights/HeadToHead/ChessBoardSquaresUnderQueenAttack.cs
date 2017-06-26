using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.HeadToHead
{
    /// <summary>
    /// Solution for CodeFights Head to Head fight 
    /// "chessBoardSquaresUnderQueenAttack":
    /// 
    /// Consider a rectangular chess board of a × b squares. For each of the 
    /// squares imagine a lone queen standing on that square and compute the 
    /// number of squares under the queen's attack. Return the sum of these 
    /// numbers for all of the queen's positions on the board.
    /// </summary>
    public class ChessBoardSquaresUnderQueenAttack
    {
        /// <summary>
        /// Determines the total number of squares on an empty chess board that can be under a queen's attack for every possible position.
        /// </summary>
        /// <param name="a">The number of rows on the chess board.</param>
        /// <param name="b">The number of columns on the chess board.</param>
        /// <returns>The total number of squares under attack by a queen on a chess board for every possible position.</returns>
        public int chessBoardSquaresUnderQueenAttack(int a, int b)
        {
            int n = 0;
            a--;
            b--;
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= b; j++)
                {
                    n +=
                        // row
                        a +
                        // column
                        b +
                        // southeast diagonal
                        Math.Min(a - i, b - j) +
                        // southwest diagonal
                        Math.Min(a - i, j) +
                        // northeast diagonal
                        Math.Min(i, b - j) +
                        // northwest diagonal
                        Math.Min(i, j);
                }
            }
            return n;
        }
    }
}