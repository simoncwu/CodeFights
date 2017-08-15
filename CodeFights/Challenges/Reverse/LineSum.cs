using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "lineSum": 
    /// https://codefights.com/challenge/XyKTF9Kx788Gms9NW
    /// </summary>
    public class LineSum
    {
        /// <summary>
        /// Counts the total number of line segments in a 7-segment display of a number.
        /// </summary>
        /// <param name="n">The number displayed.</param>
        /// <returns>The number of line segments in the 7-segment display of <paramref name="n"/>.</returns>
        public int lineSum(long n) => $"{n}".Sum(_ => "                                                !&  ( !'+!"[_] % 9);
    }
}
