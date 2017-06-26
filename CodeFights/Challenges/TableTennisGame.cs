using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution to CodeFights challenge "tableTennisGame": 
    /// https://codefights.com/challenge/FfyFyLhgJm5d3cnDC
    /// 
    /// In a table tennis match, once a player scores a certain number of 
    /// points, the score is reset and a new set begins. Given the total 
    /// number of points scored by each of two players, determine the maximum 
    /// possible number of sets they could have played.
    /// </summary>
    public class TableTennisGame
    {
        /// <summary>
        /// Returns the maximum possible number of sets two players could have played during a match against each other.
        /// </summary>
        /// <param name="k">The number of points required to win a set.</param>
        /// <param name="a">The total number of points won by the first player throughout the match.</param>
        /// <param name="b">The total number of points won by the second player throughout the match.</param>
        /// <returns>The maximum possible number of sets played during the match.</returns>
        public int tableTennisGame(int k, int a, int b)
        {
            return a / k + b / k;
        }
    }
}
