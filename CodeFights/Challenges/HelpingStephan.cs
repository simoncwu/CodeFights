using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution to CodeFights challenge "helping Stephan": 
    /// https://codefights.com/challenge/hT9JyzWh77Y6NR2Qd
    /// 
    /// Given two floating point numbers x and y, calculate their Greatest 
    /// Common Divisor. It is guaranteed that both numbers will have at most 5 
    /// digits after the decimal point.
    /// </summary>
    public class HelpingStephan
    {
        /// <summary>
        /// Returns the Greatest Common Divisor of two rational numbers.
        /// </summary>
        /// <param name="x">A 64-bit floating point rational number.</param>
        /// <param name="y">A 64-bit floating point rational number.</param>
        /// <returns>The Greatest Common Divisor of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public double helpingStephan(double x, double y)
        {
            // Euclidean algorithm, to the precision of 5 decimal places (stop when remainder < .00001)
            while (y > 1e-5)
            {
                y = x % (x = y);
            }
            return x;
        }
    }
}
