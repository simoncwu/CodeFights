using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "sinArea": 
    /// https://codefights.com/challenge/L7EqDZzBuE5twLtAD
    /// 
    /// Calculate the total signed area of the region in the xy-plane between 
    /// Sin(x) and the x-axis for a given range of x.
    /// </summary>
    public class SinArea
    {
        /// <summary>
        /// Returns the net area of the region defined by the sine function and a specific range of x.
        /// </summary>
        /// <param name="start">The start of the x range.</param>
        /// <param name="end">The end of the x range.</param>
        /// <returns></returns>
        public double sinArea(int start, int end)
        {
            return Math.Cos(start) - Math.Cos(end);
        }

    }
}
