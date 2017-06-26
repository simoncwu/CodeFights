using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "Nav": 
    /// https://codefights.com/challenge/CBiayArRfZEyDDGX8
    /// </summary>
    public class NavChallenge
    {
        /// <summary>
        /// Returns the coordinate of the final position after executing a series of navigation moves from the origin of a 3-D space.
        /// </summary>
        /// <param name="d">A string of navigation moves comprised of the characters &gt;, &lt;, ^, v, +, and -.</param>
        /// <returns>An array representing x, y, and z coordinates of the final position.</returns>
        public int[] Nav(string d)
        {
            var p = new int[3];
            foreach (var m in d)
            {
                p[90 / m] += m % 5 % 4 / 2 * 2 - 1;
            }
            return p;
        }
    }
}
