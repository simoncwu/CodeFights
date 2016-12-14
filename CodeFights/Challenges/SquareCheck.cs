using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Square_Check": 
    /// https://codefights.com/challenge/7mZGy8xF3exJveRuj
    /// 
    /// Determine whether or not 4 points on a 2-D Cartesian plane form a 
    /// square.
    /// </summary>
    public class SquareCheck
    {
        /// <summary>
        /// Determines whether or not 4 2-D Cartesian coordinates form a square.
        /// </summary>
        /// <param name="points">An array of 4 points alternating between the x and y coordinate of each point.</param>
        /// <returns><c>true</c> if <paramref name="points"/> form a square; otherwise, <c>false</c>.</returns>
        public bool Square_Check(int[] points)
        {
            var distances = new HashSet<double>();
            for (int a = 0; a < 8; a += 2)
            {
                for (int b = 0; b < 8; b += 2)
                {
                    if (a != b)
                    {
                        distances.Add(Distance(points[a], points[a + 1], points[b], points[b + 1]));
                        if (distances.Count > 2) // squares have only 2 unique point distances: sides and diagonals.
                            return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Returns the distance between two 2-D Cartesian 
        /// </summary>
        /// <param name="points"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
