using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "matrixElementsInSpiralOrder": 
    /// https://codefights.com/interview/dx3iqAeokok6KoLHb
    /// 
    /// Given a rectangular matrix, return all of the elements of the matrix 
    /// in spiral order, starting from the top-left corner and proceeding 
    /// clockwise towards the center.
    /// </summary>
    public class MatrixElementsInSpiralOrder
    {
        /// <summary>
        /// Returns the elements in a matrix in clockwise spiral order from the top-left corner to the center.
        /// </summary>
        /// <param name="matrix">A rectangular matrix.</param>
        /// <returns>An array containing the elements of <paramref name="matrix"/>, in clockwise spiral order.</returns>
        public int[] matrixElementsInSpiralOrder(int[][] matrix)
        {
            int rows = matrix.Length, cols = matrix.Length > 0 ? matrix[0].Length : 0;
            var elements = new int[rows * cols];
            for (int level = 0, i = 0; rows > 0 && cols > 0; cols -= 2)
            {
                var ring =
                    // top row
                    matrix[level].Skip(level++).Take(cols)
                    // right column
                    .Concat(matrix.Skip(level).Take(rows -= 2).Select(_ => _[level + cols - 2]));
                // bottom row
                if (rows >= 0)
                    ring = ring.Concat(matrix[level + rows].Skip(level - 1).Take(cols).Reverse());
                // left column
                if (cols > 1)
                    ring = ring.Concat(matrix.Skip(level).Take(rows).Select(_ => _[level - 1]).Reverse());
                foreach (var e in ring)
                {
                    elements[i++] = e;
                }
            }
            return elements;
        }
    }
}
