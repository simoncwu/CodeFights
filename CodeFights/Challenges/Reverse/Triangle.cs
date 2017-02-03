using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "triangle_": 
    /// https://codefights.com/challenge/fcLf5cdBqEPPTuSSB/solutions
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Determines whether or not the lengths of three sides of a proposed polygon can form a triangle.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <param name="c">The length of the third side.</param>
        /// <returns><c>true/c> if the sides can form a triangle; otherwise, <c>false</c>.</returns>
        public bool triangle_(double a, double b, double c)
        {
            return a + b > c & a + c > b & b + c > a;
        }
    }
}
