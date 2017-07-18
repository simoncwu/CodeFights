using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "cDroid": 
    /// https://codefights.com/challenge/omdkwoEBw82KhTQPE
    /// </summary>
    public class CDroid
    {
        /// <summary>
        /// Returns the distance from the origin to the centroid of a triangle.
        /// </summary>
        /// <param name="a">An array of the (x, y) coordinates of the vertices of a triangle (each coordinate in the format [x, y]).</param>
        /// <returns>The distance from the origin to the centroid of the triangle, rounded to 4 decimal places.</returns>
        public string cDroid(int[][] a) => Math.Sqrt(a[0].Select((_, i) => Math.Round(a.Sum(v => v[i]) / 3D)).Sum(_ => _ * _)).ToString("F4");
    }
}
