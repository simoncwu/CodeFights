using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "ReversesreveR": 
    /// https://codefights.com/challenge/WeEiBDEkJtJhsRfZu
    /// </summary>
    public class ReversesreveRChallenge
    {
        /// <summary>
        /// Evaluates a mathematical expression where each operand's digits are in reverse order.
        /// </summary>
        /// <param name="s">A valid mathematical expression in the format [a][op][b] where [a] and [b]'s digits are in reverse order and [op] is one of the following operations: +, -, /, *, %, ^.</param>
        /// <returns>The result of evaluating <paramref name="s"/>.</returns>
        public int ReversesreveR(string s)
        {
            int x = 0, y = 0, op = 0;
            s.Reverse().Max(_ => (_ %= '0') > 9 ? op = _ : op != 0 ? x = x * 10 + _ : y = y * 10 + _);
            return new[] { x * y, x + y, x % y, x - y, (int)Math.Pow(x, y), x / y }[op % 7];
        }
    }
}
