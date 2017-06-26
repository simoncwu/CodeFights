using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "triangularity": 
    /// https://codefights.com/challenge/xunq4T96b3fY54Wif
    /// 
    /// Given an unsorted array of positive integers representing line segment 
    /// lengths, determine if a valid triangle can be created with any three 
    /// segments.
    /// </summary>
    public class Triangularity
    {
        /// <summary>
        /// Determines whether or not an array of line segment lengths contains a combination that creates a valid triangle.
        /// </summary>
        /// <param name="segmentsLength">An unsorted array of positive line segment lengths.</param>
        /// <returns><c>true</c> if <paramref name="segmentsLength"/> contains three lengths that make a valid triangle; otherwise, <c>false</c>.</returns>
        public bool triangularity(int[] segmentsLength)
        {
            int a = 0, b = 0;
            // in order, any sum of 2 shorter segments > third segment
            return segmentsLength.OrderBy(_ => _).Any(c => a + (a = b) > (b = c));
        }
    }
}
