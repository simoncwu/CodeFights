using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "smallestCircle": 
    /// https://codefights.com/challenge/9YDBDyHzou7XBWbyR
    /// 
    /// Find the smallest enclosing circle of a given set of points and return 
    /// the indices of the points on the boundary of the circle, in ascending 
    /// order.
    /// 
    /// Constraints:
    /// 2 ≤ points.length.
    /// </summary>
    public class SmallestCircle
    {
        /// <summary>
        /// Returns the indices of the points that are circumscribed by the smallest circle that can enclose a given set of points.
        /// </summary>
        /// <param name="points">The set of points to enclose.</param>
        /// <returns>A sorted array of the indices of the points that are circumscribed by the smallest circle that encloses <paramref name="points"/>.</returns>
        public int[] smallestCircle(int[][] points)
        {
            var w = Welzl(points, points.Length, new int[0]);
            Array.Sort(w);
            return w;
        }

        /// <summary>
        /// Returns the indices of the points that are circumscribed by the smallest circle that can enclose a given set of points, using Welzl's algorithm.
        /// </summary>
        /// <param name="points">The set of points to enclose.</param>
        /// <returns>An array of the indices of the points that are circumscribed by the smallest circle that encloses <paramref name="points"/>.</returns>
        int[] Welzl(int[][] p, int n, int[] r)
        {
            // no more points => end recursion and return answer
            if (n < 1)
                return r;

            // get smallest circle of all points except last
            var smallest = Welzl(p, --n, r);

            // if last point is in s, then it is still the smallest
            var center = Center(smallest.Select(_ => p[_]).ToArray());
            if (center != null && Distance(p[n], center) < Distance(p[smallest[0]], center))
                return smallest;

            // add point to answer and recursively process remaining points
            return Welzl(p, n, r.Concat(new[] { n }).ToArray());
        }

        /// <summary>
        /// Returns the coordinates of the center of the circle that circumscribes a set of points.
        /// </summary>
        /// <param name="points">The points to be circumscribed.</param>
        /// <returns>The center of the smallest circle that circumscribes <paramref name="points"/>.</returns>
        double[] Center(int[][] points)
        {
            if (points.Length < 2)
                return null;

            int[] a = points[0], b = points[1], c = points.Last();
            // 2 points => get midpoint
            if (b == c)
                return new[] { (a[0] + b[0]) / 2D, (a[1] + b[1]) / 2D };

            // get circumcenter
            double
                x = a[0],
                y = a[1],
                x1 = b[0] - x,
                y1 = b[1] - y,
                z1 = x1 * x1 + y1 * y1,
                x2 = c[0] - x,
                y2 = c[1] - y,
                z2 = x2 * x2 + y2 * y2,
                d = 2 * (x1 * y2 - y1 * x2);
            return new[] { (y2 * z1 - y1 * z2) / d + x, (x1 * z2 - x2 * z1) / d + y };
        }

        /// <summary>
        /// Returns the distance between two Cartesian points.
        /// </summary>
        /// <param name="a">The coordinates of the first point.</param>
        /// <param name="b">The coordinates of the second point.</param>
        /// <returns>The square of the distance between points <paramref name="a"/> and <paramref name="b"/>.</returns>
        static double Distance(int[] a, double[] b)
        {
            double x = a[0] - b[0], y = a[1] - b[1];
            return x * x + y * y;
        }
    }
}
