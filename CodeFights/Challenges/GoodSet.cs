using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "goodSet": 
    /// https://codefights.com/challenge/vQ5eLi5Mwatuq8oMJ
    /// 
    /// Given a sorted set of distinct integers, determine if there does NOT 
    /// exist a triplet of distinct numbers a, b, and c where a + b = c.
    /// </summary>
    public class GoodSet
    {
        /// <summary>
        /// Indicates whether or not there does NOT exist a triplet of distinct values a, b, and c in a set of integers where a + b = c.
        /// </summary>
        /// <param name="someSet">A sorted array of nonnegative integers.</param>
        /// <returns><c>true</c> if no triplet exists that satisfies the equation a + b = c; otherwise, <c>false</c>.</returns>
        public bool goodSet(int[] someSet)
        {
            int i = 0;
            var h = new HashSet<int>(someSet);
            return someSet.All(a => a < 1 | someSet.Skip(++i).All(b => !h.Contains(a + b)));
        }
    }
}
