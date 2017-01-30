using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "helpingBob": 
    /// https://codefights.com/challenge/mDb2jgMysXyo43s6H
    /// 
    /// Given non-negative integers h, v, and k, find the k-th (0-based) 
    /// lexicographically smallest combination of h H's and v V's.
    /// </summary>
    public class HelpingBob
    {
        public string helpingBob(int h, int v, int k)
        {
            // pre-compute all factorials that can possibly be used.
            var factorials = new long[h + v];
            factorials[0] = 1;
            int i;
            for (i = 1; i < h + v;)
            {
                factorials[i] = factorials[i - 1] * i++;
            }

            // build path
            var s = new char[h + v];
            for (i = 0; i < s.Length; i++)
            {
                // test if placing a V at current position would be advancing too many combinations [(h+v-1) Choose v]
                var inc = h < 1 ? 0 : v < 0 ? k + 1 : Combinations(factorials, h - 1, v);
                if (inc <= k)
                {
                    // set V
                    s[i] = 'V';
                    // update combinations
                    k -= (int)inc;
                    // one less V to place
                    v--;
                }
                else
                {
                    // set H
                    s[i] = 'H';
                    // one less H to place
                    h--;
                }
            }
            return new string(s);
        }

        /// <summary>
        /// Returns the number of possible combinations of a specified number of H's and V's.
        /// </summary>
        /// <param name="factorials">An array of pre-computed factorial values.</param>
        /// <param name="h">The number of H's to combine.</param>
        /// <param name="v">The number of V's to combine.</param>
        /// <returns>The number of distinct ways to arrange <paramref name="h"/> H's and <paramref name="v"/> V's.</returns>
        long Combinations(long[] factorials, int h, int v)
        {
            return factorials[h + v] / factorials[v] / factorials[h];
        }
    }
}
