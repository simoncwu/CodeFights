using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "leastTiles": 
    /// https://codefights.com/challenge/inpX8Maipe4KLGqqh
    /// 
    /// You are given a rectangular matrix of tiles representing the state of a 
    /// game of 2048. Write an algorithm that determines the axis in which to 
    /// next move that will maximize the number of tiles merged by the move.
    /// 
    /// Return 1 for a vertical move, 2 for a horizontal move, and 0 for a tie.
    /// </summary>
    public class LeastTiles
    {
        /// <summary>
        /// Returns the direction that will combine the most tiles for a given state of a game of 2048.
        /// </summary>
        /// <param name="tiles">A rectangular matrix representing the state of a game of 2048.</param>
        /// <returns><c>1</c> if moving vertically combines the most tiles; <c>2</c> if horizontally; or <c>0</c> if both directions combine the same number of tiles.</returns>
        public int leastTiles(int[][] tiles)
        {
            int pairs =
                // vertical
                tiles[0].Select((_, i) => tiles.Select(r => r[i])).Sum(CountMerges)
                // horizontal
                - tiles.Sum(CountMerges);
            return pairs > 0 ? 1 : pairs < 0 ? 2 : 0;
        }

        /// <summary>
        /// Counts the number of merges that are possible in a single move for a single row/column of a 2048 game board.
        /// </summary>
        /// <param name="tiles">An array of tile values for a single row/column of a 2048 game board.</param>
        /// <returns>The number of merges that are possible in a single move.</returns>
        int CountMerges(IEnumerable<int> tiles)
        {
            int last = 0;
            return tiles.Count(_ => _ > 0 && last == (last = _) && (last = 0) == 0);
        }
    }
}