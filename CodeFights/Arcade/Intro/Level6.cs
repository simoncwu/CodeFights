using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 6":
    /// https://codefights.com/arcade/intro/level-6
    /// </summary>
    class Level6
    {
        /// <summary>
        /// Given an array of integers, replace all the occurrences of a specific integer with a substitute.
        /// </summary>
        /// <param name="inputArray">An array of integers.</param>
        /// <param name="elemToReplace">The integer to replace.</param>
        /// <param name="substitutionElem">The substitute integer.</param>
        /// <returns>An array of integers where all occurrences of <paramref name="elemToReplace"/> have been replaced with <paramref name="substitutionElem"/>.</returns>
        int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select(_ => _ == elemToReplace ? substitutionElem : _).ToArray();
        }

        /// <summary>
        /// Check if all digits of the given integer are even.
        /// </summary>
        /// <param name="n">An positive integer.</param>
        /// <returns><c>true</c> if all digits of n are even, <c>false</c> otherwise.</returns>
        bool evenDigitsOnly(int n)
        {
            while (n > 0)
            {
                if (n % 2 > 0)
                    return false;
                n /= 10;
            }
            return true;

            // single line algorithm
            return n.ToString().All(_ => _ % 2 < 1);
        }

        /// <summary>
        /// Correct variable names consist only of Latin letters, digits and underscores and they can't start with a digit. Check if the given string is a correct variable name.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <returns><c>true</c> if name is a correct variable name, <c>false</c> otherwise.</returns>
        bool variableName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z_][a-zA-Z_\d]*$");
        }

        /// <summary>
        /// Given a string, replace each its character by the next one in the English alphabet (round-robin succession).
        /// </summary>
        /// <param name="inputString">Non-empty string consisting of lowercase English characters.</param>
        /// <returns>The result string after replacing all of its characters.</returns>
        string alphabeticShift(string inputString)
        {
            return string.Concat(inputString.Select(_ => ++_ > 'z' ? 'a' : _));
        }

        /// <summary>
        /// Given two cells on the standard chess board, determine whether they have the same color or not.
        /// </summary>
        /// <param name="cell1">The designation of the first cell.</param>
        /// <param name="cell2">The designation of the second cell.</param>
        /// <returns><c>true</c> if both cells have the same color, <c>false</c> otherwise.</returns>
        bool chessBoardCellColor(string cell1, string cell2)
        {
            return cell1.Sum(_ => _) % 2 == cell2.Sum(_ => _) % 2;
        }
    }
}
