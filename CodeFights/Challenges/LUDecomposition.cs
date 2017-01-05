using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "luDecomposition": 
    /// https://codefights.com/challenge/5S3ZSpWNkdyvQw4uz
    /// 
    /// Given a matrix with a non-zero determinant, find its LU decomposition 
    /// as a single combined matrix of its non-zero, non-diagonal lower and 
    /// upper matrix components.
    /// </summary>
    public class LUDecomposition
    {
        /// <summary>
        /// Returns the LU decomposition of a matrix with a non-zero determinant.
        /// </summary>
        /// <param name="matrix">A matrix with a non-zero determinant.</param>
        /// <returns>The LU decomposition of <paramref name="matrix"/> as a single combined matrix.</returns>
        public double[][] luDecomposition(int[][] matrix)
        {
            int n = matrix.Length;
            var lu = matrix.Select(r => r.Select(c => (double)c).ToArray()).ToArray();
            // start at top-left and iteratively proceed down principal diagonal
            for (int i = 0; i < n; i++)
            {
                // skip/preserve first row due to identity principal diagonal
                for (int r = i + 1; r < n; r++)
                {
                    // first column
                    lu[r][i] /= lu[i][i];

                    // remaining columns
                    for (int c = i + 1; c < n; c++)
                    {
                        lu[r][c] -= lu[r][i] * lu[i][c];
                    }
                }
            }
            return lu;
        }


    }
}
