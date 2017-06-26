using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "totalBinSum": 
    /// https://codefights.com/challenge/prd5XH6KJtWPRva4w
    /// 
    /// Given the binary representation of a number, sum all the decimal 
    /// numbers formed by all its prefixes of every possible length. Since the 
    /// answer can be very big, return it modulo 10^9 + 7.
    /// </summary>
    public class TotalBinSum
    {
        /// <summary>
        /// Returns the decimal sum of all possible prefixes of a number's binary representation, modulo 10^9 + 7.
        /// </summary>
        /// <param name="num">A binary representation of a number, as a string of 0s and 1s.</param>
        /// <returns>The decimal sum of all prefixes of <paramref name="num"/>.</returns>
        public int totalBinSum(string num)
        {
            int value = 0, modulo = 1000000007;
            return num.Aggregate(0, (r, v) => (r + (value = 2 * value % modulo + v % 2)) % modulo);
        }
    }
}
