using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "module_power": 
    /// https://codefights.com/challenge/f855yXqgNeEDEi3Nr
    /// 
    /// Given two integers n and k, calculate the value of n^k modulo (n + 1).
    /// 
    /// Constraints:
    /// -2^52 ≤ int(n) ≤ 2^52; n ≠ -1; 1 ≤ k.length ≤ 6000
    /// </summary>
    public class ModulePower
    {
        /// <summary>
        /// Calculates the value of n^k modulo (n + 1).
        /// </summary>
        /// <param name="n">The value of n.</param>
        /// <param name="k">The value of k.</param>
        /// <returns>The value of n^k modulo (n + 1).</returns>
        public string module_power(string n, string k)
        {
            var N = long.Parse(n);
            return (k.Last() % 2 < 1 ? N > 0 ? 1 : N + 2 : N % ++N).ToString();
        }

    }
}
