using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "areTrianglesSimilar": 
    /// https://codefights.com/challenge/GtKKPwko9DSqfuG25
    /// 
    /// Given the coordinates of the vertices for two triangles on a 2-D 
    /// Cartesian plane, determine whether or not they are geometrically 
    /// similar. The coordinates are provided as a 12-element array where the 
    /// first 6 elements represent the alternating x- and y-coordinates for the 
    /// first triangle's vertices, and the rest represent the vertices of the 
    /// second triangle. It is guaranteed that the triangles are not degenerate.
    /// </summary>
    public class AreTrianglesSimilar
    {
        /// <summary>
        /// Determines whether or not two triangles on a 2-D Cartesian plane are geometrically similar.
        /// </summary>
        /// <param name="coordinates">An array of 12 Cartesian coordinate values for the two triangles' vertices, alternating between x- and y-coordinates, grouped by triangle.</param>
        /// <returns><c>true</c> if the triangles described by <paramref name="coordinates"/> are geometrically similar; otherwise, <c>false</c>.</returns>
        public bool areTrianglesSimilar(int[] coordinates)
        {
            return SimpleDistance(coordinates, 0) * SimpleDistance(coordinates, 8) == SimpleDistance(coordinates, 2) * SimpleDistance(coordinates, 6);
        }

        /// <summary>
        /// Returns a simplified calculation of the distance between two consecutive points in a single array of Cartesian coordinates.
        /// </summary>
        /// <param name="coordinates">An array of Cartesian coordinate values for multiple points, alternating between x- and y-coordinates.</param>
        /// <param name="i">The index of the first of the two points.</param>
        /// <returns>A simplified calculation of the distance between the points in <paramref name="coordinates"/> at indices <paramref name="i"/> and <paramref name="i"/>+2.</returns>
        int SimpleDistance(int[] coordinates, int i)
        {
            return coordinates[i] - coordinates[i + 2] + coordinates[i + 1] - coordinates[i + 3];
        }
    }
}