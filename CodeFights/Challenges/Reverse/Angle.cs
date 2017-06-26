using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "angle": 
    /// https://codefights.com/challenge/PNfoaSQwjN3YvwohS
    /// </summary>
    public class Angle
    {
        /// <summary>
        /// Counts the number of angles in the written form of a number.
        /// </summary>
        /// <param name="a">A positive integer.</param>
        /// <returns>The number of angles in the written form of <paramref name="a"/>.</returns>
        public int angle(int a)
        {
            var angleMap = new[] { 0, 1, 1, 1, 6, 2, 1, 1, 2, 1 };
            return a.ToString().Sum(_ => angleMap[_ - '0']);
        }
    }
}