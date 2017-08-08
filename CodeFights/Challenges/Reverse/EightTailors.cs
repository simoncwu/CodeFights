using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "eightTailors": 
    /// https://codefights.com/challenge/ttQch2heFfrS8hdNd
    /// </summary>
    public class EightTailors
    {
        /// <summary>
        /// Returns the product of (x-a)(x-b)...(x-n), where a, b, ... n are the first eight Fibonacci numbers.
        /// </summary>
        /// <param name="x">An integer.</param>
        /// <returns>The product of (x-a)(x-b)...(x-n) where a, b, ... n are the first eight Fibonacci numbers.</returns>
        public long eightTailors(int x) => new[] { 1, 1, 2, 3, 5, 8, 13, 21 }.Aggregate(1L, (r, v) => r * x - r * v);
    }
}
