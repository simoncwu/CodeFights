using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "FindClosestPointWithInclinationChallenge": 
    /// https://codefights.com/challenge/28tEZBaS4BsjJXjWv
    /// 
    /// Given a current and a previous point, rounds the current point off to the nearest integer from the previous point using a given minimum threshold for rounding away from the previous point.
    /// </summary>
    public class FindClosestPointWithInclinationChallenge
    {
        /// <summary>
        /// Returns the integer closest to a specified position using a specific minimum threshold for rounding away from a previous position.
        /// </summary>
        /// <param name="lastPoint">The previous position.</param>
        /// <param name="threshold">The minimum (>=) threshold for rounding <paramref name="inputPosition"/> away from <paramref name="lastPoint"/>.</param>
        /// <param name="inputPosition">The position to round.</param>
        /// <returns>The integer closest to <paramref name="inputPosition"/> </returns>
        public int FindClosestPointWithInclination(int lastPoint, double threshold, double inputPosition)
        {
            return (int)(inputPosition < lastPoint ? Math.Ceiling(inputPosition + threshold - 1) : inputPosition - threshold + 1);
        }
    }
}
