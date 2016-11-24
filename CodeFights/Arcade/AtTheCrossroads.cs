using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade
{
    /// <summary>
    /// Solutions for CodeFights Arcade level "At the Crossroads": 
    /// https://codefights.com/arcade/code-arcade/at-the-crossroads
    /// </summary>
    class AtTheCrossroads
    {
        /// <summary>
        /// Determines whether or not an RPG player levels up upon killing a monster.
        /// </summary>
        /// <param name="experience">Your current experience (XP).</param>
        /// <param name="threshold">The amount of XP required to reach the next level.</param>
        /// <param name="reward">The amount of XP to be gained from killing the monster.</param>
        /// <returns><c>true</c> if the player reaches the next level; otherwise, <c>false</c>.</returns>
        bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }

        /// <summary>
        /// Returns the maximum value of two items that can be carried at once given a maximum carry weight capacity.
        /// </summary>
        /// <param name="value1">The value of the first item.</param>
        /// <param name="weight1">The weight of the first item.</param>
        /// <param name="value2">The value of the second item.</param>
        /// <param name="weight2">The weight of the second item.</param>
        /// <param name="maxW">The maximum carry weight capacity.</param>
        /// <returns>The maximum value that can be carried.</returns>
        int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
                return value1 + value2;
            if (weight1 <= maxW)
                return weight2 <= maxW ? Math.Max(value1, value2) : value1;
            return weight2 <= maxW ? value2 : 0;
        }

        /// <summary>
        /// Returns the dissimilar one of three integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <param name="c">The third integer.</param>
        /// <returns>The value of the dissimilar integer.</returns>
        /// <remarks>It is guaranteed that at least two of the integers are equal.</remarks>
        int extraNumber(int a, int b, int c)
        {
            return a == b ? c : a == c ? b : a;
        }

        /// <summary>
        /// Indicates whether or not the specified integers result in an infinite loop in the following pseudocode:
        /// <code>
        /// while a is not equal to b do:
        ///     increase a by 1
        ///     decrease b by 1
        /// </code>
        /// </summary>
        /// <param name="a">The value of <c>a</c> in the psuedocode.</param>
        /// <param name="b">The value of <c>b</c> in the pseudocode.</param>
        /// <returns><c>true</c> if the pseudocode will infinitely loop; otherwise, <c>false</c>.</returns>
        bool isInfiniteProcess(int a, int b)
        {
            return a > b || (b - a) % 2 != 0;
        }

        /// <summary>
        ///Indicates whether or not two operands can be added, subtracted, multiplied, or divided to obtain a specified value.
        /// </summary>
        /// <param name="A">A positive integer and left-side operand.</param>
        /// <param name="B">A positive integer and right-side operand.</param>
        /// <param name="C">The expression result to test for.</param>
        /// <returns><c>true</c> if <paramref name="A"/> +/-/x/÷ <paramref name="B"/> = <paramref name="C"/>; otherwise, <c>false</c>.</returns>
        bool arithmeticExpression(int A, int B, int C)
        {
            return A + B == C || A - B == C || A * B == C || A / B == C && A % B == 0;
        }

        /// <summary>
        /// Determines whether or not a pair of scores comprise a valid final tennis tie-break set score.
        /// </summary>
        /// <param name="score1">The number of games won by the first player.</param>
        /// <param name="score2">The number of games won by the second player.</param>
        /// <returns><c>true</c> if the specified scores represents a valid final tennis tie-break set score; otherwise, <c>false</c>.</returns>
        bool tennisSet(int score1, int score2)
        {
            int winner = Math.Max(score1, score2), loser = Math.Min(score1, score2);
            return winner == 7 ? loser == 6 || loser == 5 : winner == 6 ? loser < 5 : false;
        }
    }
}
