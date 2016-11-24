using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "maxLCM": 
    /// https://codefights.com/challenge/DkzPcr6rHQgWL4FFm
    /// 
    /// Given a positive integer n, find a way to represent it as a sum of 
    /// some positive integers s1, s2, ..., st such that their least common 
    /// multiple is maximal. In case multiple solutions provide the largest 
    /// least common multiple, choose the lexicographically smallest set.
    /// </summary>
    public class MaxLCM
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">1 ≤ n ≤ 100.</param>
        /// <returns>The answer in the following form: <c>s1+s2+...+st,maxLCM</c> where each si is in increasing order.</returns>
        public string maxLCM(int n)
        {
            var s = new List<int>[n + 1];
            var lcm = new int[n + 1];

            // max lcm(n) = n for n <= 4
            for (int i = 1; i <= Math.Min(n, 4); i++)
            {
                s[i] = new[] { lcm[i] = i }.ToList();
            }

            for (int i = 5; i <= n; i++)
            {
                // try to find larger lcm than previous with a si that doesn't share factors with previous solution
                int si = 2, max = lcm[i - 1];
                while (si < i && (lcm[i - si] * si <= max || s[i - si].Any(_ => SharesFactors(_, si))))
                {
                    si++;
                }
                if (si >= i)
                    si = 1; // default to previous if no better solution found

                s[i] = new List<int>(s[i - si]);
                s[i].Add(si);
                lcm[i] = lcm[i - si] * si;
                MaximizeLCM(s[i], ref lcm[i]);
            }
            return string.Join("+", (from i in s[n]
                                     orderby i
                                     select i.ToString()).ToArray()) + "," + lcm[n];
        }

        /// <summary>
        /// Indicates whether or not two integers share any common factors (except 1).
        /// </summary>
        /// <param name="a">The first integer to compare.</param>
        /// <param name="b">The second integer to compare.</param>
        /// <returns><c>true</c> if <paramref name="a"/> and <paramref name="b"/> share any common factors greater than 1.</returns>
        bool SharesFactors(int a, int b)
        {
            return Enumerable.Range(2, Math.Min(a, b) - 1).Any(i => a % i == 0 && b % i == 0);
        }

        /// <summary>
        /// Maximizes the LCM that results from a list of integers while preserving the sum of those integers.
        /// </summary>
        /// <param name="l">The <see cref="List{T}"/> of integers.</param>
        /// <param name="lcm">The LCM of <paramref name="l"/>. Updated if <paramref name="l"/> changes.</param>
        /// <remarks>This method maximizes the LCM by attempting to double the list element that is a power of 2 via reduction of the maximum value element and any 1s.</remarks>
        void MaximizeLCM(List<int> l, ref int lcm)
        {
            int power = 2 * l.Where(i => i % 2 == 0).FirstOrDefault(); // new power of 2, if one already exists
            if (power > 0)
            {
                int max = l.Max();
                if (power < max) // only if doubling power is less than largest list element
                {
                    int reducedMax = max - power / 2 + l.Count(i => i == 1); // also remove leading 1s; they contribute nothing to the LCM
                    if (!l.Any(i => SharesFactors(i, reducedMax))) // only if reduced max element doesn't share factors with current solution
                    {
                        l.RemoveAll(i => i == 1);
                        l.Remove(power / 2);
                        l.Remove(max);
                        l.Add(reducedMax);
                        l.Add(power);
                        lcm = lcm / max * 2 * reducedMax; // simplification of lcm * power * C / (max * power / 2)
                    }
                }
            }
        }
    }
}