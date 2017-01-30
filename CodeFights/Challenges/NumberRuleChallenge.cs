using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "NumberRule": 
    /// https://codefights.com/challenge/kFDiPpGEvL7jfiEit
    /// </summary>
    public class NumberRuleChallenge
    {
        /// <summary>
        /// Determines whether or not a number contains digits in only non-decreasing order.
        /// </summary>
        /// <param name="inputNumber">The number to analyze.</param>
        /// <returns><c>true</c> if <paramref name="inputNumber"/> contains only non-decreasing digits; otherwise, <c>false</c>.</returns>
        public bool NumberRule(int inputNumber)
        {
            var c = 0;
            return inputNumber.ToString().All(_ => c <= (c = _));
        }
    }
}
