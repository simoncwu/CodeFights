using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "rotateImage": 
    /// https://codefights.com/interview-practice/task/5A8jwLGcEpTPyyjTB
    /// Asked By: Amazon, Google, Apple
    /// 
    /// Rotate an n x n 2D matrix clockwise by 90 degrees in-place, using O(1) 
    /// additional memory.
    /// </summary>
    public class RotateImage
    {
        /// <summary>
        /// Rotates a square matrix clockwise by 90 degrees.
        /// </summary>
        /// <param name="a">A square 2D matrix.</param>
        /// <returns>An in-place clockwise rotation of <paramref name="a"/> by 90 degrees.</returns>
        public int[][] rotateImage(int[][] a)
        {
            for (int col = 0, midpoint = a.Length / 2, lastIndex = a.Length - 1; col < midpoint; col++)
            {
                for (int row = col, lastRow = lastIndex - col; row < lastRow; row++)
                {
                    var temp = a[lastIndex - row][col];
                    a[lastIndex - row][col] = a[lastIndex - col][lastIndex - row];
                    a[lastIndex - col][lastIndex - row] = a[row][lastIndex - col];
                    a[row][lastIndex - col] = a[col][row];
                    a[col][row] = temp;
                }
            }
            return a;
        }
    }
}
