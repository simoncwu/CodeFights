using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "combinePasture": 
    /// https://codefights.com/challenge/YhSoJczcT25LtkyuY
    /// 
    /// Given the x-y coordinates for the bottom-left and top-right corners A, 
    /// B of two rectangles R1, R2 in 2-D Cartesian space, return the area of 
    /// the smallest perfect square that can wholly encompass both rectangles. 
    /// The coordinates for the rectangles are provided in the format: 
    /// [R1Ax, R1Ay, R1Bx, R1By, R2Ax, R2Ay, R2Bx, R2By].
    /// </summary>
    public class CombinePasture
    {
        /// <summary>
        /// Requtrns the area of the smallest perfect square that can contain two given rectangles in 2-D Cartesian space.
        /// </summary>
        /// <param name="vertices">The coordinates of the two rectangles.</param>
        /// <returns>The area of the smallest perfect square that can contain the rectangles specified by <paramref name="vertices"/>.</returns>
        public int combinePasture(int[] vertices)
        {
            // Most flexible solution; handles any arbitrary # of alternating x-y coordinates
            //var x = vertices.Where((_, i) => i % 2 < 1);
            //var y = vertices.Where((_, i) => i % 2 > 0);
            //int s = Math.Max(x.Max() - x.Min(), y.Max() - y.Min());

            // Hard-coded array indices
            //int s = Math.Max(Math.Max(vertices[6] - vertices[0], vertices[2] - vertices[4]), Math.Max(vertices[7] - vertices[1], vertices[3] - vertices[5]));

            // Hard-codex # of comparisons; takes advantage of pattern of given index order
            //Func<int, int> m = i => Math.Max(vertices[i + 6] - vertices[i], vertices[i + 2] - vertices[i + 4]);
            //int s = Math.Max(m(0), m(1));

            // Hard-coded array indices, with allocation of new array
            //int s = new[] { vertices[6] - vertices[0], vertices[2] - vertices[4], vertices[7] - vertices[1], vertices[3] - vertices[5] }.Max();

            // Takes advantage of pattern of given index order, at the cost of 2x the comparisons
            int i = 2;
            return vertices.Max(_ => (_ -= vertices[i++ % 8]) * _);
        }
    }
}