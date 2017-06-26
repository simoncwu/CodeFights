using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "orezRoEno": 
    /// https://codefights.com/challenge/s4MabsaBBBgEWTdm3
    /// </summary>
    public class OrezRoEno
    {
        /// <summary>
        /// Returns the bitwise OR of the number of set and unset bits of a positive integer's binary representation.
        /// </summary>
        /// <param name="k">A positive integer.</param>
        /// <returns>The bitwise OR of the number of set and unset bits in the binary representation of <paramref name="k"/>.</returns>
        public int orezRoEno(int k)
        {
            int ones = 0, total = 0;
            // consume each bit via right-shift
            for (; k > 0; k >>= 1)
            {
                // test for set bit in least significant position
                ones += k & 1;
                total++;
            }
            // # of zeroes = # of bits - # of ones
            return total - ones | ones;
        }
    }
}
