using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "gameOfSigns": 
    /// https://codefights.com/challenge/uMQAhyc2uv8RfzbyH
    /// 
    /// You are given a matrix of tiles that contain one of 5 possible signs:
    /// 'S': the starting point (only one instance); 
    /// 'F': the finish (only one instance); 
    /// 'R': make a 90 degree right turn; 
    /// 'L': make a 90 degree left turn; 
    /// '-': empty tile.
    /// 
    /// The matrix is navigated starting from the tile marked 'S' and 
    /// proceeding in a specific direction, turning accordingly whenever an R 
    /// or L tile is encountered, until the start tile, finish tile, or matrix 
    /// edge is reached.
    /// 
    /// Given a starting direction of "U", "R", "D", or "L", representing up, 
    /// right, down, and left respectively, determine whether or not the finish 
    /// tile can be reached from the start tile. It is guaranteed that the 
    /// matrix does not contain any infinite loop cycles.
    /// </summary>
    public class GameOfSigns
    {
        /// <summary>
        /// Determines whether or not it is possible to navigate a matrix from the start tile to the finish tile by starting in a specific direction.
        /// </summary>
        /// <param name="m">A rectangular matrix of tile contents represented as strings.</param>
        /// <param name="d">The starting direction.</param>
        /// <returns><c>true</c> if the finish tile can be reached; otherwise, <c>false</c>./returns>
        public bool gameOfSigns(string[] m, string d)
        {
            int r = 0, c = 0, tileValue = 0, direction;

            // find row and column of starting tile
            while ((c = m[r].IndexOf('S')) < 0)
            {
                r++;
            }

            for (
                // convert direction to an integer indicating direction to move on matrix
                direction = "URDL".IndexOf(d);

                // continue while there is a valid direction
                direction < 4;

                // update direction if tile stopped on is a turn tile, else set exit condition
                direction = tileValue > 75 & tileValue < 83 ? (direction + 3 + tileValue) % 4 : 4)
            {
                // try advancing in current direction while tiles are empty within the bounds of the matrix.
                try
                {
                    for (; (tileValue = m[r += ~-direction % 2][c += (2 - direction) % 2]) == '-';) ;
                }
                catch { }

                // note: above uses ugly expensive try/catch to handle access outside the matrix bounds. 
                // better way would be to explicitly check the bounds, e.g.:
                // for (; new[] { r, m[r].Length - 1 - c, m.Length - 1 - r, c}[D] > 0 && (x = m[r += ~-D % 2][c += (2 - D) % 2]) == 45; );
            }

            return tileValue == 'F';
        }
    }
}
