using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "moduloHarshad": 
    /// https://codefights.com/challenge/AWSp2cFm94tw4Eeeb
    /// 
    /// A harshad number in a given number base is an integer that is divisible 
    /// by the sum of its digits when written in that base. Given 2 positive 
    /// integers num1 and num2 in base 10, calculate the value of the num2-th 
    /// harshad number modulo the num1-th harshad number.
    /// </summary>
    public class ModuloHarshad
    {
        /// <summary>
        /// Returns the remainder of dividing two harshad numbers, specified by their index in the series.
        /// </summary>
        /// <param name="num1">The 1-based index of the divisor harshad number.</param>
        /// <param name="num2">The 1-based index of the dividend harshad number.</param>
        /// <returns>The remainder of the <paramref name="num2"/>-th harshad number modulo the <paramref name="num1"/>-th harshad number.</returns>
        public long moduloHarshad(long num1, long num2)
        {
            // convert divisor index to offset from dividend index instead of from 0
            num1 = num2 - num1;

            int h2 = 0, h1 = 0;
            while (num2 > 0)
            {
                // check if next number is harshad
                if (++h2 % h2.ToString().Sum(_ => _ - '0') < 1)
                {
                    // inc/decrement dividend index
                    --num2;

                    // update divisor if index matches divisor index offset
                    if (num2 == num1)
                        h1 = h2;
                }
            }

            // if divisor was never set then it is larger than dividend, and therefore % op yields the dividend as remainder
            return h1 == 0 ? h2 : h2 % h1;
        }
    }
}