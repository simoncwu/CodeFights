using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "findScore": 
    /// https://codefights.com/challenge/ppAoHZP5np9v4w6K7
    /// 
    /// Given the Cartesian coordinates of a dart on a target centered at the 
    /// origin, find the dart's score based on the ring it lands on. Each ring 
    /// has a width of 0.1 and is scored from 10 (inner most ring) to 1 
    /// (outermost ring). If the dart lands on a ring's border, score it for 
    /// that ring. If the dart lands outside all rings, return 0.
    /// </summary>
    public class FindScore
    {
        /// <summary>
        /// Returns the number of the ring on a target that a dart lands on.
        /// </summary>
        /// <param name="x">The x-coordinate of the dart's position.</param>
        /// <param name="y">The y-coordinate of the dart's position.</param>
        /// <returns>The number of the ring</returns>
        public int findScore(double x, double y)
        {
            return Math.Max(0, Math.Min(10, (int)(11 - 10 * Math.Sqrt(x * x + y * y + 1e-17))));
        }
    }
}
