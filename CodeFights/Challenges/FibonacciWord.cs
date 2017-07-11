using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "fibonacciWord": 
    /// https://codefights.com/challenge/mLWJWiwBHTzg8MSxc
    /// 
    /// The Fibonacci word sequence of bit strings is defined as:
    /// F(0) = "0"
    /// F(1) = "1"
    /// F(n) = F(n − 1) + F(n − 2) for n > 1
    /// Given a number n and a bit pattern string, return the number of 
    /// occurrences of the bit pattern in F(n).
    /// </summary>
    public class FibonacciWord
    {
        /// <summary>
        /// Counts the number of occurrences of a pattern string in the n-th Fibonacci word sequence.
        /// </summary>
        /// <param name="n">The number of the Fibonacci word sequence to examine.</param>
        /// <param name="p">A pattern string to search for.</param>
        /// <returns>The number of occurrences of <paramref name="p"/> in the <paramref name="n"/>-th Fibonacci word sequence.</returns>
        public int fibonacciWord(int n, string p)
        {
            // pattern 00 never occurs, so we can skip a lot of unnecessary searching by just returning 0
            if (p.Contains("00"))
                return 0;

            // initialize strings for f(n - 1) and f(n - 2) with base cases
            string prevS = "0", s = n < 1 ? prevS : "1";

            // also initialize pattern counts for f (n - 1) and f(n - 2)
            int prevCount = prevS == p ? 1 : 0, count = n < 1 ? prevCount : s == p ? 1 : 0;

            // process until base case condition (n = 0 or n = 1) is reached
            for (; n-- > 1;)
            {
                // update strings s1 and s2
                var oldPrevS = prevS;
                prevS = s;
                s += oldPrevS;

                // see if pattern instance count needs to be computed for first time
                if (count < 1 && prevCount < 1)
                {
                    if (s.Length >= p.Length && s.Contains(p))
                        count++;
                }
                else
                {
                    // pattern has already been found, so new string is combination of previous counts
                    var oldPrevCount = prevCount;
                    prevCount = count;
                    count += oldPrevCount;

                    // Find new instances that bridge the old strings.
                    // Start from just after s2 - p (skip any instances in previous S) to just before end of s2 (skip any instances in previous prevS).
                    // Normally we could use RegEx to do the counting but it is either too slow for large input or somehow returning the wrong count.
                    for (int i = prevS.Length - p.Length; ; count++)
                    {
                        i = s.IndexOf(p, i + 1);
                        if (i < 0 | i >= prevS.Length)
                            break;
                    }
                }

                // Optimization step: retain only the prefix and suffix of s up to the length of p.
                // The inner contents we've already counted and can retain that data through our count variables, 
                // but we need the prefix and suffix in order to perform overlap matching.
                if (s.Length > p.Length * 2)
                    s = s.Remove(p.Length - 1) + s.Substring(s.Length - p.Length - 1);
            }
            return count;
        }
    }
}
