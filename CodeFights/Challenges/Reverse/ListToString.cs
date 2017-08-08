using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution to CodeFights reverse challenge "listToString": 
    /// https://codefights.com/challenge/iiuwDh9uf6AEEb4hz
    /// </summary>
    public class ListToString
    {
        /// <summary>
        /// Converts an array of integers to various other bases.
        /// </summary>
        /// <param name="l">An array of 3 integers.</param>
        /// <returns>A string concatenation of the numbers in <paramref name="l"/> converted to bases 8, 2, and 16, respectively, where positive numbers are separated by a space from the previous number.</returns>
        public string listToString(int[] l)
        {
            int i = 0;
            var s = "";
            Array.ForEach(l, _ => s += (_ < 0 ? "-" : i > 0 ? " " : "") + Convert.ToString(_ < 0 ? -_ : _, " 	@"[i++] / 4));
            return s;
        }
    }
}
