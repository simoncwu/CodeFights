using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "countValidSnakePaths": 
    /// https://codefights.com/challenge/dPB9sdu3E5HHRjZeY
    /// 
    /// Consider a rectangular board consisting of n × m empty cells, except 
    /// for those occupied by a snake, whose body parts lie on cells that are 
    /// strictly horizontally or vertically adjacent to each subsequent cell. 
    /// The first cell is the snake's head, and the last is the snake's tail. 
    /// On each turn, the snake's head moves to one of the horizontally or 
    /// vertically adjacent cells and each subsequent part instantly occupies 
    /// the cell just vacated by the previous part. Self-intersection and 
    /// crossing beyond the boundaries of the board are prohibited.
    /// 
    /// Count the number of distinct valid paths of length n can a given snake 
    /// can make on a board.
    /// </summary>
    public class CountValidSnakePaths
    {
        // for memoization of path counts
        Dictionary<string, int> pathCache = new Dictionary<string, int>();

        /// <summary>
        /// Counts the number of distinct valid paths of a certain length that can be made by a snake on a board.
        /// </summary>
        /// <param name="board">An array describing the dimensions of the board in the format [rows, columns].</param>
        /// <param name="snake">An array that describes the configuration of the snake's body on the board. snake[0] corresponds to the initial coordinates of the snake's head, snake[1] corresponds to coordinates of the second cell, etc.</param>
        /// <param name="n">The length of the path to make.</param>
        /// <returns>The number of distinct valid paths of length <paramref name="n"/> that the snake can make.</returns>
        public int countValidSnakePaths(int[] board, int[][] snake, int n)
        {
            // there is only 1 way to make 0 moves
            if (n == 0)
                return 1;

            // after next move, tail is entire body except last segment
            var tail = snake.Take(snake.Length - 1);

            // generate unique ID for memoizing answer per combination of snake position and # of moves
            string tailID = n + " ", id;
            foreach (var c in tail)
            {
                tailID += c[0] + " " + c[1] + " ";
            }

            int x = snake[0][0], y = snake[0][1];
            return new int[][] {
                // cells to snake head for next move
                new[] { x - 1, y },
                new[] { x + 1, y },
                new[] { x, y - 1 },
                new [] { x, y + 1 }
            }
            // exclude cells off the board and cells occupied by body segment
            .Where(_ => tail.All(t => _[0] != t[0] || _[1] != t[1]) && _[0] >= 0 && _[0] < board[0] && _[1] >= 0 && _[1] < board[1])
            // sum subsequent paths by checking for memoized value and recursively computing only if not previously visited
            .Sum(_ => pathCache.ContainsKey(id = tailID + _[0] + " " + _[1]) ? pathCache[id] : pathCache[id] = countValidSnakePaths(board, new[] { _ }.Concat(tail).ToArray(), n - 1));
        }
    }
}