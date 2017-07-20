using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "mazeEscape": 
    /// https://codefights.com/challenge/dF3Qvny3Yn23xvLRb
    /// 
    /// Given the width and height of a maze and a list of impassable cells, 
    /// determine the minimum number of moves needed to navigate from the 
    /// top-left corner of the maze to the bottom-right. The impassable cells 
    /// are provided as an array of alternating x- and y-coordinates of each 
    /// cell, e.g., [1, 2, 3, 4] represents two cells (1, 2) and (3, 4). It is 
    /// guaranteed that the start and end cells are never impassable. The only 
    /// allowable moves are up, down, left, and right -- no diagonals. If it is 
    /// not possible to navigate the maze from start to finish, return -1.
    /// </summary>
    public class MazeEscape
    {
        /// <summary>
        /// Returns the minimum number of moves to navigate a maze containing impassable cells from the top-left corner to the bottom-right corner.
        /// </summary>
        /// <param name="w">The width of the maze.</param>
        /// <param name="h">The height of the maze.</param>
        /// <param name="impassable">A list of alternating x- and y-coordinates for each impassable cell.</param>
        /// <returns>The minimum number of moves needed to navigate the maze, if possible; otherwise, <c>-1</c>.</returns>
        public int mazeEscape(int w, int h, int[] impassable)
        {
            // create maze
            var maze = new int[w, h];

            // set start and impassable cells to -(max) (cell count)
            // this has two effects:
            // 1. makes following algorithm skip impassable cells because they will always be smaller
            // 2. makes all passable cells except the start (max) greater than the start value
            int m = w * h;
            maze[0, 0] = -m;
            for (int i = 0; i < impassable.Length;)
            {
                // consume impassable array elements two at a time
                maze[impassable[i++], impassable[i++]] = -m;
            }

            var q = new Queue<int>();
            q.Enqueue(0); // start pathing at (0, 0)
            while (q.Any())
            {
                // de-hash coordinates of next position and loop through top, bottom, left, and right neighbors
                // also compute the move count at the next position (current + 1)
                int v = q.Dequeue(), c = v / w, r = v % w;
                v = maze[c, r] + 1;
                for (int i = -2, x, y, u; i < 3; i++)
                {
                    try
                    {
                        // get neighbor
                        u = maze[x = c + i / 2, y = r + i % 2];

                        // if next move count is less than neighbor's existing value
                        if (v < u)
                        {
                            // update neighbor's value to smaller value
                            maze[x, y] = v;

                            // queue neighbor for (re)processing (using positional hash)
                            q.Enqueue(x * w + y);
                        }
                    }
                    catch { }
                }
            }

            // reverse the -(max) offset of the end cell and compare to (max), which is an impossible 
            // answer because the start cell doesn't count as a move.
            // if end cell was never reached, its (adjusted) value will be (max).
            return m > (m += maze[w - 1, h - 1]) ? m : -1;
        }
    }
}
