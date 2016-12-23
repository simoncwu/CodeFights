using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "remainFib": 
    /// https://codefights.com/challenge/mudnXf6iHBHG7ukYw
    /// 
    /// Find the n-th non-negative integer in increasing order that is not a 
    /// term in the Fibonacci sequence.
    /// </summary>
    public class RemainFib
    {
        /// <summary>
        /// Returns the n-th non-negative integer that is not a Fibonacci term.
        /// </summary>
        /// <param name="number">The 1-based index of the term to find.</param>
        /// <returns>The <paramref name="number"/>-th non-negative integer that is not a Fibonacci term.</returns>
        public string remainFib(string number)
        {
            long fib1 = 1, fib2 = 2, n = long.Parse(number);
            // calculate Fib terms and increment n for each Fib term <= n found (thereby skipping the term)
            while (fib2 <= ++n)
            {
                fib2 += fib1 = fib2 - fib1;
            }
            return n.ToString();
        }

    }
}
