using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "determinantZero": 
    /// https://codefights.com/challenge/C6MausWLfwCmYZGBb
    /// 
    /// In linear algebra, the determinant is a useful value that can be 
    /// computed from the elements of a square matrix.
    /// 
    /// Given an integer n, your task is to calculate the total number of 
    /// 2 × 2 matrices consisting of 4 pairwise distinct integers from 0 to n 
    /// (both inclusive) with determinant equal to 0. The determinant of a 
    /// 2 × 2 matrix[[a, b], [c, d]] can be calculated as a* d - b* c.
    /// </summary>
    /// <example>
    /// For n = 6, the output should be determinantZero(6) = 16.
    /// 
    /// Our goal is to calculate the number of 2 × 2 matrices A = [[a, b], [c, 
    /// d]] where 0 ≤ a, b, c, d ≤ 6, a, b, c, d are pairwise distinct and a * 
    /// d - b * c = 0.
    /// 
    /// Here is the list of valid configurations:
    /// <list type="number">
    /// <item><description>[ [ 1, 2 ], [ 3, 6 ] ], det(A) = 1 * 6 - 2 * 3 = 0</description></item>
    /// <item><description>[ [ 1, 3 ], [ 2, 6 ] ] ...</description></item>
    /// <item><description>[ [ 2, 1 ], [ 6, 3 ] ] ...</description></item>
    /// <item><description>[ [ 2, 3 ], [ 4, 6 ] ] ...</description></item>
    /// <item><description>[ [ 2, 4 ], [ 3, 6 ] ] ...</description></item>
    /// <item><description>[ [ 2, 6 ], [ 1, 3 ] ] ...</description></item>
    /// <item><description>[ [ 3, 1 ], [ 6, 2 ] ] ...</description></item>
    /// <item><description>[ [ 3, 2 ], [ 6, 4 ] ] ...</description></item>
    /// <item><description>[ [ 3, 6 ], [ 1, 2 ] ] ...</description></item>
    /// <item><description>[ [ 3, 6 ], [ 2, 4 ] ] ...</description></item>
    /// <item><description>[ [ 4, 2 ], [ 6, 3 ] ] ...</description></item>
    /// <item><description>[ [ 4, 6 ], [ 2, 3 ] ] ...</description></item>
    /// <item><description>[ [ 6, 2 ], [ 3, 1 ] ] ...</description></item>
    /// <item><description>[ [ 6, 3 ], [ 2, 1 ] ] ...</description></item>
    /// <item><description>[ [ 6, 3 ], [ 4, 2 ] ] ...</description></item>
    /// <item><description>[ [ 6, 4 ], [ 3, 2 ] ] ...</description></item>
    /// </list>
    /// Therefore, the answer is 16.
    /// </example>
    class DeterminantZero
    {
        /// <summary>
        /// Returns the total number of 2 x 2 matrices of pairwise distinct integers from 0 to n with a determinant of 0.
        /// </summary>
        /// <param name="n">The maximum integer in the matrix. 0 ≤ n ≤ 99.</param>
        /// <returns>The total number of pairwise distinct integers with a determinant of 0.</returns>
        int determinantZero(int n)
        {
            // tally instances of products of all distinct pairs from 1 to n
            var p = new int[n * n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    p[i * j]++;
                }
            }

            // simplification of combination formula (choose 2) for each product pair tally.
            // also, there are 8 variations of each pair of pairs in determinant formula.
            return 4 * p.Sum(i => i < 2 ? 0 : i * i - i);
        }
    }
}
