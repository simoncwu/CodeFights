using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "base32": 
    /// https://codefights.com/challenge/xnXmjZXK43QMgnhX9
    /// </summary>
    public class Base32
    {
        /// <summary>
        /// Converts a integer from decimal to Base32.
        /// </summary>
        /// <param name="num">A decimal integer.</param>
        /// <returns>The Base32 representation of <paramref name="num"/>.</returns>
        public string base32(int num)
        {
            return (num > 31 ? base32(num / 32) : "") + "23456789ABCDEFGHJKLMNPQRSTUVWXYZ"[num %= 32];
        }
    }
}
