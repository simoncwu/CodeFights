using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "deranged": 
    /// https://codefights.com/challenge/RmHkZf2atLqkBNXud
    /// 
    /// Determine the number of ways a group of participants in a Secret Santa 
    /// drawing can draw names such that no participant draws themself. In 
    /// combinatorial mathematics, this is also known as a derangement.
    /// </summary>
    public class Deranged
    {
        /// <summary>
        /// Returns the number of derangements of a set.
        /// </summary>
        /// <param name="n">The size of the set.</param>
        /// <returns>The number of derangements for a set of size <paramref name="n"/>.</returns>
        public long deranged(int n) => n < 1 ? 1 : n * deranged(n - 1) + 1 - n % 2 * 2; // using Euler's recursive algorithm
    }
}
