using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Prize": 
    /// https://codefights.com/challenge/tqiTBBuqdzFKfPcEw
    /// 
    /// Given two speeds for a conveyor belt carrying infinitely many prizes at 
    /// whole integer intervals past a prize dispensing chute, determine the 
    /// number of prizes that cannot possibly be dispensed. The belt only moves 
    /// and stops at whole increments of either speed at a time, and cannot 
    /// dispense a prize whilst moving. If there are infinitely many prizes, 
    /// return <c>-1</c>.
    /// </summary>
    public class PrizeChallenge
    {
        /// <summary>
        /// Returns the number of prizes that cannot be dispensed by a belt moving at specific speeds.
        /// </summary>
        /// <param name="normal">A normal belt speed.</param>
        /// <param name="turbo">A faster belt speed (greater than <paramref name="normal"/>).</param>
        /// <returns>The number of prizes that cannot be dispensed.</returns>
        public int Prize(int normal, int turbo)
        {
            return GCD(normal, turbo) > 1 ? -1 : --turbo * --normal / 2;
        }

        /// <summary>
        /// Returns the Greatest Common Denominator of two numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The Greatest Common Denominator of <paramref name="a"/> and <paramref name="b"/>.</returns>
        int GCD(int a, int b)
        {
            return b < 1 ? a : GCD(b, a % b);
        }
    }
}
