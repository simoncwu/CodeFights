using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "kthBoring": 
    /// https://codefights.com/challenge/2ST7pD433eT8SXNyM
    /// 
    /// A number is considered to be boring if it is not prime and does not 
    /// belong to the Fibonacci sequence. Given a number k, find the k-th 
    /// boring positive integer.
    /// </summary>
    public class KthBoring
    {
        public int kthBoring(int k)
        {
            // start with n as part of the fibonacci sequence
            int n = 0, f1 = 0, f2 = 1;
            for (; k > 0; n++)
            {
                // compute fibonacci numbers until they are >= n
                while (n > f1)
                {
                    f2 = f1 + (f1 = f2);
                }
                // count towards k if n is neither a fib number nor prime
                if (n != f1 && Unprime(n))
                    k--;
            }
            // adjust for superfluous k++ prior to exit condition in previous loop
            return n - 1;
        }

        /// <summary>
        /// Determines whether or not a number is unprime.
        /// </summary>
        /// <param name="n">The number to test.</param>
        /// <returns><c>true</c> if <paramref name="n"/> is unprime; otherwise, <c>false</c>.</returns>
        bool Unprime(int n)
        {
            for (int i = 2, j = (int)Math.Sqrt(n); i <= j; i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
    }
}