using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "kuromasuPuzzel": 
    /// https://codefights.com/challenge/zFAPKCRGz4Ef6ALBx
    /// 
    /// A kuromasu puzzle is played on a rectangular board of black and white 
    /// cells where some of the cells contain numbers. Each number represents 
    /// the number of white cells that can be seen from that cell, including 
    /// itself. A cell can be seen from another cell if they are in the same 
    /// row or column and there are no black cells between them.
    /// 
    /// Given a valid kuromasu board with only '#' placeholders instead of 
    /// actual numbers, fill in the correct numbers for each placeholder and 
    /// return the resulting board with -1 for non-numbered cells.
    /// 
    /// Non-numbered white cells are designated by '.', black cells by '*'.
    /// </summary>
    public class KuromasuPuzzle
    {
        /// <summary>
        /// Returns the numbered cell values for a kuromasu puzzle board.
        /// </summary>
        /// <param name="board">A valid rectangular kuromasu puzzle board.</param>
        /// <returns>A board containing the numbered cell values for <paramref name="board"/>.</returns>
        public int[][] kuromasuPuzzle(char[][] board)
        {
            char black = '*';
            return board.Select((r, i) => r.Select((c, j) =>
            {
                int I = i, n = 0;
                if (c == '#')
                {
                    // scan up for first non-white cell
                    for (; I-- > 0 && board[I][j] != black;) ;
                    // count downwards # of contiguous non-black cells
                    for (; ++I < board.Length && board[I][j] != black;)
                        n++;
                    // scan left for first non-white cell
                    for (; j-- > 0 && r[j] != black;) ;
                    // count right # of contiguous non-black cells
                    for (; ++j < r.Length && r[j] != black;)
                        n++;
                }
                // subtract 1 for horizontal/vertical overlap duplicate
                return n - 1;
            }).ToArray()).ToArray();
        }
    }
}
