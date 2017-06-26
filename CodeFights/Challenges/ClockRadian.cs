using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "clockRadian": 
    /// https://codefights.com/challenge/ELRMTabuAk4NSbzpc
    /// 
    /// Given a time, calculate the angle between the hour and minute hands on 
    /// an analog clock showing that time. The returned value should be in 
    /// radians and written as a reduced fraction.
    /// </summary>
    public class ClockRadian
    {
        /// <summary>
        /// Returns the angle between the hands on an analog clock as a reduced radian fraction.
        /// </summary>
        /// <param name="time">The time shown on the clock.</param>
        /// <returns>The angle between the hands on an analog showing time <paramref name="time"/>.</returns>
        public string clockRadian(string time)
        {
            int p = 360, n = int.Parse(time.Replace(":", "")), g = GCD(n = Math.Abs(n / 100 % 12 * 60 - n % 100 * 11), p);
            n = (n > p ? p + p - n : n) / g;
            return n > 0 ? (n > 1 ? n + "pi" : "pi") + ((g = p / g) > 1 ? "/" + g : "") : "0";
        }

        /// <summary>
        /// Returns the Greatest Common Divisor of two integers.
        /// </summary>
        /// <param name="a">An integer to compare.</param>
        /// <param name="b">An integer to compare.</param>
        /// <returns>The Greatest Common Divisor of <paramref name="a"/> and <paramref name="b"/>.</returns>
        int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}