using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "countDs": 
    /// https://codefights.com/challenge/9JxRfiCnWeFvY6JJh
    /// </summary>
    public class CountDs
    {
        /// <summary>
        /// Counts the number of diagonals in an n-sided polygon.
        /// </summary>
        /// <param name="n">The number of sides in the polygon.</param>
        /// <returns>The number of diagonals in a polygon with <paramref name="n"/> sides.</returns>
        public int countDs(int n)
        {
            return n < 3 ? 0 : n * (n - 3) / 2;
        }
    }
}
