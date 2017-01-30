using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "findOnlyDiffChar": 
    /// https://codefights.com/challenge/RsQYfmimvek4JiiiG
    /// 
    /// Given two near-identical arrays of integers where one is missing an 
    /// element from the other and is in a different order, identify the 
    /// missing element.
    /// </summary>
    public class FindOnlyDiffChar
    {
        /// <summary>
        /// Returns the value of the element that is missing from an array.
        /// </summary>
        /// <param name="a">An array of positive integers.</param>
        /// <param name="b">A copy of <paramref name="b"/> that has been shuffled and is missing one element.</param>
        /// <returns>The value of the element that is missing from <paramref name="a"/> in <paramref name="b"/>.</returns>
        public int findOnlyDiffChar(int[] a, int[] b)
        {
            return a.Sum() - b.Sum();
        }
    }
}
