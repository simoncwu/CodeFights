using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "reciprocal": 
    /// https://codefights.com/challenge/HgGmyKu7WbuFuu2bq
    /// 
    /// For 1 ÷ n, return the d-th digit after the decimal place.
    /// </summary>
    public class Reciprocal
    {
        /// <summary>
        /// Returns the digit at a specified decimal place of the reciprocal of a number.
        /// </summary>
        /// <param name="n">The number to divide into 1.</param>
        /// <param name="d">The number of the desired digit's decimal place.</param>
        /// <returns>The digit at the <paramref name="d"/>-th decimal place of the reciprocal of <paramref name="n"/>.</returns>
        public int reciprocal(int n, int d)
        {
            int remainder = 1, digitCount = 0, quotientDigit = 0;

            // sequence of calculated quotient digits
            var digits = new List<int>();

            // map of each calculated remainder to index encountered in digits
            var h = new Dictionary<int, int>();

            // perform long division
            while (digitCount < d)
            {
                remainder = remainder % n * 10;

                // check for repetition: if remainder has been encountered before
                if (h.ContainsKey(remainder))
                {
                    int start = h[remainder];
                    // desired digit is at [start of repetition] + [# digits from start to desired index] % [length of repetition]
                    quotientDigit = digits[start + (d - start - 1) % (digits.Count - start)];
                    digitCount = d;
                }
                else
                {
                    digits.Add(quotientDigit = remainder / n);
                    h[remainder] = digitCount++;
                }
            }
            return quotientDigit;
        }
    }
}
