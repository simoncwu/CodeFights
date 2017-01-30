using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "VanyaAndBook1s": 
    /// https://codefights.com/challenge/xkEsQ3fYxMHwtvFMG
    /// 
    /// You have to sequentially assign n books with numbers from 1 to n. Find 
    /// out how many digits in total will be assigned in total.
    /// </summary>
    public class VanyaAndBook1sChallenge
    {
        /// <summary>
        /// Returns the number of digits in the first n positive integers.
        /// </summary>
        /// <param name="n">The number of positive integers to count.</param>
        /// <returns>The number of digits in the first <paramref name="n"/> positive integers.</returns>
        public int VanyaAndBook1s(int n)
        {
            int sum = 0, digits = 1, exp = 1;
            //single line recursive version
            //return n < 10 ? n : (n - (s = (int)Math.Pow(10, n = (n+"").Length - 1) - 1)) * ++n + VanyaAndBook1s(s);
            for (; n / exp > 9; exp *= 10)
            {
                sum += 9 * exp * digits++;
            }
            return sum + digits * (n - exp + 1);
        }
    }
}
