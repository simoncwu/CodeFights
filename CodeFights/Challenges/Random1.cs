using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "random1": 
    /// https://codefights.com/challenge/8t6c85eKRH5au39Ax
    /// 
    /// Write a random number generator using the middle-square method.
    /// 
    /// To generate a sequence of k-digit pseudorandom numbers based on a 
    /// k-digit seed value, square the seed to obtain a 2*k-digit value, 
    /// adding leading zeros if necessary. The middle k digits of the result 
    /// becomes the first number of the sequence, as well as the seed for 
    /// generating the next number, and so on.
    /// </summary>
    public class Random1
    {
        /// <summary>
        /// Returns a pseudorandom number using the middle-square method.
        /// </summary>
        /// <param name="seed">The initial seed value.</param>
        /// <param name="n">The number of sequence values to generate.</param>
        /// <returns>The <paramref name="n"/>-th number in the sequence produced by the middle-square method with a seed value of <paramref name="seed"/>.</returns>
        public int random1(int seed, int n)
        {
            // define values used to extract the middle k digits of computed squares
            int l = 1, r = 1;
            while (l < seed)
            {
                l *= 10;
                r = l / r;
            }

            // main generator loop of squaring and extracting middle digits
            while (n-- > 0)
            {
                seed = (int)((long)seed * seed / r % l);
            }
            return seed;
        }

    }
}