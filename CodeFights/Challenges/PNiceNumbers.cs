using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution to CodeFights challenge "pNiceNumbers": 
    /// https://codefights.com/challenge/wbgyXSKkp89EiQW89
    /// 
    /// A nonnegative integer i is called p-nice with respect to positive 
    /// integer n and prime integer p if the value of n choose i is divisible 
    /// by p. Given n and p, calculate the number of p-nice numbers that are 
    /// less than n.
    /// </summary>
    public class PNiceNumbers
    {
        /// <summary>
        /// Counts the number of nonnegative integers less than a given number that are p-nice with respect to a given prime number.
        /// </summary>
        /// <param name="n">A positive integer.</param>
        /// <param name="p">A prime number.</param>
        /// <returns>The number of nonnegative integers less than <paramref name="n"/> that are p-nice with respect to it and <paramref name="p"/>.</returns>
        public int pNiceNumbers(int n, int p)
        {
            // Corollary to Lucas's Theorem: for prime p and any n with base-p 
            // representation a[j]...a[1]a[0], the # of k where nCk is NOT a 
            // multiple of p is (1+a[j])*...*(1+a[1])*(1+a[0]).
            int x = 1, N = n;
            // convert to base-p digits
            for (; N > 0; N /= p)
            {
                // aggregate multiply by each base-p digit
                x *= 1 + N % p;
            }
            // return all of n EXCEPT the non-multiples, plus 1 for nC0
            return n - x + 1;
        }
    }
}
