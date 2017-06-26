using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "numberSystem": 
    /// https://codefights.com/challenge/QQtJJfjih55Foroyu
    /// 
    /// Consider a strictly increasing array of k digits that are used to write 
    /// positive numbers in base k in a positional notation number system:
    /// 
    /// If there is no 0 digit, the values of the digits start from 1, with 
    /// digits[0] standing for 1, digits[1] standing for 2, etc. For example, 
    /// the number 10 is written using digits [2, 3] as: 
    /// 1 * 4 + 2 * 2 + 2 * 1 -> "233". 
    /// This is also more commonly known as bijective base-k numeration.
    /// 
    /// If there is a 0 digit, the digit values start from 0, with digits[0] 
    /// standing for 0, digits[1] standing for 1, etc., and the number is 
    /// written as its 0-based n-th equivalent. For example, the number 10 
    /// is written using digits [0, 3] as: 
    /// 9 = 1 * 8 + 0 * 4 + 0 * 2 + 1 * 1 -> "3003".
    /// 
    /// Given an array of digits, convert a number n using this number system.
    /// </summary>
    public class NumberSystem
    {
        /// <summary>
        /// Converts a decimal number into a different positional notation number system.
        /// </summary>
        /// <param name="digits">A strictly increasing array of digits representing incremental digits.</param>
        /// <param name="n">A positive integer.</param>
        /// <returns>The value of <paramref name="n"/> expressed in a positional notation number system with digits <paramref name="digits"/></returns>
        public string numberSystem(int[] digits, int n)
        {
            string s = null;
            int k = digits.Length;
            do
            {
                // bijective numeration maps each digit value to one lower (mod k) by index
                // this has the side-effect of decrementing regular base-k value by 1 overall
                s = digits[--n % k] + s;
                // next digit by base
                n /= k;
                // adjust regular base-k decrements by incrementing prior to next decrement
                if (digits[0] == 0 && n > 0)
                    n++;
            }
            while (n > 0);
            return s;
        }
    }
}