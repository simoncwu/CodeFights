using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "minesweeper1": 
    /// https://codefights.com/challenge/ZXRv42mfhbiTTDrEB
    /// 
    /// Each cell of a Minesweeper gameboard can be either a mine (represented 
    /// as 9) or the number of mines in its surrounding cells (0 to 8). Given 
    /// the contents of a gameboard, determine whether or not the counts in all 
    /// non-mine cells are accurate.
    /// </summary>
    public class Minesweeper1
    {
        /// <summary>
        /// Indicates whether or not a Minesweeper gameboard is valid.
        /// </summary>
        /// <param name="gameboard">A rectangular matrix representing the gameboard.</param>
        /// <returns><c>true</c> if <paramref name="gameboard"/> is valid; otherwise, <c>false</c>.</returns>
        public bool minesweeper1(int[][] gameboard)
        {
            return gameboard.Select((_, r) => _.Select((v, c) =>
            {
                for (int i = 9; v < 9 & i-- > 0;)
                {
                    try
                    {
                        v -= gameboard[r - 1 + i / 3][c - 1 + i % 3] / 9;
                    }
                    catch { }
                }
                return v % 9;
            }).Sum()).Sum() == 0;
        }
    }
}
