using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "reverseInteger": 
    /// https://codefights.com/interview/xfpK5NtkLaoYEPLCT
    /// 
    /// Reverse the digits of a given integer.
    /// </summary>
    public class ReverseInteger
    {
        /// <summary>
        /// Reverses the digits in an integer.
        /// </summary>
        /// <param name="x">An integer.</param>
        /// <returns>The value of <paramref name="x"/> with its digits reversed.</returns>
        public int reverseInteger(int x)
        {
            int r = 0;
            while (x != 0)
            {
                // * left-shifts the result, % appends the last digit of x
                // first iteration maintains sign
                r = r * 10 + x % 10;
                // truncate the last digit of x
                x /= 10;
            }
            return r;
        }
    }
}