using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "stringMaze": 
    /// https://codefights.com/challenge/Sa6rfk78Qmvw293FY
    /// 
    /// Given a maze described by lowercase letters that loops, where the 
    /// current position's letter indicates the number of positions to advance 
    /// upon the next move (a = 1, b = 2, ..., z = 26), return the number of 
    /// moves needed to reach the last position in the maze from the first 
    /// position. If the letters describe an infinite loop where the end can 
    /// never be reached, return -1.
    /// </summary>
    public class StringMaze
    {
        /// <summary>
        /// Returns the number of moves needed to reach the end of a letter maze.
        /// </summary>
        /// <param name="maze">The letter maze to navigate.</param>
        /// <returns>The number of moves needed to reach the end of <paramref name="maze"/> if there is no infinite loop; otherwise, -1.</returns>
        public int stringMaze(string maze)
        {
            var visited = new bool[maze.Length];
            int i = 0, end = maze.Length - 1, moves = 0;
            while (i < end && !visited[i])
            {
                visited[i] = true;
                i = (i + maze[i] - '`') % maze.Length;
                moves++;
            }
            return visited[i] ? -1 : moves;
        }

    }
}
