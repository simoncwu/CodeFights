using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "polygonPlotOfLand": 
    /// https://codefights.com/challenge/2QwakjPwpvBZRWkCE
    /// 
    /// Given the number of sides, the length of each side, and the cost of 
    /// land (per square unit) and fencing (per unit), calculate the cost of 
    /// purchasing a plot of land in the shape of a regular polygon, as well as 
    /// fencing the entire perimeter.
    /// 
    /// The result should be returned as a string and rounded to 2 decimal 
    /// places.
    /// </summary>
    public class PolygonPlotOfLand
    {
        /// <summary>
        /// Returns the cost of a plot of land in the shape of a regular polygon, and its fencing.
        /// </summary>
        /// <param name="n">The number of sides the plot has.</param>
        /// <param name="s">The length of each side.</param>
        /// <param name="prices">The unit costs of land and fencing, in the format [ land cost, fencing cost ].</param>
        /// <returns>The rounded total cost of purchasing and fencing a plot of land with the specified parameters.</returns>
        public string polygonPlotOfLand(int n, int s, int[] prices)
        {
            int perimeter = n * s;
            var apothem = s / (2 * Math.Tan(Math.PI / n));
            return (perimeter * apothem / 2 * prices[0] + perimeter * prices[1]).ToString("f2");
        }

    }
}
