using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "onesPosition": 
    /// https://codefights.com/challenge/QKHjjtxSpyyyuEGXN
    /// 
    /// Given a nonnegative number, find the n-th (0-based) nonnegative number 
    /// that is either prime or less than 2, where n is the number of set bits 
    /// in the binary representation of the number given.
    /// </summary>
    public class OnesPosition
    {
        /// <summary>
        /// Finds the n-th (0-based) nonnegative number that is either prime or less than 2, where n is the number of set bits in a given number.
        /// </summary>
        /// <param name="num">A nonnegative integer.</param>
        /// <returns>The n-th nonnegative number that is either prime or less than 2, where n is the number of set bits in <paramref name="num"/>.</returns>
        public int onesPosition(int num)
        {
            int p = 0;
            while (num > 0)
            {
                // take next possible prime
                int i = ++p;
                // very naive and inefficient primality detection algorithm
                while (i > 1 && p % --i != 0) ;
                // if number is prime, clear the rightmost set bit
                if (i == 1)
                    num &= num - 1;
            }
            return p;
        }
    }
}
