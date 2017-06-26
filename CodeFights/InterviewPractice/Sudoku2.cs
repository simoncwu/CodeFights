using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "sudoku2": 
    /// https://codefights.com/interview-practice/task/SKZ45AF99NpbnvgTn
    /// Asked By: Apple, Uber
    /// 
    /// Implement an algorithm that will check whether a 9 x 9 grid of numbers 
    /// represents a valid Sudoku puzzle state according to traditional Sudoku 
    /// rules. Note that unsolvable grids may still be valid.
    /// </summary>
    public class Sudoku2
    {
        /// <summary>
        /// Determines whether or not a 9 x 9 grid of numbers represents a valid Sudoku puzzle state.
        /// </summary>
        /// <param name="grid">A 9 × 9 array of characters, comprised solely of digits from 1 to 9 or periods.</param>
        /// <returns><c>true</c> if <paramref name="grid"/> represents a valid Sudoku puzzle state; otherwise, <c>false</c>.</returns>
        public bool sudoku2(char[][] grid)
        {
            var subgridIndices = new[] { 0, 3, 6 };
            return
                // across rows
                grid.All(row => IsValidRegion(row)) &&
                // down columns
                grid.Select((_, i) => i).All(c => IsValidRegion(grid.Select(_ => _[c]))) &&
                // within sub-grids
                subgridIndices.All(r => subgridIndices.All(c => IsValidRegion(grid.Skip(r).Take(3).SelectMany(_ => _.Skip(c).Take(3)))));
        }

        /// <summary>
        /// Determines whether or not a region of numbers represents a valid Sudoku region state.
        /// </summary>
        /// <param name="values">A series of 9 characters comprised solely of digits from 1 to 9 or periods.</param>
        /// <returns><c>true</c> if <paramref name="values"/> represents a valid Sudoku puzzle region state; otherwise, <c>false</c>.</returns>
        bool IsValidRegion(IEnumerable<char> values)
        {
            var counts = new int[9];
            return values.All(n => n == '.' || counts[n - '1']++ < 1);
        }
    }
}
