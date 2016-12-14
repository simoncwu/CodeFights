using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "RowReduction": 
    /// https://codefights.com/challenge/SdDSQNLqumkjzTL65
    /// 
    /// Transform a given matrix into its reduced row echelon form.
    /// </summary>
    public class RowReductionChallenge
    {
        /// <summary>
        /// Transforms a matrix into reduced row echelon form.
        /// </summary>
        /// <param name="matrix">The matrix to transform.</param>
        /// <returns>The reduced row echelon form of <paramref name="matrix"/>.</returns>
        public int[][] RowReduction(int[][] matrix)
        {
            return RowReductionByLoop(matrix);
        }

        /// <summary>
        /// Transforms a matrix into reduced row echelon form using loop-based implementatios of Gaussian elimination.
        /// </summary>
        /// <param name="matrix">The matrix to transform.</param>
        /// <returns>The reduced row echelon form of <paramref name="matrix"/>.</returns>
        int[][] RowReductionByLoop(int[][] matrix)
        {
            var m = matrix.Select(r => r.Select(c => (decimal)c).ToArray()).ToArray();
            int i = 0, j = 0;
            while (i < m.Length)
            {
                // find next position
                while (j < m[i].Length && m[i][j] == 0)
                {
                    j++;
                }
                if (j == m[i].Length)
                    break;

                // resolve leading 1 at next position
                Divide(m[i], m[i][j]);

                // zero out column in other rows
                for (int r = 0; r < m.Length; r++)
                {
                    if (r != i)
                    {
                        Subtract(m[r], Multiply(m[i], m[r][j]));
                    }
                }
                i++;
                j++;
            }
            return m.Select(_ => _.Select(o => (int)Math.Round(o)).ToArray()).ToArray();
        }

        /// <summary>
        /// Transforms a matrix into reduced row echelon form using LINQ-based implementations of Gaussian elimination.
        /// </summary>
        /// <param name="matrix">The matrix to transform.</param>
        /// <returns>The reduced row echelon form of <paramref name="matrix"/>.</returns>
        int[][] RowReductionByLinq(int[][] matrix)
        {
            var m = matrix.Select(_ => _.Select(c => c + 0m).ToArray()).ToArray();
            for (int r = 0; r < m.Length; r++)
            {
                var row = m[r];
                // find next position
                int c = Array.FindIndex(row, _ => _ != 0);
                if (c < 0)
                    break;

                // resolve leading 1 at next position
                row = m[r] = row.Select(v => v / row[c]).ToArray();

                // zero out column in other rows
                m = m.Select(_ => _ == row ? _ : _.Select((v, i) => v - row[i] * _[c]).ToArray()).ToArray();
            }
            return m.Select(_ => _.Select(o => (int)Math.Round(o)).ToArray()).ToArray();
        }

        /// <summary>
        /// Multiplies a matrix row by a scalar.
        /// </summary>
        /// <param name="row">The matrix row to modify.</param>
        /// <param name="scalar">The value by which to multiply the row.</param>
        /// <returns>The matrix row result of the multiplication.</returns>
        decimal[] Multiply(decimal[] row, decimal scalar)
        {
            return row.Select(v => v * scalar).ToArray();
        }

        /// <summary>
        /// Divides a matrix row by a non-zero scalar.
        /// </summary>
        /// <param name="row">The matrix row to modify.</param>
        /// <param name="scalar">The value by which to divide the row.</param>
        /// <exception cref="ArgumentException"><paramref name="scalar"/> is 0.</exception>
        void Divide(decimal[] row, decimal scalar)
        {
            if (scalar == 0)
                throw new ArgumentException("Matrix rows cannot be multiplied by 0.", nameof(scalar));
            for (int i = 0; i < row.Length; i++)
            {
                row[i] /= scalar;
            }
        }

        /// <summary>
        /// Subtracts one matrix row fom another.
        /// </summary>
        /// <param name="row1">The matrix row to subtract from.</param>
        /// <param name="row2">The matrix row to subtract.</param>
        void Subtract(decimal[] row1, decimal[] row2)
        {
            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] -= row2[i];
            }
        }
    }
}