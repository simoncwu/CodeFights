using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "candyCrush1": 
    /// https://codefights.com/challenge/W54BMdin3EdbtgiPa
    /// 
    /// Determine whether a given rectangular gameboard contains at least 3 
    /// consecutive cells of the same color in a single row or column.
    /// </summary>
    public class CandyCrush1
    {
        /// <summary>
        /// Determines whether or not a rectangular gameboard contains at least 3 consecutive cells of the same color in a single row or column.
        /// </summary>
        /// <param name="gameboard">A 2D matrix of characters representing various distinct colors.</param>
        /// <returns><c>true</c> if <paramref name="gameboard"/> contains at least 3 consecutive cells of the same color in a single row or column; otherwise, <c>false</c>.</returns>
        public bool candyCrush1(char[][] gameboard)
        {
            int count = 0, last = 0, i = 0;
            return
                // seek across rows
                gameboard.Any(_ => _.Any(color => (last == (last = color) ? ++count : count = 1) > 2) | (last = ' ') < 0) |
                // seek down columns
                gameboard[0].Any(_ => gameboard.Any(row => (last == (last = row[i]) ? ++count : count = 1) > 2) | (last = ' ') < 0 * i++);
        }

    }
}
