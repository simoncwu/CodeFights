using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "removeDigits": 
    /// https://codefights.com/challenge/mYSs9Exk9t7YCmfua
    /// 
    /// Given an integer n and a length k, find the minimal and maximal values 
    /// of all possible contiguous digit subsequences of n of length k.
    /// </summary>
    public class RemoveDigits
    {
        public long[] removeDigits(long n, int k)
        {
            long mod = 1, min, max = 0, N;

            // calculate 10^k
            while (k-- > 0)
            {
                mod *= 10;
            }

            // modulo by 10^k to left strip digits > length k
            // divide by 10 to iterate through all digits
            // exit when 10n < mod (n has less than k digits)
            for (min = n; 10 * n >= mod; n /= 10)
            {
                min = Math.Min(min, N = n % mod);
                max = Math.Max(max, N);
            }
            return new[] { min, max };
        }
    }
}
