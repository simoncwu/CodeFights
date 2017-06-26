using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "countPathsThroughCell": 
    /// https://codefights.com/challenge/hMidJYjd4Pbkj5FwY
    /// 
    /// Consider a rectangular board consisting of n × m cells. You are 
    /// attempting to reach the cell (n - 1, m - 1) from position (0, 0) by 
    /// increasing your horizontal or vertical position one cell at a time. 
    /// Find the number of unique paths to the destination that exist and also 
    /// pass through cell (x, y).
    /// </summary>
    public class CountPathsThroughCell
    {
        /// <summary>
        /// Returns the number of unique shortest paths to a cell that also pass through an intermediate cell along the way.
        /// </summary>
        /// <param name="n">The 1-based horizontal position of the final destination cell.</param>
        /// <param name="m">The 1-based vertical position of the final destination cell.</param>
        /// <param name="x">The 0-based horizontal position of the intermediate cell.</param>
        /// <param name="y">The 0-based vertical position of the intermediate cell.</param>
        /// <returns></returns>
        public int countPathsThroughCell(int n, int m, int x, int y)
        {
            return CountPathsToCell(x, y) * CountPathsToCell(--n - x, --m - y);
        }

        /// <summary>
        /// Returns the number of unique shortest paths to a cell.
        /// </summary>
        /// <param name="n">The horizontal distance to the cell.</param>
        /// <param name="m">The vertical distance to the cell.</param>
        /// <returns></returns>
        int CountPathsToCell(int x, int y)
        {
            // memoization of path counts
            var p = new int[++y][];
            // only 1 path to top row cells
            p[0] = Enumerable.Repeat(1, ++x).ToArray();
            for (int i = 1; i < y; i++)
            {
                p[i] = new int[x];
                // only 1 path to first column cells
                int prev = p[i][0] = 1;
                for (int j = 1; j < x; j++)
                {
                    // paths to cell = paths to previous cell in same row + paths to previous cell in same column
                    p[i][j] = prev += p[i - 1][j];
                }
            }
            return p[y - 1][x - 1];
        }
    }
}