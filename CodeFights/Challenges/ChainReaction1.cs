using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "chainReaction1": 
    /// https://codefights.com/challenge/nRPHej8QnAxAdaFct
    /// 
    /// Chain Reaction is a game whereby orbs are placed into cells on a board 
    /// that, upon reaching critical mass, "explode" into its neighboring cells 
    /// (vertically or horizontally, but not diagonally). The critical mass for 
    /// each cell is the number of neighboring cells it has.
    /// 
    /// Given the number of rows and columns of an empty square board, and a 
    /// list of orb placement moves, determine the final state of the board.
    /// </summary>
    public class ChainReaction1
    {
        /// <summary>
        /// Returns the state of an initially empty Chain Reaction board after executing a series of moves.
        /// </summary>
        /// <param name="n">The number of rows and columns in the board.</param>
        /// <param name="moves">An ordered array of positions where orbs are to be placed.</param>
        /// <returns>An array representing the number of orbs in each cell of the board after executing <paramref name="moves"/>.</returns>
        public int[][] chainReaction1(int n, int[][] moves)
        {
            var board = new int[n].Select(_ => new int[n]).ToArray();
            n--; // decrement to simplify detection of last row/column

            // delegate for adding orbs
            Action<int, int> AddOrb = null;
            AddOrb = (r, c) =>
            {
                // inadvisable try/catch to avoid explicit array bounds checking
                try
                {
                    // check for critical mass - 2 for corners, 3 for edges, and 4 for interior cells
                    if (++board[r][c] == (r % n < 1 && c % n < 1 ? 2 : r % n < 1 || c % n < 1 ? 3 : 4))
                    {
                        // clear cell of orbs and populate neighboring cells
                        for (int i = board[r][c] = 0; ++i < 5;)
                        {
                            AddOrb(r - 1 + i % 3, c - 1 + i / 2);
                        }
                    }
                }
                catch { }
            };

            foreach (var m in moves)
            {
                AddOrb(m[0], m[1]);
            }

            return board;
        }
    }
}
