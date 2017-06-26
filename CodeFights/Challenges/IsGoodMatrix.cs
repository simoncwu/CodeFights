using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isGoodMatrix": 
    /// https://codefights.com/challenge/teS5pB7RPT6kJchgW
    /// 
    /// A matrix is considered "good" if the main diagonal, and every diagonal 
    /// parallel to it, contains the same element value. Each diagonal can 
    /// contain a different value, so long as it is the same through that same 
    /// diagonal. Given a 2D matrix, determine whether or not it is "good".
    /// </summary>
    public class IsGoodMatrix
    {
        /// <summary>
        /// Determines whether or not a matrix is "good".
        /// </summary>
        /// <param name="matrix">A 2D matrix.</param>
        /// <returns><c>true</c> if <paramref name="matrix"/> is "good"; otherwise, <c>false</c>.</returns>
        public bool isGoodMatrix(int[][] matrix)
        {
            int r = 0, c = 0;
            return matrix.All(_ => _.All(o => r * c++ < 1 || o == matrix[r - 1][c - 2]) & (c = 0) < ++r);
        }
    }
}
