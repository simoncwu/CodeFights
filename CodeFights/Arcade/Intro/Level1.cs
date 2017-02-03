using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 1":
    /// https://codefights.com/arcade/intro/level-1
    /// </summary>
    class Level1
    {
        /// <summary>
        /// A function that adds two numbers.
        /// </summary>
        /// <param name="param1">An integer.</param>
        /// <param name="param2">An integer.</param>
        /// <returns>The sum of the two inputs.</returns>
        int add(int param1, int param2)
        {
            return param1 + param2;
        }

        /// <summary>
        /// Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.
        /// </summary>
        /// <param name="year">A positive integer, designating the year.</param>
        /// <returns>The number of the century the year is in.</returns>
        int centuryFromYear(int year)
        {
            return --year / 100 + 1;
        }

        /// <summary>
        /// Given the string, check if it is a palindrome.
        /// </summary>
        /// <param name="inputString">A non-empty string consisting of lowercase characters.</param>
        /// <returns><c>true</c> if inputString is a palindrome, <c>false</c> otherwise.</returns>
        bool checkPalindrome(string inputString)
        {
            return inputString == new string(inputString.Reverse().ToArray());
        }
    }
}
