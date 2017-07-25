using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "raiseIt": 
    /// https://codefights.com/challenge/TfwEHZH6LwNugvfLi
    /// </summary>
    public class RaiseIt
    {
        /// <summary>
        /// Returns the sum of an array of powers.
        /// </summary>
        /// <param name="arg1">An array of powers where each power x^y is represented by a two-digit integer, "xy".</param>
        /// <returns>The sum of the powers in <paramref name="arg1"/>.</returns>
        public int raiseIt(int[] arg1) => arg1.Sum(_ => (int)Math.Pow(_ / 10, _ % 10));
    }
}
