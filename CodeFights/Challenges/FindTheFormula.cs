using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "findTheFormula": 
    /// https://codefights.com/challenge/PR8br4c5qagRqmoab
    /// 
    /// Consider a sequence in which each element is obtained from the previous 
    /// one by applying some function f to it. Given three consecutive elements 
    /// from such a sequence, find and return the function f in the format 
    /// kn[+-]b. If b is equal to zero, it should be omitted. If the absolute 
    /// value of k is 1, it should be omitted as well.
    /// 
    /// It is guaranteed that the function is neither a constant nor an 
    /// identity function.
    /// </summary>
    public class FindTheFormula
    {
        /// <summary>
        /// Returns the affine function that generates a consecutive sequence of integers.
        /// </summary>
        /// <param name="seq">A consecutive sequence of three integers.</param>
        /// <returns>The formula for the affine function that generates <paramref name="seq"/>.</returns>
        public string findTheFormula(int[] seq)
        {
            int k = (seq[2] - seq[1]) / (seq[1] - seq[0]);
            return (k == -1 ? "-" : k == 1 ? "" : k + "") + (seq[1] - k * seq[0]).ToString("n+0;n-0;n");
        }
    }
}