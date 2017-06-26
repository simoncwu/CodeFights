using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "fillByPowers": 
    /// https://codefights.com/challenge/pA34fzHCHE9fJMi4F
    /// 
    /// You are trying to fill a square table of cells with numbers raised to 
    /// the same exponential power in such a way that the sum of every row and 
    /// every column is the same. This sum is called the "key".
    /// 
    /// For a given upper bound for the key, table size, and exponent, 
    /// calculate the number of distinct positive integer keys that are 
    /// possible.
    /// </summary>
    public class FillByPowers
    {
        /// <summary>
        /// Counts the number of distinct positive integer keys that are possible when filling a square table using only numbers raised to a certain power, with a maximum upper bound.
        /// </summary>
        /// <param name="size">The dimension of the square table to fill.</param>
        /// <param name="bound">The upper limit for possible keys.</param>
        /// <param name="exponent">The exponential degree of the numbers in the table.</param>
        /// <returns>The number of possible keys less than or equal to <paramref name="bound"/> for a square table of size <paramref name="size"/>, only using positive numbers raised to the <paramref name="exponent"/> power.</returns>
        public int fillByPowers(int size, int bound, int exponent)
        {
            // pre-build all possible powers to be used in table
            var powers = new List<int>();
            for (int i = 0, p; (p = (int)Math.Pow(++i, exponent)) <= bound;)
            {
                powers.Add(p);
            }

            // base set of single line sums
            IEnumerable<int> ans = new[] { 0 };

            // for each table size increment
            while (size-- > 0)
            {
                // generate all possible sums by adding prebuilt powers to previously computed sums
                ans = ans.ToList().SelectMany(a => powers.Select(p => a + p).Where(p => p <= bound)).Distinct();
            }
            return ans.Count();
        }

    }
}
