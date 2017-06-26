using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "danceSteps": 
    /// https://codefights.com/challenge/LSDiZwGRgCHHao9WN
    /// 
    /// Given a one-dimensional dance floor as a string of digits representing 
    /// forward/backward movements, figure out how many moves a dancer will 
    /// make on it. The dancers move according to the following rules:
    /// <list type="number">
    /// <item><description>
    /// The dancer's initial position is at 0 (i.e., dancefloor[0]).
    /// </description></item>
    /// <item><description>
    /// The digit at the current position indicates how many moves to make, and 
    /// the position itself indicates whether to move forward (even positions) 
    /// or backward (odd positions).
    /// </description></item>
    /// <item><description>
    /// The dance routine ends when the current digit is 0 or when the dancer 
    /// moves off the start or end of the dance floor.
    /// </description></item>
    /// <item><description>
    /// Only moves made on the dance floor are to be counted.
    /// </description></item>
    /// </list>
    /// Return -1 if the dance routine never ends according to the above rules.
    /// </summary>
    public class DanceSteps
    {
        /// <summary>
        /// Counts the number of moves a dancer will make during a dance routine on a one-dimensional dance floor .
        /// </summary>
        /// <param name="dancefloor">A string of digits representing both the dance floor and routine.</param>
        /// <returns>The number of moves a dancer will make on <paramref name="dancefloor"/>, or -1 if the routine never ends.</returns>
        public int danceSteps(string dancefloor)
        {
            // detect cyclic/infinite routine
            var visited = new int[dancefloor.Length];
            int totalMoves = 0, pos = 0, move = 0;

            do
            {
                // read move and aggregate steps
                totalMoves += move = dancefloor[pos] - '0';
                // update position
                pos += move % 2 > 0 ? -move : move;
                // if position is off-board, rollback excess steps
                if (pos < 0 || pos >= dancefloor.Length)
                {
                    totalMoves += pos < 0 ? pos : dancefloor.Length - 1 - pos;
                    // set exit condition
                    move = 0;
                }
                if (move > 0 && visited[pos]++ > 0)
                {
                    totalMoves = -1;
                    // set exit condition
                    move = 0;
                }
            } while (move != 0); // routine ends when move is 0
            return totalMoves;
        }
    }
}